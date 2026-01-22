namespace SMIS.Application.DTO.Translations
{
    public class TranslationEntityCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string TranslationKeyId { get; set; } = string.Empty;
        public string LanguageNo { get; set; } = string.Empty;
    }
}