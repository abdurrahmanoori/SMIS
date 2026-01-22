using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.UnitOfMeasures;

namespace SMIS.Application.DTO.ProductUnits
{
    public class ProductUnitDto
    {
        public string ProductId { get; set; } = string.Empty;
        public string UnitOfMeasureId { get; set; } = string.Empty;
        public decimal ConversionFactor { get; set; }

        // Navigation properties as DTOs
        public ProductDto? Product { get; set; }
        public UnitOfMeasureDto? UnitOfMeasure { get; set; }
    }
}