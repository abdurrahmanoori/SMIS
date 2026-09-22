using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockMovements;

public sealed class StockMovementDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public string OperationId { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public decimal QuantityBase { get; set; }
    public StockMovementDirection Direction { get; set; }
    public StockMovementReason Reason { get; set; }
    public DateTime OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
}