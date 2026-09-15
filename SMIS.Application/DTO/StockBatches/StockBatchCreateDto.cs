using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches
{
public class StockBatchCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ReceivedProductUnitId { get; set; } = string.Empty;
    public decimal ReceivedQuantity { get; set; }
    public long UnitCostBase { get; set; }
    public string? BatchNumber { get; set; }
    public DateTime? ReceivedAtUtc { get; set; }
    public DateTime? ExpirationDate { get; set; }
}
}