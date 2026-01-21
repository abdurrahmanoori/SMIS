using SMIS.Application.Attributes;

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
    }
}