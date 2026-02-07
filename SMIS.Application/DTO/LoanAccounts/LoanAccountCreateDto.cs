namespace SMIS.Application.DTO.LoanAccounts;

public class LoanAccountCreateDto
{
    public string CustomerId { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public string UnitId { get; set; } = string.Empty;
    public long TotalAmount { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Notes { get; set; }
}
