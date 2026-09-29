namespace SMIS.Domain.Entities.Identity.Entity;

public class RoleComponentPermission
{
    public string RoleId { get; set; } = string.Empty;
    public string ComponentId { get; set; } = string.Empty;

    public bool CanView { get; set; }
    public bool CanRead { get; set; }
    public bool CanCreate { get; set; }
    public bool CanUpdate { get; set; }
    public bool CanDelete { get; set; }

    public ApplicationRole Role { get; set; } = null!;
    public ApplicationComponent Component { get; set; } = null!;
}
