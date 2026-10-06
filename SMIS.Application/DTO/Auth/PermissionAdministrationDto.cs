using System.ComponentModel.DataAnnotations;

namespace SMIS.Application.DTO.Auth;

public sealed record ApplicationComponentAdminDto(
    string Id, string Key, string Name, int DisplayOrder, bool IsActive);
public sealed record PermissionRoleDto(string Id, string Name);
public sealed record RoleComponentPermissionAdminDto(
    string ComponentId, bool CanView, bool CanRead, bool CanCreate, bool CanUpdate, bool CanDelete);

public sealed class UpdateApplicationComponentDto
{
    [Required, StringLength(200)]
    public string Name { get; set; } = string.Empty;
    [Range(0, int.MaxValue)]
    public int DisplayOrder { get; set; }
    public bool IsActive { get; set; }
}

public sealed class UpdateRoleComponentPermissionsDto
{
    [Required, MinLength(1)]
    public List<RoleComponentPermissionAdminDto> Permissions { get; set; } = [];
}
