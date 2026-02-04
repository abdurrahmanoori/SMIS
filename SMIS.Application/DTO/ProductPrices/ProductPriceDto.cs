using SMIS.Application.DTO.Products;

namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public int Price { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; }
    public ProductDto? Product { get; set; }
}
