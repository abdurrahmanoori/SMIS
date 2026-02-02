using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockTransactions
{
    public class StockTransactionDto
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string StockBatchId { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string UnitId { get; set; } = string.Empty;
        public TransactionType Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? Reference { get; set; }
        public ProductDto? Product { get; set; }
        public StockBatchDto? StockBatch { get; set; }
        public UnitOfMeasureDto? UnitOfMeasure { get; set; }
    }
}