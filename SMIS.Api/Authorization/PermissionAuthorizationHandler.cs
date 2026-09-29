using Microsoft.AspNetCore.Authorization;
using SMIS.Application.Identity.IServices;
using System.Security.Claims;

namespace SMIS.Api.Authorization;

public sealed class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    private readonly IComponentPermissionService _permissionService;

    public PermissionAuthorizationHandler(
        IComponentPermissionService permissionService
    )
    {
        _permissionService = permissionService;
    }

    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        PermissionRequirement requirement
    )
    {
        var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrWhiteSpace(userId)) return;

        if (await _permissionService.HasPermissionAsync(
                userId,
                requirement.ComponentKey,
                requirement.Action))
        {
            context.Succeed(requirement);
        }
    }
}
