using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
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

    public UserAdminResetPasswordCommandHandler(
        UserManager<ApplicationUser> userManager,
        IUserAdministrationGuard userAdministrationGuard
    )
    {
        _userManager = userManager;
        _userAdministrationGuard = userAdministrationGuard;
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
        var resetResult = await _userManager.ResetPasswordAsync(
            user,
            resetToken,
            user.UserName);

        if (!resetResult.Succeeded)
        {
            return Result.Failure(resetResult.Errors
                .Select(error => Error.Validation(
                    error.Code,
                    error.Description,
                    nameof(ApplicationUser.UserName)))
                .ToArray());
        }

        return Result.Success();
    }
}