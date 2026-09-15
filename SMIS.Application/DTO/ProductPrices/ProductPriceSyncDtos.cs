namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceSyncUpdateDto
{
    public string ProductUnitId { get; set; } = string.Empty;
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
public sealed class ProductPriceSyncCreateDto : ProductPriceSyncUpdateDto { public string Id { get; set; } = string.Empty; public DateTime ClientCreatedDate { get; set; } public string? ClientCreatedBy { get; set; } }
public sealed class ProductPriceSyncDeleteDto { public DateTime ClientModifiedDate { get; set; } public string? ClientModifiedBy { get; set; } }
