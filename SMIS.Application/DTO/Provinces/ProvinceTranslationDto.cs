using System.ComponentModel.DataAnnotations;

namespace SMIS.Application.DTO.Provinces
{
    public class ProvinceTranslationDto
    {
        public Guid Id { get; set; }

        [Required]
        public Guid ProvinceId { get; set; }

        [Required]
        [StringLength(10)]
        public string LanguageCode { get; set; } = "en";

        [Required]
        public Guid LanguageId { get; set; }

        public bool IsDefault { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;
    }
}