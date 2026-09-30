using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Sales;

public sealed class SaleQueryCriteria
{
    public string? Id { get; set; }
    public string? ShopId { get; set; }
    public string? CustomerId { get; set; }
    public DateTime? SaleDateUtc { get; set; }
    public SalePaymentType? PaymentType { get; set; }
    public long? TotalAmount { get; set; }
    public long? ReturnedAmount { get; set; }
    public long? NetAmount { get; set; }
    public SaleStatus? Status { get; set; }
    public string? Notes { get; set; }
    public string? ReceivableId { get; set; }
    public long? ReceivableRemainingAmount { get; set; }
}