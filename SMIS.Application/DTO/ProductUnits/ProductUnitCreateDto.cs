namespace SMIS.Application.DTO.ProductUnits
{
    public class ProductUnitCreateDto
    {
        public string ShopId { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string UnitOfMeasureId { get; set; } = string.Empty;
        public decimal ConversionFactor { get; set; }
    }
}