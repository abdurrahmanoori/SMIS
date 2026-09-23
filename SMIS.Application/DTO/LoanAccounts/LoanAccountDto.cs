using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.LoanAccounts;

public class LoanAccountDto
{
    public string Id { get; set; } = string.Empty;
    public string SaleId { get; set; } = string.Empty;
    public string CustomerId { get; set; } = string.Empty;
    public string? CustomerName { get; set; }
    public string ShopId { get; set; } = string.Empty;
    public string? ShopName { get; set; }
    public long TotalAmount { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? DueDate { get; set; }
    public LoanStatus Status { get; set; } = LoanStatus.Unpaid;
    public string? Notes { get; set; }
    public bool IsActive { get; set; }
    public long PaidAmount { get; set; }
    public long RemainingAmount { get; set; }
}