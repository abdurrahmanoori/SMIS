using SMIS.Application.Attributes;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryCreateDto
    {
        [Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; } = string.Empty;

        [Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}