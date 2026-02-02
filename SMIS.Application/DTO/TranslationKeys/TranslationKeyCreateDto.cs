using SMIS.Application.DTO.Translations;

namespace SMIS.Application.DTO.TranslationKeys
{
    public class TranslationKeyCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string? MessageCode { get; set; }
        public string ShopId { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public ICollection<TranslationEntityCreateDto> Translations { get; set; } = new List<TranslationEntityCreateDto>();
    }
}