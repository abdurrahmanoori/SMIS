namespace SMIS.Application.DTO.ProductUnits;

public sealed class ProductUnitQueryCriteria
{
    public string? Id { get; set; }
    public string? ProductId { get; set; }
    public string? UnitOfMeasureId { get; set; }
    public decimal? BaseUnitQuantity { get; set; }
}
