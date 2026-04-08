using SMIS.Application.Attributes;
using SMIS.Application.DTO.Common;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryUpdateDto : BaseUpdateDto
    {
        //[Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; }

        //[Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
