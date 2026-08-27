using SMIS.Application.Attributes;

namespace SMIS.Application.DTO.Categories
{
    public class CategoryDto
    {
        public string Id { get; set; } = string.Empty;

        //[Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; } = string.Empty;

        //[Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
        public string ShopId { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? ClientCreatedDate { get; set; }
        public string? ClientCreatedBy { get; set; }
        public DateTime? ClientModifiedDate { get; set; }
        public string? ClientModifiedBy { get; set; }
        public DateTime ConflictModifiedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
