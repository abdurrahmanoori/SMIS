using System.ComponentModel.DataAnnotations;

namespace SMIS.Application.DTO.Provinces
{
    public class ProvinceTranslationDto
    {
        public string Id { get; set; } = string.Empty;

        [Required]
        public string ProvinceId { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string LanguageCode { get; set; } = "en";

        [Required]
        public string LanguageId { get; set; } = string.Empty;

        public bool IsDefault { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;
    }
}