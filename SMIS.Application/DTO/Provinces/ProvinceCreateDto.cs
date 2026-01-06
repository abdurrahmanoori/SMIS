using SMIS.Application.DTO.Localization;

namespace SMIS.Application.DTO.Provinces
{
    public class ProvinceCreateDto
    {
        public string Name { get; set; } = string.Empty; // Backward compatible
        public List<TranslationDto>? Translations { get; set; } // Optional: admin can send translations
    }
}
