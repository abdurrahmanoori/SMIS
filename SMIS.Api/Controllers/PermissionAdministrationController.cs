using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Authorization;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common.Contants;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Identity.Permissions;

namespace SMIS.Api.Controllers;

[Route("api/permission-administration")]
[HasCurrentRole(SD.Role_Super_Admin)]
public sealed class PermissionAdministrationController : BaseApiController
{
    [HttpGet("tasks")]
    public Task<ActionResult<IReadOnlyList<ManagedTaskDto>>> GetTasks(CancellationToken ct) =>
        HandleRequest(new GetManagedTasksQuery(), ct);

    [HttpPost("tasks")]
    public Task<IActionResult> CreateTask(SaveTaskDto dto, CancellationToken ct) =>
        HandleRequest(new SaveManagedTaskCommand(null, dto), ct);

    [HttpPut("tasks/{id}")]
    public Task<IActionResult> UpdateTask(string id, SaveTaskDto dto, CancellationToken ct) =>
        HandleRequest(new SaveManagedTaskCommand(id, dto), ct);

    [HttpDelete("tasks/{id}")]
    public Task<IActionResult> DeleteTask(string id, CancellationToken ct) =>
        HandleRequest(new DeleteManagedTaskCommand(id), ct);

    [HttpGet("roles")]
    public Task<ActionResult<IReadOnlyList<ManagedRoleDto>>> GetRoles(CancellationToken ct) =>
        HandleRequest(new GetManagedRolesQuery(), ct);

    [HttpPost("roles")]
    public Task<IActionResult> CreateRole(SaveRoleDto dto, CancellationToken ct) =>
        HandleRequest(new SaveManagedRoleCommand(null, dto), ct);

    [HttpPut("roles/{id}")]
    public Task<IActionResult> UpdateRole(string id, SaveRoleDto dto, CancellationToken ct) =>
        HandleRequest(new SaveManagedRoleCommand(id, dto), ct);

    [HttpDelete("roles/{id}")]
    public Task<IActionResult> DeleteRole(string id, CancellationToken ct) =>
        HandleRequest(new DeleteManagedRoleCommand(id), ct);

    [HttpGet("roles/{roleId}/task-permissions")]
    public Task<ActionResult<IReadOnlyList<ManagedTaskPermissionDto>>> GetTaskPermissions(string roleId, CancellationToken ct) =>
        HandleRequest(new GetManagedTaskPermissionsQuery(roleId), ct);

    [HttpPut("roles/{roleId}/task-permissions")]
    public Task<IActionResult> SaveTaskPermissions(string roleId, SaveTaskPermissionsDto dto, CancellationToken ct) =>
        HandleRequest(new SaveManagedTaskPermissionsCommand(roleId, dto), ct);

    [HttpDelete("roles/{roleId}/task-permissions/{taskId}")]
    public Task<IActionResult> DeleteTaskPermission(string roleId, string taskId, CancellationToken ct) =>
        HandleRequest(new DeleteManagedTaskPermissionCommand(roleId, taskId), ct);

    [HttpGet("catalog")]
    public Task<ActionResult<PermissionCatalogDto>> GetCatalog(CancellationToken ct) =>
        HandleRequest(new GetPermissionCatalogQuery(), ct);

    [HttpPut("components/{id}")]
    public Task<IActionResult> UpdateComponent(string id, UpdateApplicationComponentDto dto, CancellationToken ct) =>
        HandleRequest(new UpdateApplicationComponentCommand(id, dto), ct);

    [HttpGet("roles/{roleId}/permissions")]
    public Task<ActionResult<IReadOnlyList<RoleComponentPermissionAdminDto>>> GetRolePermissions(string roleId, CancellationToken ct) =>
        HandleRequest(new GetRoleComponentPermissionsQuery(roleId), ct);

    [HttpPut("roles/{roleId}/permissions")]
    public Task<IActionResult> UpdateRolePermissions(string roleId, UpdateRoleComponentPermissionsDto dto, CancellationToken ct) =>
        HandleRequest(new UpdateRoleComponentPermissionsCommand(roleId, dto), ct);
}
