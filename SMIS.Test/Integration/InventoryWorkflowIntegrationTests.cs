using System.Net;
using Shouldly;
using SMIS.Application.Common;
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

/// <summary>
/// Complex integration tests demonstrating real-world inventory scenarios
/// involving Product, StockBatch, and StockTransaction relationships
/// </summary>
public class InventoryWorkflowIntegrationTests : BaseIntegrationTest
{
    private readonly ProductTestDataHelper _productHelper;
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly StockTransactionTestDataHelper _stockTransactionHelper;

    public InventoryWorkflowIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
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
    public async Task CompleteInventoryWorkflow_ProductReceiptToSale_TracksCorrectly()
    {
        // Scenario: Receive energy drinks in two batches with different expiry dates,
        // then sell using FIFO (First In, First Out) principle

        // 1. Create a new product
        var productDto = _productHelper.CreateProductBuilder()
            .WithName("Energy Drink 250ml")
            .WithSKU("ED-250ML-001")
            .Build();
        var product = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, productDto, "CreateEnergyDrink");
        product.ShouldNotBeNull();

        // 2. Receive first batch (expires March 2026)
        var batch1Dto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(product!.Id)
            .WithQuantity(100m)
            .WithBatchNumber("ED-001")
            .WithExpirationDate(new DateTime(2026, 3, 1))
            .WithPurchasePrice(20000)
            .Build();
        var batch1 = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, batch1Dto, "CreateBatch1");
        batch1.ShouldNotBeNull();

        // 3. Record receipt transaction for batch 1
        var receipt1Dto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(batch1!.Id)
            .WithQuantity(100m)
            .WithType(TransactionType.In)
            .WithReference("Purchase Order #PO-001")
            .Build();
        var receipt1 = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, receipt1Dto, "RecordReceipt1");
        receipt1.ShouldNotBeNull();

        // 4. Receive second batch (expires April 2026)
        var batch2Dto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(product.Id)
            .WithQuantity(80m)
            .WithBatchNumber("ED-002")
            .WithExpirationDate(new DateTime(2026, 4, 1))
            .WithPurchasePrice(21000)
            .Build();
        var batch2 = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, batch2Dto, "CreateBatch2");
        batch2.ShouldNotBeNull();

        // 5. Record receipt transaction for batch 2
        var receipt2Dto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(batch2!.Id)
            .WithQuantity(80m)
            .WithType(TransactionType.In)
            .WithReference("Purchase Order #PO-002")
            .Build();
        var receipt2 = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, receipt2Dto, "RecordReceipt2");
        receipt2.ShouldNotBeNull();

        // 6. First sale - consume from batch 1 (FIFO)
        var sale1Dto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(batch1.Id)
            .WithQuantity(30m)
            .WithType(TransactionType.Out)
            .WithReference("Sale #S-001")
            .Build();
        var sale1 = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, sale1Dto, "RecordSale1");
        sale1.ShouldNotBeNull();

        // 7. Damage adjustment
        var damageDto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(product.Id)
            .WithStockBatchId(batch2.Id)
            .WithQuantity(5m)
            .WithType(TransactionType.Adujstment)
            .WithReference("Damage Report #DR-001")
            .Build();
        var damage = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, damageDto, "RecordDamage");
        damage.ShouldNotBeNull();

        // 8. Verify complete transaction history
        var transactionsResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?pageNumber=1&pageSize=50&includeRelated=true");
        transactionsResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var transactions = await transactionsResponse.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
        
        var productTransactions = transactions!.Items
            .Where(t => t.ProductId == product.Id)
            .OrderBy(t => t.TransactionDate)
            .ToList();

        // Verify transaction sequence
        productTransactions.Count.ShouldBe(4); // 2 receipts + 1 sale + 1 damage
        
        productTransactions[0].Type.ShouldBe(TransactionType.In);
        productTransactions[0].Quantity.ShouldBe(100m);
        productTransactions[0].Reference.ShouldBe("Purchase Order #PO-001");
        
        productTransactions[1].Type.ShouldBe(TransactionType.In);
        productTransactions[1].Quantity.ShouldBe(80m);
        
        productTransactions[2].Type.ShouldBe(TransactionType.Out);
        productTransactions[2].Quantity.ShouldBe(30m);
        productTransactions[2].StockBatchId.ShouldBe(batch1.Id);
        
        productTransactions[3].Type.ShouldBe(TransactionType.Adujstment);
        productTransactions[3].Quantity.ShouldBe(5m);
        productTransactions[3].StockBatchId.ShouldBe(batch2.Id);

        // Calculate remaining inventory
        var totalReceived = productTransactions.Where(t => t.Type == TransactionType.In).Sum(t => t.Quantity);
        var totalConsumed = productTransactions.Where(t => t.Type == TransactionType.Out || t.Type == TransactionType.Adujstment).Sum(t => t.Quantity);
        var remainingStock = totalReceived - totalConsumed;
        
        totalReceived.ShouldBe(180m);
        totalConsumed.ShouldBe(35m);
        remainingStock.ShouldBe(145m);
    }

    [Fact]
    public async Task MultiProductInventoryTracking_DifferentExpiryPatterns_HandlesCorrectly()
    {
        // Scenario: Track perishable vs non-perishable products

        // 1. Create perishable product
        var milkDto = _productHelper.CreateProductBuilder()
            .WithName("Fresh Milk 1L")
            .WithSKU("MILK-1L-001")
            .Build();
        var milk = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, milkDto, "CreateMilk");

        // 2. Create non-perishable product
        var penDto = _productHelper.CreateProductBuilder()
            .WithName("Blue Ballpoint Pen")
            .WithSKU("PEN-BLUE-001")
            .Build();
        var pen = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, penDto, "CreatePen");

        // 3. Receive milk batch with expiry
        var milkBatchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(milk!.Id)
            .WithQuantity(50m)
            .WithBatchNumber("MILK-001")
            .WithExpirationDate(DateTime.UtcNow.AddDays(7))
            .Build();
        var milkBatch = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, milkBatchDto, "CreateMilkBatch");

        // 4. Receive pen batch without expiry
        var penBatchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(pen!.Id)
            .WithQuantity(200m)
            .WithBatchNumber("PEN-001")
            .WithExpirationDate(null)
            .Build();
        var penBatch = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, penBatchDto, "CreatePenBatch");

        // 5. Record transactions
        var milkReceiptDto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(milk.Id)
            .WithStockBatchId(milkBatch!.Id)
            .WithQuantity(50m)
            .WithType(TransactionType.In)
            .WithReference("Dairy Delivery #DD-001")
            .Build();
        await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, milkReceiptDto, "RecordMilkReceipt");

        var penReceiptDto = _stockTransactionHelper.CreateStockTransactionBuilder()
            .WithProductId(pen.Id)
            .WithStockBatchId(penBatch!.Id)
            .WithQuantity(200m)
            .WithType(TransactionType.In)
            .WithReference("Stationery Order #SO-001")
            .Build();
        await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, penReceiptDto, "RecordPenReceipt");

        // 6. Verify batch expiry handling
        var milkBatchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{milkBatch.Id}");
        milkBatchResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrievedMilkBatch = await milkBatchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        retrievedMilkBatch!.ExpirationDate.ShouldNotBeNull();

        var penBatchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{penBatch.Id}");
        penBatchResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrievedPenBatch = await penBatchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        retrievedPenBatch!.ExpirationDate.ShouldBeNull();

        // 7. Verify transaction audit trail
        var allTransactionsResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?pageNumber=1&pageSize=50");
        allTransactionsResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var allTransactions = await allTransactionsResponse.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
        
        var milkTransactions = allTransactions!.Items.Where(t => t.ProductId == milk.Id).ToList();
        var penTransactions = allTransactions.Items.Where(t => t.ProductId == pen.Id).ToList();
        
        milkTransactions.Count.ShouldBeGreaterThanOrEqualTo(1);
        penTransactions.Count.ShouldBeGreaterThanOrEqualTo(1);
        
        milkTransactions.First().Reference.ShouldBe("Dairy Delivery #DD-001");
        penTransactions.First().Reference.ShouldBe("Stationery Order #SO-001");
    }
}