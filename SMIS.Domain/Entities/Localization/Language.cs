namespace SMIS.Domain.Entities.Localization
{
    public class Language 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; } = string.Empty; // e.g. "en", "fr"
        public bool IsActive { get; set; } = true;
    }
}
