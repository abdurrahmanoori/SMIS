using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockMovements;

/// <summary>
/// Represents one logical FIFO issue request. The application may split it across
/// multiple physical batches while preserving the entered ProductUnit and quantity.
/// </summary>
public sealed class FifoStockIssueDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public StockMovementReason Reason { get; set; } = StockMovementReason.Sale;
    public DateTime? OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
}