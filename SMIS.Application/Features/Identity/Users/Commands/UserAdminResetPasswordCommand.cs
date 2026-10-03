using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands;

public sealed record UserAdminResetPasswordCommand(
    string UserId
) : IRequest<Result>;

internal sealed class UserAdminResetPasswordCommandHandler
    : IRequestHandler<UserAdminResetPasswordCommand, Result>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserAdministrationGuard _userAdministrationGuard;
    private readonly IUnitOfWork _unitOfWork;

    public UserAdminResetPasswordCommandHandler(
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
        UserAdminResetPasswordCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByIdAsync(request.UserId);
        if (user is null) return Result.NotFound(request.UserId);

        if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
        {
            return Result.Forbidden(
                "user.administration_forbidden",
                "You are not allowed to reset this user's password.");
        }

        if (string.IsNullOrWhiteSpace(user.UserName))
        {
            return Result.BusinessRule(
                "user.username_required_for_password_reset",
                "The user's password cannot be reset because the account has no username.");
        }

        var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            user.InvalidateSessions();
            var resetResult = await _userManager.ResetPasswordAsync(
                user,
                resetToken,
                user.UserName);

            if (!resetResult.Succeeded)
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                return Result.Failure(resetResult.Errors
                    .Select(error => Error.Validation(
                        error.Code,
                        error.Description,
                        nameof(ApplicationUser.UserName)))
                    .ToArray());
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