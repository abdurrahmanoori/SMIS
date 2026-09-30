namespace SMIS.Application.DTO.ProductPrices;

public sealed class ProductPriceQueryCriteria
{
    public string? Id { get; set; }
    public string? ProductUnitId { get; set; }
    public long? SellPrice { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
}
