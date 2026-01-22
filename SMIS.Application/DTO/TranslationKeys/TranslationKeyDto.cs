namespace SMIS.Application.DTO.TranslationKeys
{
    public class TranslationKeyDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? MessageCode { get; set; }
        public bool IsActive { get; set; }
    }
}