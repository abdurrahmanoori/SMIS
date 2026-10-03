using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
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

    public UserSetLockoutCommandHandler(
        UserManager<ApplicationUser> userManager,
        IUserAdministrationGuard userAdministrationGuard
    )
    {
        _userManager = userManager;
        _userAdministrationGuard = userAdministrationGuard;
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

        if (request.IsLocked)
        {
            if (!user.LockoutEnabled)
            {
                var enableResult = await _userManager.SetLockoutEnabledAsync(user, true);
                if (!enableResult.Succeeded) return IdentityFailure(enableResult);
            }

            var lockResult = await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.MaxValue);
            return lockResult.Succeeded ? Result.Success() : IdentityFailure(lockResult);
        }

        var unlockResult = await _userManager.SetLockoutEndDateAsync(user, null);
        if (!unlockResult.Succeeded) return IdentityFailure(unlockResult);

        var resetFailedAttemptsResult = await _userManager.ResetAccessFailedCountAsync(user);
        return resetFailedAttemptsResult.Succeeded
            ? Result.Success()
            : IdentityFailure(resetFailedAttemptsResult);
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