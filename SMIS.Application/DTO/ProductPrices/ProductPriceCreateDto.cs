namespace SMIS.Application.DTO.ProductPrices;

public class ProductPriceCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public int Price { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; } = true;
}
