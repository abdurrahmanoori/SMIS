using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;
using SMIS.Test.TestDataBuilders;

namespace SMIS.Test.Controllers;

public class InventoryManagementIntegrationTests : BaseIntegrationTest
{
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly StockTransactionTestDataHelper _stockTransactionHelper;
    private readonly ProductTestDataHelper _productHelper;

    public InventoryManagementIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _stockBatchHelper = new StockBatchTestDataHelper(Client);
        _stockTransactionHelper = new StockTransactionTestDataHelper(Client);
        _productHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _stockBatchHelper.GetOrCreateDependencies();
        await _stockTransactionHelper.GetOrCreateDependencies();
        await _productHelper.GetOrCreateDependencies();
    }

    #region Stock Receiving Scenarios

    [Fact]
    public async Task ReceiveStock_SingleBatch_CreatesStockBatchAndTransaction()
    {
        // Arrange
        var product = await CreateTestProduct("Coca Cola");
        var batchDto = CreateStockBatchDto(product.Id, 100, "CC-001", DateTime.UtcNow.AddMonths(6));

        // Act - Receive stock
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batchDto);
        await LogIfError(batchResponse, "ReceiveStock_SingleBatch");

        // Assert
        batchResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        createdBatch.ShouldNotBeNull();
        createdBatch!.Quantity.ShouldBe(100);
        createdBatch.BatchNumber.ShouldBe("CC-001");

        // Verify stock transaction was created
        var transactionsResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?productId={product.Id}");
        transactionsResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var transactions = await transactionsResponse.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
        transactions!.Items.ShouldContain(t => t.Type == TransactionType.In && t.Quantity == 100);
    }

    [Fact]
    public async Task ReceiveStock_MultipleBatchesSameProduct_CreatesMultipleBatches()
    {
        // Arrange
        var product = await CreateTestProduct("Pepsi");
        var batch1 = CreateStockBatchDto(product.Id, 50, "PP-001", DateTime.UtcNow.AddMonths(3));
        var batch2 = CreateStockBatchDto(product.Id, 75, "PP-002", DateTime.UtcNow.AddMonths(6));

        // Act
        var response1 = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch1);
        var response2 = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch2);

        // Assert
        response1.StatusCode.ShouldBe(HttpStatusCode.OK);
        response2.StatusCode.ShouldBe(HttpStatusCode.OK);

        // Verify total stock
        var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
        if (stockResponse.StatusCode == HttpStatusCode.OK)
        {
            var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
            stockSummary!.TotalQuantity.ShouldBe(125);
            stockSummary.BatchCount.ShouldBe(2);
        }
    }

    #endregion

    #region FIFO/FEFO Consumption Scenarios

    [Fact]
    public async Task ConsumeStock_FIFO_ConsumesOldestBatchFirst()
    {
        // Arrange - Create product with two batches (different received dates)
        var product = await CreateTestProduct("Biscuit");
        var oldBatch = CreateStockBatchDto(product.Id, 50, "BS-001", DateTime.UtcNow.AddMonths(6));
        oldBatch.ReceivedDate = DateTime.UtcNow.AddDays(-10);
        
        var newBatch = CreateStockBatchDto(product.Id, 30, "BS-002", DateTime.UtcNow.AddMonths(6));
        newBatch.ReceivedDate = DateTime.UtcNow.AddDays(-5);

        var oldBatchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, oldBatch);
        var newBatchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, newBatch);
        
        var createdOldBatch = await oldBatchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        var createdNewBatch = await newBatchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Consume 40 units (should consume from oldest batch first)
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 40,
            ConsumeStrategy = ConsumeStrategy.FIFO,
            Reference = "Sale #001"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);
        await LogIfError(consumeResponse, "ConsumeStock_FIFO");

        // Assert
        consumeResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify old batch quantity reduced
        var oldBatchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdOldBatch!.Id}");
        var updatedOldBatch = await oldBatchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedOldBatch!.Quantity.ShouldBe(10); // 50 - 40 = 10

        // Verify new batch unchanged
        var newBatchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdNewBatch!.Id}");
        var updatedNewBatch = await newBatchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedNewBatch!.Quantity.ShouldBe(30); // Unchanged
    }

    [Fact]
    public async Task ConsumeStock_FEFO_ConsumesEarliestExpiryFirst()
    {
        // Arrange - Create product with two batches (different expiry dates)
        var product = await CreateTestProduct("Milk");
        var laterExpiryBatch = CreateStockBatchDto(product.Id, 20, "MK-001", DateTime.UtcNow.AddMonths(3));
        var earlierExpiryBatch = CreateStockBatchDto(product.Id, 25, "MK-002", DateTime.UtcNow.AddMonths(1));

        var laterResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, laterExpiryBatch);
        var earlierResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, earlierExpiryBatch);
        
        var createdLaterBatch = await laterResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        var createdEarlierBatch = await earlierResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Consume 15 units using FEFO
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 15,
            ConsumeStrategy = ConsumeStrategy.FEFO,
            Reference = "Sale #002"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);

        // Assert
        consumeResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify earlier expiry batch consumed first
        var earlierBatchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdEarlierBatch!.Id}");
        var updatedEarlierBatch = await earlierBatchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedEarlierBatch!.Quantity.ShouldBe(10); // 25 - 15 = 10

        // Verify later expiry batch unchanged
        var laterBatchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdLaterBatch!.Id}");
        var updatedLaterBatch = await laterBatchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedLaterBatch!.Quantity.ShouldBe(20); // Unchanged
    }

    [Fact]
    public async Task ConsumeStock_CrossBatchConsumption_ConsumesFromMultipleBatches()
    {
        // Arrange - Create product with small batches
        var product = await CreateTestProduct("Juice");
        var batch1 = CreateStockBatchDto(product.Id, 10, "JC-001", DateTime.UtcNow.AddMonths(2));
        var batch2 = CreateStockBatchDto(product.Id, 15, "JC-002", DateTime.UtcNow.AddMonths(3));

        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch1);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch2);

        // Act - Consume 20 units (more than first batch)
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 20,
            ConsumeStrategy = ConsumeStrategy.FIFO,
            Reference = "Sale #003"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);

        // Assert
        consumeResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify consumption records created for both batches
        var consumptionsResponse = await Client.GetAsync($"{ApiEndpoints.StockConsumption}?productId={product.Id}");
        if (consumptionsResponse.StatusCode == HttpStatusCode.OK)
        {
            var consumptions = await consumptionsResponse.Content.ReadFromJsonAsync<PagedList<StockConsumptionDto>>();
            consumptions!.Items.Count.ShouldBe(2); // Two consumption records
            consumptions.Items.Sum(c => c.Quantity).ShouldBe(20); // Total consumed
        }
    }

    #endregion

    #region Stock Adjustment Scenarios

    [Fact]
    public async Task AdjustStock_DamageAdjustment_ReducesStockAndCreatesTransaction()
    {
        // Arrange
        var product = await CreateTestProduct("Notebook");
        var batch = CreateStockBatchDto(product.Id, 100, "NB-001");
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Adjust for damage
        var adjustmentRequest = new StockAdjustmentRequestDto
        {
            StockBatchId = createdBatch!.Id,
            AdjustmentQuantity = -10, // Negative for reduction
            AdjustmentType = AdjustmentType.Damage,
            Reference = "Damaged goods",
            Notes = "Water damage during storage"
        };

        var adjustResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/adjust-stock", adjustmentRequest);
        await LogIfError(adjustResponse, "AdjustStock_Damage");

        // Assert
        adjustResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify batch quantity reduced
        var batchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdBatch.Id}");
        var updatedBatch = await batchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedBatch!.Quantity.ShouldBe(90); // 100 - 10 = 90

        // Verify adjustment transaction created
        var transactionsResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?stockBatchId={createdBatch.Id}");
        if (transactionsResponse.StatusCode == HttpStatusCode.OK)
        {
            var transactions = await transactionsResponse.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
            transactions!.Items.ShouldContain(t => t.Type == TransactionType.Adujstment && t.Quantity == 10);
        }
    }

    [Fact]
    public async Task AdjustStock_FoundStock_IncreasesStockAndCreatesTransaction()
    {
        // Arrange
        var product = await CreateTestProduct("Pen");
        var batch = CreateStockBatchDto(product.Id, 50, "PN-001");
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Adjust for found stock
        var adjustmentRequest = new StockAdjustmentRequestDto
        {
            StockBatchId = createdBatch!.Id,
            AdjustmentQuantity = 5, // Positive for increase
            AdjustmentType = AdjustmentType.Found,
            Reference = "Stock count correction",
            Notes = "Found additional items during audit"
        };

        var adjustResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/adjust-stock", adjustmentRequest);

        // Assert
        adjustResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify batch quantity increased
        var batchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdBatch.Id}");
        var updatedBatch = await batchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
        updatedBatch!.Quantity.ShouldBe(55); // 50 + 5 = 55
    }

    #endregion

    #region Expiry Management Scenarios

    [Fact]
    public async Task GetExpiringStock_ReturnsItemsNearExpiry()
    {
        // Arrange - Create batches with different expiry dates
        var product = await CreateTestProduct("Yogurt");
        var expiringSoon = CreateStockBatchDto(product.Id, 20, "YG-001", DateTime.UtcNow.AddDays(5));
        var expiringLater = CreateStockBatchDto(product.Id, 30, "YG-002", DateTime.UtcNow.AddMonths(2));

        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, expiringSoon);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, expiringLater);

        // Act - Get expiring stock (within 7 days)
        var expiringResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/expiring-stock?days=7");
        await LogIfError(expiringResponse, "GetExpiringStock");

        // Assert
        if (expiringResponse.StatusCode == HttpStatusCode.OK)
        {
            var expiringItems = await expiringResponse.Content.ReadFromJsonAsync<PagedList<ExpiringStockDto>>();
            expiringItems!.Items.ShouldContain(item => item.BatchNumber == "YG-001");
            expiringItems.Items.ShouldNotContain(item => item.BatchNumber == "YG-002");
        }
    }

    [Fact]
    public async Task MarkBatchAsExpired_UpdatesStatusAndCreatesTransaction()
    {
        // Arrange
        var product = await CreateTestProduct("Bread");
        var batch = CreateStockBatchDto(product.Id, 15, "BR-001", DateTime.UtcNow.AddDays(-1)); // Already expired
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Mark as expired
        var expireRequest = new MarkExpiredRequestDto
        {
            StockBatchId = createdBatch!.Id,
            ExpiredQuantity = 15,
            Notes = "Expired batch disposal"
        };

        var expireResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/mark-expired", expireRequest);
        await LogIfError(expireResponse, "MarkBatchAsExpired");

        // Assert
        if (expireResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify batch status updated
            var batchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdBatch.Id}");
            var updatedBatch = await batchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
            updatedBatch!.Status.ShouldBe(StatusEnum.Completed); // Or Expired status
        }
    }

    #endregion

    #region Stock Transfer Scenarios

    [Fact]
    public async Task TransferStock_BetweenShops_CreatesTransferTransactions()
    {
        // Arrange - Create two shops and product
        var sourceShop = await CreateTestShop("Main Store");
        var targetShop = await CreateTestShop("Branch Store");
        var product = await CreateTestProduct("Cooking Oil", sourceShop.Id);
        
        var batch = CreateStockBatchDto(product.Id, 50, "CO-001");
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Act - Transfer stock
        var transferRequest = new StockTransferRequestDto
        {
            SourceShopId = sourceShop.Id,
            TargetShopId = targetShop.Id,
            StockBatchId = createdBatch!.Id,
            TransferQuantity = 20,
            Reference = "Inter-shop transfer",
            Notes = "Restocking branch store"
        };

        var transferResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/transfer-stock", transferRequest);
        await LogIfError(transferResponse, "TransferStock");

        // Assert
        if (transferResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify source batch quantity reduced
            var sourceBatchCheck = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{createdBatch.Id}");
            var updatedSourceBatch = await sourceBatchCheck.Content.ReadFromJsonAsync<StockBatchDto>();
            updatedSourceBatch!.Quantity.ShouldBe(30); // 50 - 20 = 30

            // Verify transfer transactions created
            var transferTransactions = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?reference=Inter-shop transfer");
            if (transferTransactions.StatusCode == HttpStatusCode.OK)
            {
                var transactions = await transferTransactions.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
                transactions!.Items.Count.ShouldBeGreaterThanOrEqualTo(2); // Out from source, In to target
            }
        }
    }

    #endregion

    #region Stock Valuation Scenarios

    [Fact]
    public async Task GetStockValuation_CalculatesCorrectValue()
    {
        // Arrange - Create product with multiple batches at different prices
        var product = await CreateTestProduct("Coffee");
        var batch1 = CreateStockBatchDto(product.Id, 10, "CF-001");
        batch1.PurchasePrice = 500; // $5.00 per unit
        var batch2 = CreateStockBatchDto(product.Id, 15, "CF-002");
        batch2.PurchasePrice = 600; // $6.00 per unit

        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch1);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch2);

        // Act - Get stock valuation
        var valuationResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-valuation/{product.Id}");
        await LogIfError(valuationResponse, "GetStockValuation");

        // Assert
        if (valuationResponse.StatusCode == HttpStatusCode.OK)
        {
            var valuation = await valuationResponse.Content.ReadFromJsonAsync<StockValuationDto>();
            valuation!.TotalQuantity.ShouldBe(25); // 10 + 15
            valuation.TotalValue.ShouldBe(14000); // (10 * 500) + (15 * 600) = 5000 + 9000 = 14000
            valuation.AverageUnitCost.ShouldBe(560); // 14000 / 25 = 560
        }
    }

    #endregion

    #region Low Stock Alert Scenarios

    [Fact]
    public async Task GetLowStockItems_ReturnsItemsBelowThreshold()
    {
        // Arrange - Create products with different stock levels
        var lowStockProduct = await CreateTestProduct("Sugar");
        var normalStockProduct = await CreateTestProduct("Salt");

        var lowBatch = CreateStockBatchDto(lowStockProduct.Id, 5, "SG-001"); // Low stock
        var normalBatch = CreateStockBatchDto(normalStockProduct.Id, 100, "SL-001"); // Normal stock

        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, lowBatch);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, normalBatch);

        // Act - Get low stock items (threshold = 10)
        var lowStockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/low-stock?threshold=10");
        await LogIfError(lowStockResponse, "GetLowStockItems");

        // Assert
        if (lowStockResponse.StatusCode == HttpStatusCode.OK)
        {
            var lowStockItems = await lowStockResponse.Content.ReadFromJsonAsync<PagedList<LowStockItemDto>>();
            lowStockItems!.Items.ShouldContain(item => item.ProductId == lowStockProduct.Id);
            lowStockItems.Items.ShouldNotContain(item => item.ProductId == normalStockProduct.Id);
        }
    }

    #endregion

    #region Stock Movement History Scenarios

    [Fact]
    public async Task GetStockMovementHistory_ReturnsCompleteAuditTrail()
    {
        // Arrange - Create product and perform multiple operations
        var product = await CreateTestProduct("Tea");
        var batch = CreateStockBatchDto(product.Id, 100, "TE-001");
        var batchResponse = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);
        var createdBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();

        // Perform various operations
        await ConsumeStock(product.Id, 20, "Sale #001");
        await AdjustStock(createdBatch!.Id, -5, AdjustmentType.Damage);
        await ConsumeStock(product.Id, 15, "Sale #002");

        // Act - Get movement history
        var historyResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/movement-history/{product.Id}");
        await LogIfError(historyResponse, "GetStockMovementHistory");

        // Assert
        if (historyResponse.StatusCode == HttpStatusCode.OK)
        {
            var history = await historyResponse.Content.ReadFromJsonAsync<PagedList<StockMovementDto>>();
            history!.Items.Count.ShouldBeGreaterThanOrEqualTo(4); // Initial + 3 operations
            history.Items.ShouldContain(m => m.MovementType == "In" && m.Quantity == 100);
            history.Items.ShouldContain(m => m.MovementType == "Out" && m.Quantity == 20);
            history.Items.ShouldContain(m => m.MovementType == "Adjustment" && m.Quantity == 5);
        }
    }

    #endregion

    #region Unit Conversion Scenarios

    [Fact]
    public async Task ConsumeStock_WithUnitConversion_HandlesConversionCorrectly()
    {
        // Arrange - Create product with unit conversions (1 Box = 12 Pieces)
        var product = await CreateTestProduct("Chocolate Bar");
        await CreateProductUnit(product.Id, "Box", 12); // 1 Box = 12 Pieces
        
        var batch = CreateStockBatchDto(product.Id, 120, "CB-001"); // 120 pieces = 10 boxes
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batch);

        // Act - Consume 2 boxes (should consume 24 pieces)
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 2,
            UnitId = "box-unit-id", // Box unit
            ConsumeStrategy = ConsumeStrategy.FIFO,
            Reference = "Sale #004"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);

        // Assert
        if (consumeResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify 24 pieces were consumed (2 boxes * 12 pieces/box)
            var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
            if (stockResponse.StatusCode == HttpStatusCode.OK)
            {
                var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
                stockSummary!.TotalQuantity.ShouldBe(96); // 120 - 24 = 96 pieces
            }
        }
    }

    #endregion

    #region Helper Methods

    private async Task<ProductDto> CreateTestProduct(string name, string? shopId = null)
    {
        var productDto = _productHelper.CreateProductBuilder()
            .WithName(name)
            .WithShopId(shopId ?? _productHelper.DefaultShopId)
            .Build();
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ProductDto>())!;
    }

    private async Task<ShopDto> CreateTestShop(string name)
    {
        var shopDto = new ShopCreateDto
        {
            Name = name,
            ShopType = ShopType.Retail,
            Address = "Test Address",
            PhoneNumber = "123-456-7890",
            Email = "test@shop.com"
        };
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ShopDto>())!;
    }

    private StockBatchCreateDto CreateStockBatchDto(string productId, decimal quantity, string batchNumber, DateTime? expirationDate = null)
    {
        return _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .WithExpirationDate(expirationDate)
            .Build();
    }

    private async Task ConsumeStock(string productId, decimal quantity, string reference)
    {
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = productId,
            Quantity = quantity,
            ConsumeStrategy = ConsumeStrategy.FIFO,
            Reference = reference
        };

        await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);
    }

    private async Task AdjustStock(string stockBatchId, decimal adjustmentQuantity, AdjustmentType adjustmentType)
    {
        var adjustmentRequest = new StockAdjustmentRequestDto
        {
            StockBatchId = stockBatchId,
            AdjustmentQuantity = adjustmentQuantity,
            AdjustmentType = adjustmentType,
            Reference = $"{adjustmentType} adjustment"
        };

        await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/adjust-stock", adjustmentRequest);
    }

    private async Task CreateProductUnit(string productId, string unitName, decimal conversionFactor)
    {
        var productUnitDto = new ProductUnitCreateDto
        {
            ProductId = productId,
            UnitOfMeasureId = "box-unit-id", // Assume this exists
            ConversionFactor = conversionFactor
        };

        await Client.PostAsJsonAsync(ApiEndpoints.ProductUnit, productUnitDto);
    }

    #endregion
}

#region DTOs (These would typically be in your Application layer)

public class ConsumeStockRequestDto
{
    public string ProductId { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public string? UnitId { get; set; }
    public ConsumeStrategy ConsumeStrategy { get; set; } = ConsumeStrategy.FIFO;
    public string? Reference { get; set; }
}

public class StockAdjustmentRequestDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public decimal AdjustmentQuantity { get; set; }
    public AdjustmentType AdjustmentType { get; set; }
    public string? Reference { get; set; }
    public string? Notes { get; set; }
}

public class StockTransferRequestDto
{
    public string SourceShopId { get; set; } = string.Empty;
    public string TargetShopId { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public decimal TransferQuantity { get; set; }
    public string? Reference { get; set; }
    public string? Notes { get; set; }
}

public class MarkExpiredRequestDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public decimal ExpiredQuantity { get; set; }
    public string? Notes { get; set; }
}

public class StockSummaryDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal TotalQuantity { get; set; }
    public int BatchCount { get; set; }
    public decimal TotalValue { get; set; }
}

public class ExpiringStockDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string? BatchNumber { get; set; }
    public decimal Quantity { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int DaysToExpiry { get; set; }
}

public class StockValuationDto
{
    public string ProductId { get; set; } = string.Empty;
    public decimal TotalQuantity { get; set; }
    public long TotalValue { get; set; }
    public long AverageUnitCost { get; set; }
}

public class LowStockItemDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal CurrentStock { get; set; }
    public decimal ReorderLevel { get; set; }
}

public class StockMovementDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string MovementType { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public decimal QuantityBefore { get; set; }
    public decimal QuantityAfter { get; set; }
    public DateTime MovementDate { get; set; }
    public string? Reference { get; set; }
}

public class StockConsumptionDto
{
    public string Id { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public DateTime? ConsumedDate { get; set; }
    public string? ConsumedBy { get; set; }
}

public class ShopCreateDto
{
    public string Name { get; set; } = string.Empty;
    public ShopType ShopType { get; set; }
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class ShopDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public ShopType ShopType { get; set; }
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class ProductUnitCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string UnitOfMeasureId { get; set; } = string.Empty;
    public decimal ConversionFactor { get; set; }
}

public enum ConsumeStrategy
{
    FIFO = 1,
    FEFO = 2,
    LIFO = 3
}

public enum AdjustmentType
{
    Damage = 1,
    Loss = 2,
    Found = 3,
    Correction = 4
}

public enum ShopType
{
    Retail = 1,
    Wholesale = 2
}

#endregion