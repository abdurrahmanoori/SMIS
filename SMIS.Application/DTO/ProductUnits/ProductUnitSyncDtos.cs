namespace SMIS.Application.DTO.ProductUnits;

public class ProductUnitSyncUpdateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string UnitOfMeasureId { get; set; } = string.Empty;
    public decimal ConversionFactor { get; set; }
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
public sealed class ProductUnitSyncCreateDto : ProductUnitSyncUpdateDto { public string Id { get; set; } = string.Empty; public DateTime ClientCreatedDate { get; set; } public string? ClientCreatedBy { get; set; } }
public sealed class ProductUnitSyncDeleteDto { public DateTime ClientModifiedDate { get; set; } public string? ClientModifiedBy { get; set; } }
