using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches
{
    /// <summary>
    /// Receipt input. Quantity is entered in ReceivedProductUnitId and is normalized
    /// to the product base unit by the application layer before inventory is posted.
    /// </summary>
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