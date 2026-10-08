namespace SMIS.Application.DTO.Purchasing;

public sealed class SupplierPaymentCreateDto
{
    public long Amount { get; set; }
    public DateTime? PaidAtUtc { get; set; }
    public string PaymentMethod { get; set; } = "Cash";
    public string? ReferenceNumber { get; set; }
    public string? Notes { get; set; }
    public string? IdempotencyKey { get; set; }
}

public sealed class SupplierPaymentAllocationDto
{
    public string SupplierPayableId { get; set; } = string.Empty;
    public string PurchaseOrderId { get; set; } = string.Empty;
    public long Amount { get; set; }
}

public sealed class SupplierPaymentDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string SupplierId { get; set; } = string.Empty;
    public long Amount { get; set; }
    public DateTime PaidAtUtc { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string? ReferenceNumber { get; set; }
    public string? Notes { get; set; }
    public List<SupplierPaymentAllocationDto> Allocations { get; set; } = [];
}

public sealed class SupplierPayableDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string SupplierId { get; set; } = string.Empty;
    public string PurchaseOrderId { get; set; } = string.Empty;
    public long TotalAmount { get; set; }
    public long CreditAmount { get; set; }
    public long PaidAmount { get; set; }
    public long RemainingAmount { get; set; }
    public long CreditDue { get; set; }
}

public sealed class SupplierBalanceDto
{
    public string SupplierId { get; set; } = string.Empty;
    public long TotalReceived { get; set; }
    public long TotalReturns { get; set; }
    public long TotalPaid { get; set; }
    public long Outstanding { get; set; }
    public long SupplierCredit { get; set; }
}
