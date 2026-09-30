using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches;

public sealed class StockBatchQueryCriteria
{
    public string? Id { get; set; }
    public string? ShopId { get; set; }
    public string? ProductId { get; set; }
    public string? ReceivedProductUnitId { get; set; }
    public decimal? ReceivedQuantity { get; set; }
    public decimal? ReceivedQuantityBase { get; set; }
    public decimal? RemainingQuantityBase { get; set; }
    public long? UnitCostBase { get; set; }
    public string? BatchNumber { get; set; }
    public DateTime? ReceivedAtUtc { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public StatusEnum? Status { get; set; }
}
