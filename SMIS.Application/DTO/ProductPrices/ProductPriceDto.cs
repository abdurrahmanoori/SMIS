namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? ClientModifiedDate { get; set; }
    public DateTime LastModifiedUtc { get; set; }
    public bool IsDeleted { get; set; }
}