using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Sales;

public sealed class SaleDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string? CustomerId { get; set; }
    public DateTime SaleDateUtc { get; set; }
    public SalePaymentType PaymentType { get; set; }
    public long TotalAmount { get; set; }
    public long ReturnedAmount { get; set; }
    public long NetAmount { get; set; }
    public SaleStatus Status { get; set; }
    public string? Notes { get; set; }
    public string? ReceivableId { get; set; }
    public long? ReceivableRemainingAmount { get; set; }
    public List<SaleLineDto> Lines { get; set; } = [];
}

public sealed class SaleLineDto
{
    public string Id { get; set; } = string.Empty;
    public string SaleId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public decimal ReturnedQuantityEntered { get; set; }
    public decimal ReturnableQuantityEntered { get; set; }
    public long UnitPrice { get; set; }
    public long LineTotal { get; set; }
}