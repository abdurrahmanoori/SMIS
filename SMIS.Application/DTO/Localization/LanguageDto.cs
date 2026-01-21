namespace SMIS.Application.DTO.Localization
{
    public class LanguageDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }

    public class LanguageCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
