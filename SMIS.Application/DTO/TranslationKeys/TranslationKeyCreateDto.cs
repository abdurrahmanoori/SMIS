namespace SMIS.Application.DTO.TranslationKeys
{
    public class TranslationKeyCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string? MessageCode { get; set; }
        public bool IsActive { get; set; } = true;
    }
}