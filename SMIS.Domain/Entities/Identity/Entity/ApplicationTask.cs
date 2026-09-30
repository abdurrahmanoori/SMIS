namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationTask
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string ComponentId { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;

    public ApplicationComponent Component { get; set; } = null!;
}
