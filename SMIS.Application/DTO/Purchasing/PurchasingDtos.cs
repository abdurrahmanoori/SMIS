using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Purchasing;

public sealed class SupplierCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Notes { get; set; }
}

public sealed class SupplierDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Notes { get; set; }
    public bool IsActive { get; set; }
}

public sealed class PurchaseOrderCreateDto
{
    public string SupplierId { get; set; } = string.Empty;
    public string? ReferenceNumber { get; set; }
    public DateTime? OrderedAtUtc { get; set; }
    public string? Notes { get; set; }
    public string? IdempotencyKey { get; set; }
    public List<PurchaseOrderLineCreateDto> Lines { get; set; } = [];
}

public sealed class PurchaseOrderLineCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public long UnitCostBase { get; set; }
}

public sealed class PurchaseOrderReceiveDto
{
    public DateTime? OccurredAtUtc { get; set; }
    public string? IdempotencyKey { get; set; }
    public List<PurchaseOrderReceiptLineDto> Lines { get; set; } = [];
}

public sealed class PurchaseOrderReceiptLineDto
{
    public string PurchaseOrderLineId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public string? BatchNumber { get; set; }
    public DateTime? ExpirationDate { get; set; }
}

public sealed class PurchaseOrderSupplierReturnDto
{
    public string PurchaseOrderLineId { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public DateTime? OccurredAtUtc { get; set; }
    public string? IdempotencyKey { get; set; }
}

public sealed class PurchaseOrderDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string SupplierId { get; set; } = string.Empty;
    public string SupplierName { get; set; } = string.Empty;
    public string? ReferenceNumber { get; set; }
    public DateTime OrderedAtUtc { get; set; }
    public PurchaseOrderStatus Status { get; set; }
    public string? Notes { get; set; }
    public List<PurchaseOrderLineDto> Lines { get; set; } = [];
}

public sealed class PurchaseOrderLineDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal OrderedQuantityEntered { get; set; }
    public decimal ReceivedQuantityEntered { get; set; }
    public decimal ReturnedQuantityEntered { get; set; }
    public decimal RemainingToReceiveQuantityEntered { get; set; }
    public decimal NetReceivedQuantityEntered { get; set; }
    public long UnitCostBase { get; set; }
}
