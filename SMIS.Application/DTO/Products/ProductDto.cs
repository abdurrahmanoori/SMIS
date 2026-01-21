using SMIS.Application.Attributes;
using SMIS.Application.DTO.Categories;

namespace SMIS.Application.DTO.Products
{
    public class ProductDto
    {
        public string Id { get; set; } = string.Empty;

        [Translatable]
        public string Name { get; set; } = string.Empty;

        public string ShopId { get; set; } = string.Empty;
        public string BaseUnitId { get; set; } = string.Empty;
        public int SalePricePerBaseUnit { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string SKU { get; set; } = string.Empty; // Unique identifier
        public string? Barcode { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryId { get; set; }
        public CategoryDto? Category { get; set; }
    }
}