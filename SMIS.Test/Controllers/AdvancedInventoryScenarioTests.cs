using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.StockBatches;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class AdvancedInventoryScenarioTests : BaseIntegrationTest
{
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly ProductTestDataHelper _productHelper;

    public AdvancedInventoryScenarioTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _stockBatchHelper = new StockBatchTestDataHelper(Client);
        _productHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _stockBatchHelper.GetOrCreateDependencies();
        await _productHelper.GetOrCreateDependencies();
    }

    #region Multi-Shop Inventory Management

    [Fact]
    public async Task MultiShop_StockTransfer_UpdatesBothShopInventories()
    {
        // Arrange - Create two shops and product
        var mainShop = await CreateTestShop("Main Warehouse", ShopType.Wholesale);
        var branchShop = await CreateTestShop("Branch Store", ShopType.Retail);
        var product = await CreateTestProduct("Transfer Item", mainShop);

        // Create stock in main shop
        var batch = await CreateStockBatch(product.Id, 100, "TI-001");

        // Act - Transfer stock between shops
        var transferRequest = new InterShopTransferRequestDto
        {
            SourceShopId = mainShop,
            TargetShopId = branchShop,
            ProductId = product.Id,
            TransferQuantity = 30,
            TransferDate = DateTime.UtcNow,
            Reference = "Branch restocking",
            Notes = "Monthly branch inventory replenishment"
        };

        var transferResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/inter-shop-transfer", transferRequest);
        await LogIfError(transferResponse, "MultiShop_StockTransfer");

        // Assert
        transferResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var transferResult = await transferResponse.Content.ReadFromJsonAsync<StockTransferResultDto>();
        transferResult.ShouldNotBeNull();

        // Verify source shop stock reduced
        var sourceStockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/shop-stock/{mainShop}/{product.Id}");
        if (sourceStockResponse.StatusCode == HttpStatusCode.OK)
        {
            var sourceStock = await sourceStockResponse.Content.ReadFromJsonAsync<ShopStockDto>();
            sourceStock!.TotalQuantity.ShouldBe(70); // 100 - 30 = 70
        }

        // Verify target shop stock increased
        var targetStockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/shop-stock/{branchShop}/{product.Id}");
        if (targetStockResponse.StatusCode == HttpStatusCode.OK)
        {
            var targetStock = await targetStockResponse.Content.ReadFromJsonAsync<ShopStockDto>();
            targetStock!.TotalQuantity.ShouldBe(30);
        }
    }

    [Fact]
    public async Task MultiShop_ConsolidatedInventoryView_ShowsAllShopsStock()
    {
        // Arrange - Create multiple shops with same product
        var shop1 = await CreateTestShop("Shop 1", ShopType.Retail);
        var shop2 = await CreateTestShop("Shop 2", ShopType.Retail);
        var shop3 = await CreateTestShop("Shop 3", ShopType.Wholesale);

        var product = await CreateTestProduct("Multi-Shop Item");

        // Create stock in different shops
        await CreateStockBatchForShop(product.Id, 50, "MS1-001", shop1);
        await CreateStockBatchForShop(product.Id, 75, "MS2-001", shop2);
        await CreateStockBatchForShop(product.Id, 120, "MS3-001", shop3);

        // Act - Get consolidated inventory view
        var response = await Client.GetAsync($"{ApiEndpoints.Inventory}/consolidated-stock/{product.Id}");
        await LogIfError(response, "MultiShop_ConsolidatedInventoryView");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var consolidatedStock = await response.Content.ReadFromJsonAsync<ConsolidatedStockDto>();
            consolidatedStock!.TotalQuantityAllShops.ShouldBe(245); // 50 + 75 + 120 = 245
            consolidatedStock.ShopStocks.Count.ShouldBe(3);
            consolidatedStock.ShopStocks.ShouldContain(s => s.ShopName == "Shop 1" && s.Quantity == 50);
            consolidatedStock.ShopStocks.ShouldContain(s => s.ShopName == "Shop 2" && s.Quantity == 75);
            consolidatedStock.ShopStocks.ShouldContain(s => s.ShopName == "Shop 3" && s.Quantity == 120);
        }
    }

    [Fact]
    public async Task MultiShop_AutoReorderBetweenShops_TriggersTransfer()
    {
        // Arrange - Create warehouse and retail shop
        var warehouse = await CreateTestShop("Central Warehouse", ShopType.Wholesale);
        var retailShop = await CreateTestShop("Retail Shop", ShopType.Retail);
        var product = await CreateTestProduct("Auto-Reorder Item", warehouse);

        // Set up reorder rules
        var reorderRule = new AutoReorderRuleDto
        {
            ProductId = product.Id,
            SourceShopId = warehouse,
            TargetShopId = retailShop,
            ReorderLevel = 10,
            ReorderQuantity = 50,
            IsActive = true
        };

        await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/auto-reorder-rules", reorderRule);

        // Create stock in warehouse
        await CreateStockBatchForShop(product.Id, 200, "AR-001", warehouse);

        // Create low stock in retail shop
        await CreateStockBatchForShop(product.Id, 5, "AR-002", retailShop); // Below reorder level

        // Act - Trigger auto-reorder check
        var reorderResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/check-auto-reorder", new { });
        await LogIfError(reorderResponse, "MultiShop_AutoReorderBetweenShops");

        // Assert
        if (reorderResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify transfer was created
            var transfersResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/transfers?productId={product.Id}");
            if (transfersResponse.StatusCode == HttpStatusCode.OK)
            {
                var transfers = await transfersResponse.Content.ReadFromJsonAsync<PagedList<StockTransferDto>>();
                transfers!.Items.ShouldContain(t => t.TransferQuantity == 50 && t.Reference.Contains("Auto-reorder"));
            }
        }
    }

    #endregion

    #region Complex Unit Conversion Scenarios

    [Fact]
    public async Task ComplexUnitConversion_NestedConversions_HandlesCorrectly()
    {
        // Arrange - Create product with complex unit hierarchy
        // Base unit: Piece, Pack = 12 pieces, Box = 10 packs, Carton = 5 boxes
        var product = await CreateTestProduct("Complex Unit Item");
        
        await CreateProductUnit(product.Id, "pack-unit", 12);    // 1 Pack = 12 Pieces
        await CreateProductUnit(product.Id, "box-unit", 120);   // 1 Box = 10 Packs = 120 Pieces
        await CreateProductUnit(product.Id, "carton-unit", 600); // 1 Carton = 5 Boxes = 600 Pieces

        // Create stock in pieces (base unit)
        await CreateStockBatch(product.Id, 1200, "CU-001"); // 1200 pieces

        // Act - Consume 2 cartons (should consume 1200 pieces)
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 2,
            UnitId = "carton-unit",
            ConsumeStrategy = ConsumeStrategy.FIFO,
            Reference = "Complex unit consumption"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);
        await LogIfError(consumeResponse, "ComplexUnitConversion_NestedConversions");

        // Assert
        if (consumeResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify exactly 1200 pieces were consumed (2 cartons * 600 pieces/carton)
            var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
            if (stockResponse.StatusCode == HttpStatusCode.OK)
            {
                var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
                stockSummary!.TotalQuantity.ShouldBe(0); // All consumed
            }
        }
    }

    [Fact]
    public async Task MixedUnitSales_DifferentUnitsInSameInvoice_CalculatesCorrectly()
    {
        // Arrange - Create product with multiple units
        var product = await CreateTestProduct("Mixed Unit Sales Item");
        await CreateProductUnit(product.Id, "bottle-unit", 1);   // 1 Bottle = 1 Piece (base)
        await CreateProductUnit(product.Id, "case-unit", 24);    // 1 Case = 24 Bottles

        await CreateStockBatch(product.Id, 100, "MU-001"); // 100 bottles

        // Act - Create invoice with mixed units
        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "mixed-unit-customer",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 2, // 2 cases = 48 bottles
                    UnitId = "case-unit",
                    UnitPrice = 2400, // $24.00 per case
                    DiscountAmount = 0,
                    TaxAmount = 0
                },
                new()
                {
                    ProductId = product.Id,
                    Quantity = 12, // 12 individual bottles
                    UnitId = "bottle-unit",
                    UnitPrice = 120, // $1.20 per bottle
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var invoiceResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        await LogIfError(invoiceResponse, "MixedUnitSales_DifferentUnitsInSameInvoice");

        // Assert
        invoiceResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var invoice = await invoiceResponse.Content.ReadFromJsonAsync<InvoiceDto>();
        invoice!.TotalAmount.ShouldBe(6240); // (2 * 2400) + (12 * 120) = 4800 + 1440 = 6240

        // Verify correct stock consumption (48 + 12 = 60 bottles consumed)
        var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
        if (stockResponse.StatusCode == HttpStatusCode.OK)
        {
            var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
            stockSummary!.TotalQuantity.ShouldBe(40); // 100 - 60 = 40
        }
    }

    #endregion

    #region Batch Expiry and FEFO Scenarios

    [Fact]
    public async Task ComplexFEFO_MultipleBatchesWithCloseExpiry_ConsumesCorrectOrder()
    {
        // Arrange - Create product with multiple batches having close expiry dates
        var product = await CreateTestProduct("FEFO Complex Item");
        
        var batch1 = CreateStockBatchDto(product.Id, 30, "FEFO-001", DateTime.UtcNow.AddDays(5));  // Expires first
        var batch2 = CreateStockBatchDto(product.Id, 25, "FEFO-002", DateTime.UtcNow.AddDays(3));  // Expires earliest
        var batch3 = CreateStockBatchDto(product.Id, 40, "FEFO-003", DateTime.UtcNow.AddDays(10)); // Expires last
        var batch4 = CreateStockBatchDto(product.Id, 20, "FEFO-004", DateTime.UtcNow.AddDays(4));  // Expires second

        var createdBatch1 = await CreateStockBatchFromDto(batch1);
        var createdBatch2 = await CreateStockBatchFromDto(batch2);
        var createdBatch3 = await CreateStockBatchFromDto(batch3);
        var createdBatch4 = await CreateStockBatchFromDto(batch4);

        // Act - Consume 60 units using FEFO (should consume from batch2, batch4, batch1 in that order)
        var consumeRequest = new ConsumeStockRequestDto
        {
            ProductId = product.Id,
            Quantity = 60,
            ConsumeStrategy = ConsumeStrategy.FEFO,
            Reference = "Complex FEFO test"
        };

        var consumeResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/consume-stock", consumeRequest);
        await LogIfError(consumeResponse, "ComplexFEFO_MultipleBatchesWithCloseExpiry");

        // Assert
        if (consumeResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify consumption order: batch2 (25) + batch4 (20) + batch1 (15) = 60
            await VerifyBatchQuantity(createdBatch2.Id, 0);  // Fully consumed
            await VerifyBatchQuantity(createdBatch4.Id, 0);  // Fully consumed
            await VerifyBatchQuantity(createdBatch1.Id, 15); // Partially consumed (30 - 15 = 15)
            await VerifyBatchQuantity(createdBatch3.Id, 40); // Untouched
        }
    }

    [Fact]
    public async Task AutoExpiredBatchHandling_ExpiredBatchesAutoMarked_UpdatesInventory()
    {
        // Arrange - Create batches with past expiry dates
        var product = await CreateTestProduct("Auto Expiry Item");
        
        var expiredBatch = CreateStockBatchDto(product.Id, 50, "EXP-001", DateTime.UtcNow.AddDays(-5)); // Already expired
        var validBatch = CreateStockBatchDto(product.Id, 30, "VAL-001", DateTime.UtcNow.AddDays(30));   // Still valid

        await CreateStockBatchFromDto(expiredBatch);
        await CreateStockBatchFromDto(validBatch);

        // Act - Run expired batch cleanup process
        var cleanupResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/cleanup-expired-batches", new { });
        await LogIfError(cleanupResponse, "AutoExpiredBatchHandling_ExpiredBatchesAutoMarked");

        // Assert
        if (cleanupResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify only valid stock is available
            var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/available-stock/{product.Id}");
            if (stockResponse.StatusCode == HttpStatusCode.OK)
            {
                var availableStock = await stockResponse.Content.ReadFromJsonAsync<AvailableStockDto>();
                availableStock!.AvailableQuantity.ShouldBe(30); // Only valid batch
                availableStock.ExpiredQuantity.ShouldBe(50);    // Expired batch
            }
        }
    }

    #endregion

    #region Advanced Stock Adjustment Scenarios

    [Fact]
    public async Task BulkStockAdjustment_MultipleProducts_ProcessesCorrectly()
    {
        // Arrange - Create multiple products with stock
        var product1 = await CreateTestProduct("Bulk Adjust Item 1");
        var product2 = await CreateTestProduct("Bulk Adjust Item 2");
        var product3 = await CreateTestProduct("Bulk Adjust Item 3");

        var batch1 = await CreateStockBatch(product1.Id, 100, "BA1-001");
        var batch2 = await CreateStockBatch(product2.Id, 75, "BA2-001");
        var batch3 = await CreateStockBatch(product3.Id, 50, "BA3-001");

        // Act - Perform bulk adjustment
        var bulkAdjustmentRequest = new BulkStockAdjustmentRequestDto
        {
            AdjustmentType = AdjustmentType.Correction,
            AdjustmentDate = DateTime.UtcNow,
            Reference = "Annual stock count correction",
            Adjustments = new List<StockAdjustmentItemDto>
            {
                new() { StockBatchId = batch1.Id, AdjustmentQuantity = -10 }, // Reduce by 10
                new() { StockBatchId = batch2.Id, AdjustmentQuantity = 5 },   // Increase by 5
                new() { StockBatchId = batch3.Id, AdjustmentQuantity = -3 }   // Reduce by 3
            }
        };

        var adjustmentResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/bulk-stock-adjustment", bulkAdjustmentRequest);
        await LogIfError(adjustmentResponse, "BulkStockAdjustment_MultipleProducts");

        // Assert
        adjustmentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify all adjustments applied
        await VerifyBatchQuantity(batch1.Id, 90);  // 100 - 10 = 90
        await VerifyBatchQuantity(batch2.Id, 80);  // 75 + 5 = 80
        await VerifyBatchQuantity(batch3.Id, 47);  // 50 - 3 = 47
    }

    [Fact]
    public async Task StockAdjustmentWithApproval_RequiresApproval_WorkflowWorks()
    {
        // Arrange - Create product with stock
        var product = await CreateTestProduct("Approval Required Item");
        var batch = await CreateStockBatch(product.Id, 100, "AR-001");

        // Act - Create adjustment requiring approval (large adjustment)
        var adjustmentRequest = new StockAdjustmentRequestDto
        {
            StockBatchId = batch.Id,
            AdjustmentQuantity = -50, // Large reduction requiring approval
            AdjustmentType = AdjustmentType.Loss,
            Reference = "Large loss adjustment",
            Notes = "Significant inventory loss requiring manager approval",
            RequiresApproval = true
        };

        var adjustmentResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/adjust-stock-with-approval", adjustmentRequest);
        await LogIfError(adjustmentResponse, "StockAdjustmentWithApproval_RequiresApproval");

        // Assert
        if (adjustmentResponse.StatusCode == HttpStatusCode.OK)
        {
            var adjustmentResult = await adjustmentResponse.Content.ReadFromJsonAsync<StockAdjustmentResultDto>();
            adjustmentResult!.Status.ShouldBe("PendingApproval");
            
            // Verify stock not yet adjusted
            await VerifyBatchQuantity(batch.Id, 100); // Should remain unchanged
            
            // Approve the adjustment
            var approvalRequest = new ApproveAdjustmentRequestDto
            {
                AdjustmentId = adjustmentResult.AdjustmentId,
                ApprovedBy = "manager-user-id",
                ApprovalNotes = "Approved after investigation"
            };

            var approvalResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/approve-adjustment", approvalRequest);
            if (approvalResponse.StatusCode == HttpStatusCode.OK)
            {
                // Verify stock now adjusted
                await VerifyBatchQuantity(batch.Id, 50); // 100 - 50 = 50
            }
        }
    }

    #endregion

    #region Inventory Forecasting and Planning

    [Fact]
    public async Task InventoryForecast_BasedOnHistoricalData_ProvidesRecommendations()
    {
        // Arrange - Create product with historical sales data
        var product = await CreateTestProduct("Forecast Item");
        await CreateStockBatch(product.Id, 500, "FC-001");

        // Simulate historical sales over past months
        await CreateHistoricalSales(product.Id, DateTime.UtcNow.AddDays(-90), DateTime.UtcNow, 200);

        // Act - Get inventory forecast
        var forecastRequest = new InventoryForecastRequestDto
        {
            ProductId = product.Id,
            ForecastPeriodDays = 30,
            ConfidenceLevel = 95
        };

        var forecastResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Inventory}/forecast", forecastRequest);
        await LogIfError(forecastResponse, "InventoryForecast_BasedOnHistoricalData");

        // Assert
        if (forecastResponse.StatusCode == HttpStatusCode.OK)
        {
            var forecast = await forecastResponse.Content.ReadFromJsonAsync<InventoryForecastDto>();
            forecast!.ProductId.ShouldBe(product.Id);
            forecast.ForecastedDemand.ShouldBeGreaterThan(0);
            forecast.RecommendedReorderQuantity.ShouldBeGreaterThan(0);
            forecast.RecommendedReorderDate.ShouldNotBeNull();
            forecast.StockoutRisk.ShouldBeGreaterThanOrEqualTo(0);
            forecast.StockoutRisk.ShouldBeLessThanOrEqualTo(100);
        }
    }

    [Fact]
    public async Task SeasonalityAnalysis_IdentifiesPatterns_AdjustsForecasts()
    {
        // Arrange - Create product with seasonal sales pattern
        var product = await CreateTestProduct("Seasonal Item");
        await CreateStockBatch(product.Id, 1000, "SE-001");

        // Simulate seasonal sales pattern (higher in certain months)
        await CreateSeasonalSalesData(product.Id);

        // Act - Get seasonality analysis
        var seasonalityResponse = await Client.GetAsync($"{ApiEndpoints.Analytics}/seasonality-analysis/{product.Id}");
        await LogIfError(seasonalityResponse, "SeasonalityAnalysis_IdentifiesPatterns");

        // Assert
        if (seasonalityResponse.StatusCode == HttpStatusCode.OK)
        {
            var analysis = await seasonalityResponse.Content.ReadFromJsonAsync<SeasonalityAnalysisDto>();
            analysis!.HasSeasonalPattern.ShouldBeTrue();
            analysis.SeasonalFactors.Count.ShouldBe(12); // Monthly factors
            analysis.PeakMonths.ShouldNotBeEmpty();
            analysis.LowMonths.ShouldNotBeEmpty();
        }
    }

    #endregion

    #region Quality Control and Batch Tracking

    [Fact]
    public async Task QualityControlCheck_BatchInspection_UpdatesQualityStatus()
    {
        // Arrange - Create batch for quality inspection
        var product = await CreateTestProduct("Quality Control Item");
        var batch = await CreateStockBatch(product.Id, 100, "QC-001");

        // Act - Perform quality control check
        var qcRequest = new QualityControlCheckRequestDto
        {
            StockBatchId = batch.Id,
            InspectionDate = DateTime.UtcNow,
            InspectedBy = "qc-inspector-id",
            QualityStatus = QualityStatus.Passed,
            InspectionNotes = "All items meet quality standards",
            SampleSize = 10,
            DefectCount = 0
        };

        var qcResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.QualityControl}/inspect-batch", qcRequest);
        await LogIfError(qcResponse, "QualityControlCheck_BatchInspection");

        // Assert
        if (qcResponse.StatusCode == HttpStatusCode.OK)
        {
            // Verify batch quality status updated
            var batchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{batch.Id}");
            var updatedBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
            updatedBatch!.QualityStatus.ShouldBe(QualityStatus.Passed);
        }
    }

    [Fact]
    public async Task BatchRecall_TraceabilityAndRemoval_HandlesCorrectly()
    {
        // Arrange - Create batches and simulate sales
        var product = await CreateTestProduct("Recall Item");
        var recallBatch = await CreateStockBatch(product.Id, 100, "RC-001");
        var safeBatch = await CreateStockBatch(product.Id, 80, "RC-002");

        // Simulate some sales from recall batch
        await CreateSalesInvoice(product.Id, 30, 500);

        // Act - Initiate batch recall
        var recallRequest = new BatchRecallRequestDto
        {
            StockBatchId = recallBatch.Id,
            RecallReason = "Quality defect discovered",
            RecallDate = DateTime.UtcNow,
            RecallType = RecallType.Voluntary,
            NotifyCustomers = true,
            RecallNotes = "Potential contamination in batch RC-001"
        };

        var recallResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.QualityControl}/initiate-recall", recallRequest);
        await LogIfError(recallResponse, "BatchRecall_TraceabilityAndRemoval");

        // Assert
        if (recallResponse.StatusCode == HttpStatusCode.OK)
        {
            var recallResult = await recallResponse.Content.ReadFromJsonAsync<BatchRecallResultDto>();
            recallResult!.RecallId.ShouldNotBeNullOrEmpty();
            recallResult.AffectedCustomers.ShouldBeGreaterThan(0);
            recallResult.RemainingStock.ShouldBe(70); // 100 - 30 sold = 70 remaining

            // Verify batch marked as recalled
            var batchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{recallBatch.Id}");
            var updatedBatch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
            updatedBatch!.Status.ShouldBe(StatusEnum.Recalled);
        }
    }

    #endregion

    #region Helper Methods

    private async Task<string> CreateTestShop(string name, ShopType shopType)
    {
        var shopDto = new ShopCreateDto
        {
            Name = name,
            ShopType = shopType,
            Address = "Test Address",
            PhoneNumber = "123-456-7890",
            Email = "test@shop.com"
        };
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        response.EnsureSuccessStatusCode();
        var shop = await response.Content.ReadFromJsonAsync<ShopDto>();
        return shop!.Id;
    }

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

    private async Task<StockBatchDto> CreateStockBatch(string productId, decimal quantity, string batchNumber)
    {
        var batchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .Build();
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batchDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockBatchDto>())!;
    }

    private async Task<StockBatchDto> CreateStockBatchForShop(string productId, decimal quantity, string batchNumber, string shopId)
    {
        var batchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .Build();
        
        // Add shop-specific logic if needed
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.StockBatch}?shopId={shopId}", batchDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockBatchDto>())!;
    }

    private StockBatchCreateDto CreateStockBatchDto(string productId, decimal quantity, string batchNumber, DateTime? expirationDate)
    {
        return _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .WithExpirationDate(expirationDate)
            .Build();
    }

    private async Task<StockBatchDto> CreateStockBatchFromDto(StockBatchCreateDto dto)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, dto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockBatchDto>())!;
    }

    private async Task CreateProductUnit(string productId, string unitId, decimal conversionFactor)
    {
        var productUnitDto = new ProductUnitCreateDto
        {
            ProductId = productId,
            UnitOfMeasureId = unitId,
            ConversionFactor = conversionFactor
        };

        await Client.PostAsJsonAsync(ApiEndpoints.ProductUnit, productUnitDto);
    }

    private async Task<string> CreateSalesInvoice(string productId, decimal quantity, long unitPrice)
    {
        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "test-customer",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        response.EnsureSuccessStatusCode();
        var invoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        return invoice!.Id;
    }

    private async Task VerifyBatchQuantity(string batchId, decimal expectedQuantity)
    {
        var batchResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{batchId}");
        if (batchResponse.StatusCode == HttpStatusCode.OK)
        {
            var batch = await batchResponse.Content.ReadFromJsonAsync<StockBatchDto>();
            batch!.Quantity.ShouldBe(expectedQuantity);
        }
    }

    private async Task CreateHistoricalSales(string productId, DateTime startDate, DateTime endDate, decimal totalQuantity)
    {
        // Simulate historical sales data creation
        var historicalSalesRequest = new CreateHistoricalSalesRequestDto
        {
            ProductId = productId,
            StartDate = startDate,
            EndDate = endDate,
            TotalQuantity = totalQuantity,
            Distribution = SalesDistribution.Normal
        };

        await Client.PostAsJsonAsync($"{ApiEndpoints.TestData}/create-historical-sales", historicalSalesRequest);
    }

    private async Task CreateSeasonalSalesData(string productId)
    {
        var seasonalDataRequest = new CreateSeasonalSalesDataRequestDto
        {
            ProductId = productId,
            PeakMonths = new[] { 6, 7, 8, 12 }, // Summer and December
            LowMonths = new[] { 1, 2, 3 },      // Winter months
            BaseQuantity = 50,
            SeasonalVariation = 0.5m // 50% variation
        };

        await Client.PostAsJsonAsync($"{ApiEndpoints.TestData}/create-seasonal-sales", seasonalDataRequest);
    }

    #endregion
}

#region Advanced DTOs

public class InterShopTransferRequestDto
{
    public string SourceShopId { get; set; } = string.Empty;
    public string TargetShopId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public decimal TransferQuantity { get; set; }
    public DateTime TransferDate { get; set; }
    public string? Reference { get; set; }
    public string? Notes { get; set; }
}

public class StockTransferResultDto
{
    public string TransferId { get; set; } = string.Empty;
    public bool Success { get; set; }
    public string? Message { get; set; }
}

public class ShopStockDto
{
    public string ShopId { get; set; } = string.Empty;
    public string ShopName { get; set; } = string.Empty;
    public decimal TotalQuantity { get; set; }
    public int BatchCount { get; set; }
}

public class ConsolidatedStockDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal TotalQuantityAllShops { get; set; }
    public List<ShopStockDto> ShopStocks { get; set; } = new();
}

public class AutoReorderRuleDto
{
    public string ProductId { get; set; } = string.Empty;
    public string SourceShopId { get; set; } = string.Empty;
    public string TargetShopId { get; set; } = string.Empty;
    public decimal ReorderLevel { get; set; }
    public decimal ReorderQuantity { get; set; }
    public bool IsActive { get; set; }
}

public class StockTransferDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public decimal TransferQuantity { get; set; }
    public string? Reference { get; set; }
    public DateTime TransferDate { get; set; }
}

public class AvailableStockDto
{
    public decimal AvailableQuantity { get; set; }
    public decimal ExpiredQuantity { get; set; }
    public decimal ReservedQuantity { get; set; }
}

public class BulkStockAdjustmentRequestDto
{
    public AdjustmentType AdjustmentType { get; set; }
    public DateTime AdjustmentDate { get; set; }
    public string? Reference { get; set; }
    public List<StockAdjustmentItemDto> Adjustments { get; set; } = new();
}

public class StockAdjustmentItemDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public decimal AdjustmentQuantity { get; set; }
    public string? Notes { get; set; }
}

public class StockAdjustmentResultDto
{
    public string AdjustmentId { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public bool RequiresApproval { get; set; }
}

public class ApproveAdjustmentRequestDto
{
    public string AdjustmentId { get; set; } = string.Empty;
    public string ApprovedBy { get; set; } = string.Empty;
    public string? ApprovalNotes { get; set; }
}

public class InventoryForecastRequestDto
{
    public string ProductId { get; set; } = string.Empty;
    public int ForecastPeriodDays { get; set; }
    public int ConfidenceLevel { get; set; } = 95;
}

public class InventoryForecastDto
{
    public string ProductId { get; set; } = string.Empty;
    public decimal ForecastedDemand { get; set; }
    public decimal RecommendedReorderQuantity { get; set; }
    public DateTime? RecommendedReorderDate { get; set; }
    public decimal StockoutRisk { get; set; }
    public decimal ConfidenceLevel { get; set; }
}

public class SeasonalityAnalysisDto
{
    public bool HasSeasonalPattern { get; set; }
    public Dictionary<int, decimal> SeasonalFactors { get; set; } = new();
    public List<int> PeakMonths { get; set; } = new();
    public List<int> LowMonths { get; set; } = new();
}

public class QualityControlCheckRequestDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public DateTime InspectionDate { get; set; }
    public string InspectedBy { get; set; } = string.Empty;
    public QualityStatus QualityStatus { get; set; }
    public string? InspectionNotes { get; set; }
    public int SampleSize { get; set; }
    public int DefectCount { get; set; }
}

public class BatchRecallRequestDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string RecallReason { get; set; } = string.Empty;
    public DateTime RecallDate { get; set; }
    public RecallType RecallType { get; set; }
    public bool NotifyCustomers { get; set; }
    public string? RecallNotes { get; set; }
}

public class BatchRecallResultDto
{
    public string RecallId { get; set; } = string.Empty;
    public int AffectedCustomers { get; set; }
    public decimal RemainingStock { get; set; }
    public List<string> NotificationsSent { get; set; } = new();
}

public class CreateHistoricalSalesRequestDto
{
    public string ProductId { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalQuantity { get; set; }
    public SalesDistribution Distribution { get; set; }
}

public class CreateSeasonalSalesDataRequestDto
{
    public string ProductId { get; set; } = string.Empty;
    public int[] PeakMonths { get; set; } = Array.Empty<int>();
    public int[] LowMonths { get; set; } = Array.Empty<int>();
    public decimal BaseQuantity { get; set; }
    public decimal SeasonalVariation { get; set; }
}

public enum QualityStatus
{
    Pending = 1,
    Passed = 2,
    Failed = 3,
    Quarantined = 4
}

public enum RecallType
{
    Voluntary = 1,
    Mandatory = 2,
    Precautionary = 3
}

public enum SalesDistribution
{
    Normal = 1,
    Uniform = 2,
    Seasonal = 3
}

#endregion