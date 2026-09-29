namespace SMIS.Application.DTO.Auth;

public sealed class ComponentPermissionDto
{
    public string ComponentKey { get; init; } = string.Empty;
    public bool CanView { get; init; }
    public bool CanRead { get; init; }
    public bool CanCreate { get; init; }
    public bool CanUpdate { get; init; }
    public bool CanDelete { get; init; }
}
