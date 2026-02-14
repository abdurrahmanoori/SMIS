using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.Products;

namespace SMIS.Application.DTO.LoanAccounts;

public class LoanAccountDto
{
    public string Id { get; set; } = string.Empty;
    public string CustomerId { get; set; } = string.Empty;
    public string? CustomerName { get; set; }
    public string ShopId { get; set; } = string.Empty;
    public string? ShopName { get; set; }
    public string ProductId { get; set; } = string.Empty;
    public string? ProductName { get; set; }
    public decimal Quantity { get; set; }
    public string UnitId { get; set; } = string.Empty;
    public string? UnitName { get; set; }
    public decimal PriceAtLoanTime { get; set; }
    public long TotalAmount { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? DueDate { get; set; }
    public string Status { get; set; } = "Active";
    public string? Notes { get; set; }
    public bool IsActive { get; set; }
    public long PaidAmount { get; set; }
    public long RemainingAmount { get; set; }
    public CustomerDto? Customer { get; set; }
    public ProductDto? Product { get; set; }
}
