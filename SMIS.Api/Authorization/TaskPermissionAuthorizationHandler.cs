using Microsoft.AspNetCore.Authorization;
using SMIS.Application.Identity.IServices;
using System.Security.Claims;

namespace SMIS.Api.Authorization;

public sealed class TaskPermissionAuthorizationHandler : AuthorizationHandler<TaskPermissionRequirement>
{
    private readonly ITaskPermissionService _permissionService;

    public TaskPermissionAuthorizationHandler(
        ITaskPermissionService permissionService
    )
    {
        _permissionService = permissionService;
    }

    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        TaskPermissionRequirement requirement
    )
    {
        var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrWhiteSpace(userId)) return;

        if (await _permissionService.HasTaskPermissionAsync(userId, requirement.TaskKey))
        {
            context.Succeed(requirement);
        }
    }
}
