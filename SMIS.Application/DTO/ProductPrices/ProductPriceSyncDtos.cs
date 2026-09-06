namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceSyncUpdateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public long BuyPrice { get; set; }
    public long SellPrice { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
public sealed class ProductPriceSyncCreateDto : ProductPriceSyncUpdateDto { public string Id { get; set; } = string.Empty; public DateTime ClientCreatedDate { get; set; } public string? ClientCreatedBy { get; set; } }
public sealed class ProductPriceSyncDeleteDto { public DateTime ClientModifiedDate { get; set; } public string? ClientModifiedBy { get; set; } }
