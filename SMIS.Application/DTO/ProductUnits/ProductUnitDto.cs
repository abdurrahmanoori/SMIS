using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.UnitOfMeasures;

namespace SMIS.Application.DTO.ProductUnits
{
    public class ProductUnitDto
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string UnitOfMeasureId { get; set; } = string.Empty;
        public decimal ConversionFactor { get; set; }
        public DateTime? ClientCreatedDate { get; set; }
        public string? ClientCreatedBy { get; set; }
        public DateTime? ClientModifiedDate { get; set; }
        public string? ClientModifiedBy { get; set; }
        public DateTime ConflictModifiedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation properties as DTOs
        public ProductDto? Product { get; set; }
        public UnitOfMeasureDto? UnitOfMeasure { get; set; }
    }
}
