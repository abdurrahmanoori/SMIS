using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches
{
    public class StockBatchDto
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string? BatchNumber { get; set; }
        public decimal Quantity { get; set; }
        public string UnitId { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public long PurchasePrice { get; set; }
        public StatusEnum Status { get; set; }
    }
}