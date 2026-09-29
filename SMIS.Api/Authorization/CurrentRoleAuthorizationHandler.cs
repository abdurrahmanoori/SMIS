using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Api.Authorization;

public sealed class CurrentRoleAuthorizationHandler : AuthorizationHandler<CurrentRoleRequirement>
{
    private readonly UserManager<ApplicationUser> _userManager;

    public CurrentRoleAuthorizationHandler(
        UserManager<ApplicationUser> userManager
    )
    {
        _userManager = userManager;
    }

    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        CurrentRoleRequirement requirement
    )
    {
        var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrWhiteSpace(userId)) return;

        var user = await _userManager.FindByIdAsync(userId);
        if (user is not null && await _userManager.IsInRoleAsync(user, requirement.RoleName))
        {
            context.Succeed(requirement);
        }
    }
}
