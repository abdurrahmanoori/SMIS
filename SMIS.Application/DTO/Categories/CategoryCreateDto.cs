using SMIS.Application.Attributes;
using SMIS.Application.DTO.Common;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryCreateDto : BaseCreateDto
    {
        //[Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; } = string.Empty;

        //[Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
