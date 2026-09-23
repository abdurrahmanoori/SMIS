using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Inventory;

/// <summary>
/// Common input for a stock operation that affects one known batch. Quantity is entered
/// in ProductUnitId and is normalized by InventoryService before inventory is changed.
/// </summary>
public class InventoryBatchOperationDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public DateTime? OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
    public string? IdempotencyKey { get; set; }
}

/// <summary>
/// Manual adjustments may move stock either IN or OUT. The reason remains Adjustment;
/// callers choose only the physical direction, not an arbitrary business reason.
/// </summary>
public sealed class InventoryAdjustmentDto : InventoryBatchOperationDto
{
    public StockMovementDirection Direction { get; set; }
}

/// <summary>
/// Moves stock between two existing batches. InventoryService validates that the two
/// batches are compatible before any balance is staged for persistence.
/// </summary>
public sealed class InventoryTransferDto
{
    public string SourceStockBatchId { get; set; } = string.Empty;
    public string DestinationStockBatchId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public DateTime? OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
    public string? IdempotencyKey { get; set; }
}