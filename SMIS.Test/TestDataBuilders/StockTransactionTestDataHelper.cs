using SMIS.Application.DTO.StockTransactions;
using SMIS.Domain.Enums;
using SMIS.Test.Utilities;

namespace SMIS.Test.TestDataBuilders
{
    public class StockTransactionTestDataHelper
    {
        private readonly HttpClient _client;

        public StockTransactionTestDataHelper(HttpClient client)
        {
            _client = client;
        }

        public async Task GetOrCreateDependencies()
        {
            // Dependencies are seeded in database
        }

        public StockTransactionBuilder CreateStockTransactionBuilder()
        {
            return new StockTransactionBuilder();
        }
    }

    public class StockTransactionBuilder
    {
        private readonly StockTransactionCreateDto _dto = new()
        {
            ShopId = "1", // Main Store
            ProductId = "1", // Coca Cola
            StockBatchId = "1",
            Quantity = 10m,
            UnitId = "2", // Bottle
            Type = TransactionType.In,
            TransactionDate = DateTime.Now,
            Reference = "Test Transaction"
        };

        public StockTransactionBuilder WithShopId(string shopId)
        {
            _dto.ShopId = shopId;
            return this;
        }

        public StockTransactionBuilder WithProductId(string productId)
        {
            _dto.ProductId = productId;
            return this;
        }

        public StockTransactionBuilder WithStockBatchId(string stockBatchId)
        {
            _dto.StockBatchId = stockBatchId;
            return this;
        }

        public StockTransactionBuilder WithQuantity(decimal quantity)
        {
            _dto.Quantity = quantity;
            return this;
        }

        public StockTransactionBuilder WithUnitId(string unitId)
        {
            _dto.UnitId = unitId;
            return this;
        }

        public StockTransactionBuilder WithType(TransactionType type)
        {
            _dto.Type = type;
            return this;
        }

        public StockTransactionBuilder WithTransactionDate(DateTime transactionDate)
        {
            _dto.TransactionDate = transactionDate;
            return this;
        }

        public StockTransactionBuilder WithReference(string? reference)
        {
            _dto.Reference = reference;
            return this;
        }

        public StockTransactionCreateDto Build() => _dto;
    }
}