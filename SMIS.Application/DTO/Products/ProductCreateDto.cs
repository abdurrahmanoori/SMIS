using SMIS.Application.Attributes;

namespace SMIS.Application.DTO.Products
{
    public class ProductCreateDto
    {
        [Translatable]
        public string Name { get; set; } = string.Empty;

        public string ShopId { get; set; } = string.Empty;
        public string BaseUnitId { get; set; } = string.Empty;
        public int SalePricePerBaseUnit { get; set; }
        [Translatable]

        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public string SKU { get; set; } = string.Empty; // Unique identifier
        public string? Barcode { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryId { get; set; }
    }
}