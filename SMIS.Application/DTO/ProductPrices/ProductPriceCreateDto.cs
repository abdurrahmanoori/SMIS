namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public long BuyPrice { get; set; }
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; } = true;
}
