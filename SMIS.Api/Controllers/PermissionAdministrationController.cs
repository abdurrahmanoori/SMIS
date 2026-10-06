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
