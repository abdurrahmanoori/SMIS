namespace SMIS.Application.DTO.Products;

public class ProductLoanInfoDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string BaseUnitId { get; set; } = string.Empty;
    public string BaseUnitName { get; set; } = string.Empty;
    public long LatestSellPrice { get; set; }
    public long LatestBuyPrice { get; set; }
    public DateTime? PriceEffectiveDate { get; set; }
    public bool HasActivePrice { get; set; }
}
