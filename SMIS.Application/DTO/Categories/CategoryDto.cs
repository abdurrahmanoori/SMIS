using SMIS.Application.Attributes;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryDto
    {
        public string Id { get; set; } = string.Empty;

        [Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; } = string.Empty;

        [Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
        public string ShopId { get; set; } = string.Empty;
        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}