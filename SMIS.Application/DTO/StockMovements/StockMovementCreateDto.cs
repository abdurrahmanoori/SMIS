using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockMovements;

/// <summary>
/// Input for posting a movement against one specific batch. QuantityEntered uses
/// ProductUnitId; QuantityBase is derived server-side and is never accepted from clients.
/// </summary>
public sealed class StockMovementCreateDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public StockMovementDirection Direction { get; set; }
    public StockMovementReason Reason { get; set; }
    public DateTime? OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
}