using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Authorization;

public sealed class CurrentRoleAuthorizationHandler : AuthorizationHandler<CurrentRoleRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        CurrentRoleRequirement requirement
    )
    {
        if (context.User.IsInRole(requirement.RoleName))
        {
            context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }
}