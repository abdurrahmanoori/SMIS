using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches
{
    public class StockBatchDto
    {
        public string Id { get; set; } = string.Empty;
        public string ShopId { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string ReceivedProductUnitId { get; set; } = string.Empty;
        public decimal ReceivedQuantity { get; set; }
        public decimal ReceivedQuantityBase { get; set; }
        public decimal RemainingQuantityBase { get; set; }
        public long UnitCostBase { get; set; }
        public string? BatchNumber { get; set; }
        public DateTime ReceivedAtUtc { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public StatusEnum Status { get; set; }
    }
}