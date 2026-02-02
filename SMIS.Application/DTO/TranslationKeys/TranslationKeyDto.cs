using SMIS.Application.DTO.Translations;

namespace SMIS.Application.DTO.TranslationKeys
{
    public class TranslationKeyDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? MessageCode { get; set; }
        public string ShopId { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public ICollection<TranslationEntityDto> Translations { get; set; } = new List<TranslationEntityDto>();
    }
}