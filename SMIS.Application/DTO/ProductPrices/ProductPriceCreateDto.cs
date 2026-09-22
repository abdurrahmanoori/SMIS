namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceCreateDto
{
    public string ProductUnitId { get; set; } = string.Empty;
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
}