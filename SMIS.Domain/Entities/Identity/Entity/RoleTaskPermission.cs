namespace SMIS.Domain.Entities.Identity.Entity;

public class RoleTaskPermission
{
    public string RoleId { get; set; } = string.Empty;
    public string TaskId { get; set; } = string.Empty;
    public bool IsAllowed { get; set; }

    public ApplicationRole Role { get; set; } = null!;
    public ApplicationTask Task { get; set; } = null!;
}
