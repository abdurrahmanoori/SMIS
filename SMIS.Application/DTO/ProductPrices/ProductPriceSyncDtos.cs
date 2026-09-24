namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceSyncUpdateDto
{
    public string ProductUnitId { get; set; } = string.Empty;
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class ProductPriceSyncCreateDto : ProductPriceSyncUpdateDto
{
    public string Id { get; set; } = string.Empty;
}

public sealed class ProductPriceSyncDeleteDto
{
    public DateTime ClientModifiedDate { get; set; }
}