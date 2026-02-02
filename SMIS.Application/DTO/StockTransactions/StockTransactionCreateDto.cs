using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockTransactions
{
    public class StockTransactionCreateDto
    {
        public string ShopId { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string StockBatchId { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string UnitId { get; set; } = string.Empty;
        public TransactionType Type { get; set; } = TransactionType.In;
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string? Reference { get; set; }
    }
}