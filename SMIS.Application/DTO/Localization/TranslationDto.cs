namespace SMIS.Application.DTO.Localization
{
    public class TranslationDto
    {
        public string LanguageCode { get; set; } = "en";
        public string LanguageId { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
