using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands;

public sealed record UserSetLockoutCommand(
    string UserId,
    bool IsLocked
) : IRequest<Result>;

internal sealed class UserSetLockoutCommandHandler : IRequestHandler<UserSetLockoutCommand, Result>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserAdministrationGuard _userAdministrationGuard;
    private readonly IUnitOfWork _unitOfWork;

    public UserSetLockoutCommandHandler(
        UserManager<ApplicationUser> userManager,
        IUserAdministrationGuard userAdministrationGuard,
        IUnitOfWork unitOfWork
    )
    {
        _userManager = userManager;
        _userAdministrationGuard = userAdministrationGuard;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        UserSetLockoutCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByIdAsync(request.UserId);
        if (user is null) return Result.NotFound(request.UserId);

        if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
        {
            return Result.Forbidden(
                "user.administration_forbidden",
                "You are not allowed to change this user's lock status.");
        }

        var isCurrentlyLocked = await _userManager.IsLockedOutAsync(user);
        if (request.IsLocked == isCurrentlyLocked)
            return Result.Success();

        if (request.IsLocked &&
            await _userAdministrationGuard.WouldLockLastAvailableSuperAdminAsync(
                user.Id,
                cancellationToken))
        {
            return Result.BusinessRule(
                "user.last_available_super_admin",
                "The last available SuperAdmin account cannot be locked.");
        }

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            if (request.IsLocked)
            {
                if (!user.LockoutEnabled)
                {
                    var enableResult = await _userManager.SetLockoutEnabledAsync(user, true);
                    if (!enableResult.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return IdentityFailure(enableResult);
                    }
                }

                user.InvalidateSessions();
                var lockResult = await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.MaxValue);
                if (!lockResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return IdentityFailure(lockResult);
                }
            }
            else
            {
                user.InvalidateSessions();
                var unlockResult = await _userManager.SetLockoutEndDateAsync(user, null);
                if (!unlockResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return IdentityFailure(unlockResult);
                }

                var resetFailedAttemptsResult = await _userManager.ResetAccessFailedCountAsync(user);
                if (!resetFailedAttemptsResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return IdentityFailure(resetFailedAttemptsResult);
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

    private static Result IdentityFailure(
        IdentityResult identityResult
    ) => Result.Failure(identityResult.Errors
        .Select(error => new Error
        {
            Code = error.Code,
            Description = error.Description,
            Type = ErrorType.Failure
        })
        .ToArray());
}