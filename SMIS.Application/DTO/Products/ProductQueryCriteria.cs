namespace SMIS.Application.DTO.Products;

public sealed class ProductQueryCriteria
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ShopId { get; set; }
    public string? BaseUnitId { get; set; }
    public string? Description { get; set; }
    public bool? IsActive { get; set; }
    public string? SKU { get; set; }
    public string? Barcode { get; set; }
    public string? ImageUrl { get; set; }
    public string? CategoryId { get; set; }
    public decimal? ReorderPointBase { get; set; }
    public decimal? ReorderQuantityBase { get; set; }
}
