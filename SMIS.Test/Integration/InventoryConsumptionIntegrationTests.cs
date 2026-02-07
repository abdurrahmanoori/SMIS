using System.Net;
using Shouldly;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestDataBuilders;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Integration;

public class InventoryConsumptionIntegrationTests : BaseIntegrationTest
{
    private readonly ProductTestDataHelper _productHelper;
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly StockTransactionTestDataHelper _stockTransactionHelper;

    public InventoryConsumptionIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _productHelper = new ProductTestDataHelper(Client);
        _stockBatchHelper = new StockBatchTestDataHelper(Client);
        _stockTransactionHelper = new StockTransactionTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();

        await _productHelper.GetOrCreateDependencies();
        await _stockBatchHelper.GetOrCreateDependencies();
        await _stockTransactionHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task InventoryConsumption_ProductSaleTransaction_UpdatesStockCorrectly()
    {
        // 1. Create realistic product - Coca Cola 500ml bottles
        var productDto = _productHelper.CreateProductBuilder()
            .WithName("Coca Cola 500ml")
            .WithSKU("COKE-500ML-001")
            .WithDescription("Classic Coca Cola 500ml bottle")
            .WithBarcode("1234567890123")
            .Build();
        
        var product = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, productDto, "CreateCocaCola");
        product.ShouldNotBeNull();

        // 2. Create stock batch - received 100 bottles with expiry date
        var initialQuantity = 100m;
        var stockBatchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(product!.Id)
            .WithQuantity(initialQuantity)
            .WithBatchNumber("CC-BATCH-001")
            .WithExpirationDate(DateTime.UtcNow.AddMonths(6)) // Expires in 6 months
            .WithPurchasePrice(12000) // $120 per bottle purchase price
            .WithReceivedDate(DateTime.UtcNow.AddDays(-1)) // Received yesterday
            .Build();

        var stockBatch = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, stockBatchDto, "CreateStockBatch");
        stockBatch.ShouldNotBeNull();

        // 3. Record initial receipt transaction
        var receiptDto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(stockBatch!.Id)
            .WithQuantity(initialQuantity)
            .WithType(TransactionType.In)
            .WithTransactionDate(DateTime.UtcNow.AddDays(-1))
            .WithReference("Purchase Order #PO-2024-001")
            .Build();

        var receipt = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, receiptDto, "RecordReceipt");
        receipt.ShouldNotBeNull();

        // 4. Create sale transaction - customer buys 25 bottles
        var saleQuantity = 25m;
        var saleDto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(stockBatch.Id)
            .WithQuantity(saleQuantity)
            .WithType(TransactionType.Out)
            .WithTransactionDate(DateTime.UtcNow)
            .WithReference("Sale Invoice #INV-2024-001")
            .Build();

        var sale = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, saleDto, "RecordSale");
        sale.ShouldNotBeNull();

        // 5. Verify sale transaction was recorded correctly
        sale!.ProductId.ShouldBe(product.Id);
        sale.StockBatchId.ShouldBe(stockBatch.Id);
        sale.Quantity.ShouldBe(saleQuantity);
        sale.Type.ShouldBe(TransactionType.Out);
        sale.Reference.ShouldBe("Sale Invoice #INV-2024-001");

        // 6. Query updated stock batch to verify quantity reduction
        var updatedBatchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{stockBatch.Id}");
        updatedBatchResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updatedBatch = await updatedBatchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        
        updatedBatch.ShouldNotBeNull();
        // Note: StockBatch quantity should remain unchanged as it represents received quantity
        // Actual available quantity is calculated from transactions
        updatedBatch!.Quantity.ShouldBe(initialQuantity);

        // 7. Verify complete transaction history for the product
        var transactionsResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?pageNumber=1&pageSize=50&includeRelated=true");
        transactionsResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var allTransactions = await transactionsResponse.Content.ReadFromJsonAsync<SMIS.Application.Common.PagedList<StockTransactionDto>>();
        
        var productTransactions = allTransactions!.Items
            .Where(t => t.ProductId == product.Id)
            .OrderBy(t => t.TransactionDate)
            .ToList();

        // Should have 2 transactions: 1 receipt + 1 sale
        productTransactions.Count.ShouldBe(2);

        // Verify receipt transaction
        var receiptTransaction = productTransactions[0];
        receiptTransaction.Type.ShouldBe(TransactionType.In);
        receiptTransaction.Quantity.ShouldBe(initialQuantity);
        receiptTransaction.Reference.ShouldBe("Purchase Order #PO-2024-001");

        // Verify sale transaction
        var saleTransaction = productTransactions[1];
        saleTransaction.Type.ShouldBe(TransactionType.Out);
        saleTransaction.Quantity.ShouldBe(saleQuantity);
        saleTransaction.Reference.ShouldBe("Sale Invoice #INV-2024-001");

        // 8. Calculate and verify remaining inventory
        var totalReceived = productTransactions
            .Where(t => t.Type == TransactionType.In)
            .Sum(t => t.Quantity);
        
        var totalConsumed = productTransactions
            .Where(t => t.Type == TransactionType.Out || t.Type == TransactionType.Adujstment)
            .Sum(t => t.Quantity);
        
        var remainingStock = totalReceived - totalConsumed;
        var expectedRemaining = initialQuantity - saleQuantity;

        totalReceived.ShouldBe(initialQuantity);
        totalConsumed.ShouldBe(saleQuantity);
        remainingStock.ShouldBe(expectedRemaining);
        remainingStock.ShouldBe(75m); // 100 - 25 = 75 bottles remaining

        // 9. Verify product and batch relationships are intact
        var productWithRelationsResponse = await Client.GetAsync($"{ApiEndpoints.Product}/{product.Id}?includeCategory=true");
        productWithRelationsResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var productWithRelations = await productWithRelationsResponse.Content.ReadFromJsonAsync<ProductDto>();
        
        productWithRelations.ShouldNotBeNull();
        productWithRelations!.Id.ShouldBe(product.Id);
        productWithRelations.Name.ShouldBe("Coca Cola 500ml");
        productWithRelations.SKU.ShouldBe("COKE-500ML-001");

        // 10. Verify batch expiry and purchase price are preserved
        updatedBatch.ExpirationDate.ShouldNotBeNull();
        updatedBatch.ExpirationDate!.Value.Date.ShouldBe(DateTime.UtcNow.AddMonths(6).Date);
        updatedBatch.PurchasePrice.ShouldBe(12000);
        updatedBatch.BatchNumber.ShouldBe("CC-BATCH-001");
    }
}