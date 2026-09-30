using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.LoanAccounts;

public sealed class LoanAccountQueryCriteria
{
    public string? Id { get; set; }
    public string? SaleId { get; set; }
    public string? CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public string? ShopId { get; set; }
    public string? ShopName { get; set; }
    public long? TotalAmount { get; set; }
    public DateTime? LoanDate { get; set; }
    public DateTime? DueDate { get; set; }
    public LoanStatus? Status { get; set; }
    public string? Notes { get; set; }
    public bool? IsActive { get; set; }
    public long? PaidAmount { get; set; }
    public long? RemainingAmount { get; set; }
}