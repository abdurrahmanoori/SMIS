namespace SMIS.Application.DTO.Products;

public class ProductSyncUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public string BaseUnitId { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;
    public string? SKU { get; set; }
    public string? Barcode { get; set; }
    public string? ImageUrl { get; set; }
    public string CategoryId { get; set; } = string.Empty;
    public decimal ReorderPointBase { get; set; }
    public decimal ReorderQuantityBase { get; set; }
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class ProductSyncCreateDto : ProductSyncUpdateDto
{
    public string Id { get; set; } = string.Empty;
}

public sealed class ProductSyncDeleteDto
{
    public DateTime ClientModifiedDate { get; set; }
}