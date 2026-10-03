using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands;

public sealed record UserSetActiveStatusCommand(
    string UserId,
    bool IsActive
) : IRequest<Result>;

internal sealed class UserSetActiveStatusCommandHandler
    : IRequestHandler<UserSetActiveStatusCommand, Result>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserAdministrationGuard _userAdministrationGuard;

    public UserSetActiveStatusCommandHandler(
        UserManager<ApplicationUser> userManager,
        IUserAdministrationGuard userAdministrationGuard
    )
    {
        _userManager = userManager;
        _userAdministrationGuard = userAdministrationGuard;
    }

    public async Task<Result> Handle(
        UserSetActiveStatusCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByIdAsync(request.UserId);
        if (user is null) return Result.NotFound(request.UserId);

        if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
        {
            return Result.Forbidden(
                "user.administration_forbidden",
                "You are not allowed to change this user's active status.");
        }

        if (user.IsActive == request.IsActive) return Result.Success();

        if (!request.IsActive &&
            await _userAdministrationGuard.WouldDeactivateLastAvailableSuperAdminAsync(
                user.Id,
                cancellationToken))
        {
            return Result.BusinessRule(
                "user.last_available_super_admin",
                "The last available SuperAdmin account cannot be deactivated.");
        }

        if (request.IsActive)
            user.Activate();
        else
            user.Deactivate();

        var updateResult = await _userManager.UpdateAsync(user);
        return updateResult.Succeeded
            ? Result.Success()
            : Result.Failure(updateResult.Errors
                .Select(error => new Error
                {
                    Code = error.Code,
                    Description = error.Description,
                    Type = ErrorType.Failure
                })
                .ToArray());
    }
}

public sealed record UserSetAllShopAdminsActiveStatusCommand(
    bool IsActive
) : IRequest<Result>;

internal sealed class UserSetAllShopAdminsActiveStatusCommandHandler
    : IRequestHandler<UserSetAllShopAdminsActiveStatusCommand, Result>
{
    private readonly IApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public UserSetAllShopAdminsActiveStatusCommandHandler(
        IApplicationDbContext context,
        UserManager<ApplicationUser> userManager,
        IUnitOfWork unitOfWork
    )
    {
        _context = context;
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        UserSetAllShopAdminsActiveStatusCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopAdminRoleId = await _context.Roles
            .AsNoTracking()
            .Where(role => role.Name == SD.Role_Shop_Admin)
            .Select(role => role.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (string.IsNullOrWhiteSpace(shopAdminRoleId))
            return Result.BusinessRule(
                "user.shop_admin_role_missing",
                "The ShopAdmin role is not configured.");

        var superAdminRoleId = await _context.Roles
            .AsNoTracking()
            .Where(role => role.Name == SD.Role_Super_Admin)
            .Select(role => role.Id)
            .FirstOrDefaultAsync(cancellationToken);

        var shopAdminUsersQuery = _context.UserRoles
            .AsNoTracking()
            .Where(userRole => userRole.RoleId == shopAdminRoleId);

        if (!string.IsNullOrWhiteSpace(superAdminRoleId))
        {
            shopAdminUsersQuery = shopAdminUsersQuery.Where(userRole =>
                !_context.UserRoles.Any(otherRole =>
                    otherRole.UserId == userRole.UserId &&
                    otherRole.RoleId == superAdminRoleId));
        }

        var shopAdminUserIds = await shopAdminUsersQuery
            .Select(userRole => userRole.UserId)
            .Distinct()
            .ToListAsync(cancellationToken);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            foreach (var userId in shopAdminUserIds)
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user is null || user.IsActive == request.IsActive) continue;

                if (request.IsActive)
                    user.Activate();
                else
                    user.Deactivate();

                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result.Failure(updateResult.Errors
                        .Select(error => new Error
                        {
                            Code = error.Code,
                            Description = error.Description,
                            Type = ErrorType.Failure
                        })
                        .ToArray());
                }
            }

            await _unitOfWork.CommitTransactionAsync(cancellationToken);
            return Result.Success();
        }
        catch
        {
            if (_unitOfWork.HasActiveTransaction)
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }
    }
}
