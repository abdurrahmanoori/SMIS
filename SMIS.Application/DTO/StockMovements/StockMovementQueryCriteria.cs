using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockMovements;

public sealed class StockMovementQueryCriteria
{
    public string? Id { get; set; }
    public string? ShopId { get; set; }
    public string? OperationId { get; set; }
    public string? StockBatchId { get; set; }
    public string? ProductUnitId { get; set; }
    public decimal? QuantityEntered { get; set; }
    public decimal? QuantityBase { get; set; }
    public StockMovementDirection? Direction { get; set; }
    public StockMovementReason? Reason { get; set; }
    public DateTime? OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
}
