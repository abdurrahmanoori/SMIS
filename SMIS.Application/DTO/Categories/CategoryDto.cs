using SMIS.Application.DTO.Localization;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryDto
    {
        public string Id { get; set; } = string.Empty;

        // Resolved for the signed-in user's preferred language.
        public string Name { get; set; } = string.Empty;

        public string EnglishName { get; set; } = string.Empty;
        public string? DariName { get; set; }
        public string NameLocalizedTextId { get; set; } = string.Empty;
        public List<LocalizedTextValueDto> NameTranslations { get; set; } = [];

        public string? Code { get; set; } = string.Empty;
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
        public string ShopId { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? ClientModifiedDate { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
