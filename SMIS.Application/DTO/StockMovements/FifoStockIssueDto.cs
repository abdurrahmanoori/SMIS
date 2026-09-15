using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockMovements;

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
