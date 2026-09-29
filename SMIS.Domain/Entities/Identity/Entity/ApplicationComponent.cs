namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationComponent
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public bool ShowInMenu { get; set; } = true;
    public bool IsActive { get; set; } = true;
}
