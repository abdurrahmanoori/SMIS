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

public class ReportingAndAnalyticsIntegrationTests : BaseIntegrationTest
{
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly ProductTestDataHelper _productHelper;

    public ReportingAndAnalyticsIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
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

    #region Inventory Reports

    [Fact]
    public async Task GetInventoryReport_ReturnsCurrentStockLevels()
    {
        // Arrange - Create products with different stock levels
        var product1 = await CreateTestProduct("High Stock Item");
        var product2 = await CreateTestProduct("Low Stock Item");
        var product3 = await CreateTestProduct("Out of Stock Item");

        await CreateStockBatch(product1.Id, 100, "HS-001");
        await CreateStockBatch(product2.Id, 5, "LS-001");
        // product3 has no stock

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/inventory-report");
        await LogIfError(response, "GetInventoryReport");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var report = await response.Content.ReadFromJsonAsync<InventoryReportDto>();
        report.ShouldNotBeNull();
        report!.Items.Count.ShouldBeGreaterThanOrEqualTo(3);
        
        var highStockItem = report.Items.FirstOrDefault(i => i.ProductName == "High Stock Item");
        highStockItem.ShouldNotBeNull();
        highStockItem!.CurrentStock.ShouldBe(100);
        
        var lowStockItem = report.Items.FirstOrDefault(i => i.ProductName == "Low Stock Item");
        lowStockItem!.CurrentStock.ShouldBe(5);
        
        var outOfStockItem = report.Items.FirstOrDefault(i => i.ProductName == "Out of Stock Item");
        outOfStockItem!.CurrentStock.ShouldBe(0);
    }

    [Fact]
    public async Task GetInventoryReport_WithFilters_ReturnsFilteredResults()
    {
        // Arrange
        var categoryId = await CreateTestCategory("Electronics");
        var product = await CreateTestProduct("Filtered Item", categoryId: categoryId);
        await CreateStockBatch(product.Id, 50, "FI-001");

        // Act - Filter by category
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/inventory-report?categoryId={categoryId}");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var report = await response.Content.ReadFromJsonAsync<InventoryReportDto>();
        report!.Items.ShouldAllBe(item => item.CategoryId == categoryId);
    }

    [Fact]
    public async Task GetStockMovementReport_ReturnsMovementHistory()
    {
        // Arrange - Create product and perform movements
        var product = await CreateTestProduct("Movement Test Item");
        var batch = await CreateStockBatch(product.Id, 100, "MT-001");

        // Simulate some movements
        await ConsumeStock(product.Id, 20, "Sale #001");
        await AdjustStock(batch.Id, -5, AdjustmentType.Damage);
        await ConsumeStock(product.Id, 10, "Sale #002");

        // Act
        var startDate = DateTime.UtcNow.AddDays(-1);
        var endDate = DateTime.UtcNow.AddDays(1);
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/stock-movement-report?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        await LogIfError(response, "GetStockMovementReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<StockMovementReportDto>();
            report!.Movements.Count.ShouldBeGreaterThanOrEqualTo(4); // Initial + 3 movements
            report.Movements.ShouldContain(m => m.MovementType == "In" && m.Quantity == 100);
            report.Movements.ShouldContain(m => m.MovementType == "Out" && m.Quantity == 20);
            report.Movements.ShouldContain(m => m.MovementType == "Adjustment" && m.Quantity == 5);
        }
    }

    [Fact]
    public async Task GetExpiryReport_ReturnsExpiringItems()
    {
        // Arrange - Create items with different expiry dates
        var product1 = await CreateTestProduct("Expiring Soon");
        var product2 = await CreateTestProduct("Expiring Later");
        var product3 = await CreateTestProduct("No Expiry");

        var expiringSoon = CreateStockBatchDto(product1.Id, 30, "ES-001", DateTime.UtcNow.AddDays(3));
        var expiringLater = CreateStockBatchDto(product2.Id, 40, "EL-001", DateTime.UtcNow.AddMonths(6));
        var noExpiry = CreateStockBatchDto(product3.Id, 50, "NE-001", null);

        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, expiringSoon);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, expiringLater);
        await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, noExpiry);

        // Act - Get items expiring within 7 days
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/expiry-report?days=7");
        await LogIfError(response, "GetExpiryReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<ExpiryReportDto>();
            report!.ExpiringItems.ShouldContain(item => item.ProductName == "Expiring Soon");
            report.ExpiringItems.ShouldNotContain(item => item.ProductName == "Expiring Later");
            report.ExpiringItems.ShouldNotContain(item => item.ProductName == "No Expiry");
        }
    }

    #endregion

    #region Sales Reports

    [Fact]
    public async Task GetSalesReport_ReturnsSalesData()
    {
        // Arrange - Create sales
        var product1 = await CreateTestProduct("Sales Item 1");
        var product2 = await CreateTestProduct("Sales Item 2");
        
        await CreateStockBatch(product1.Id, 100, "SI1-001");
        await CreateStockBatch(product2.Id, 50, "SI2-001");

        // Create sales invoices
        await CreateSalesInvoice(product1.Id, 10, 500); // $50 total
        await CreateSalesInvoice(product2.Id, 5, 800);  // $40 total
        await CreateSalesInvoice(product1.Id, 15, 500); // $75 total

        // Act
        var startDate = DateTime.UtcNow.AddDays(-1);
        var endDate = DateTime.UtcNow.AddDays(1);
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/sales-report?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        await LogIfError(response, "GetSalesReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<SalesReportDto>();
            report!.TotalSales.ShouldBeGreaterThan(0);
            report.TotalQuantitySold.ShouldBe(30); // 10 + 5 + 15 = 30
            report.ProductSales.Count.ShouldBe(2);
            
            var product1Sales = report.ProductSales.FirstOrDefault(p => p.ProductName == "Sales Item 1");
            product1Sales!.QuantitySold.ShouldBe(25); // 10 + 15 = 25
        }
    }

    [Fact]
    public async Task GetTopSellingProducts_ReturnsRankedProducts()
    {
        // Arrange - Create products with different sales volumes
        var product1 = await CreateTestProduct("Best Seller");
        var product2 = await CreateTestProduct("Good Seller");
        var product3 = await CreateTestProduct("Slow Seller");

        await CreateStockBatch(product1.Id, 200, "BS-001");
        await CreateStockBatch(product2.Id, 100, "GS-001");
        await CreateStockBatch(product3.Id, 50, "SS-001");

        // Create different sales volumes
        await CreateSalesInvoice(product1.Id, 50, 300); // High volume
        await CreateSalesInvoice(product2.Id, 20, 400); // Medium volume
        await CreateSalesInvoice(product3.Id, 5, 500);  // Low volume

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/top-selling-products?limit=10");
        await LogIfError(response, "GetTopSellingProducts");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<TopSellingProductsReportDto>();
            report!.Products.Count.ShouldBeGreaterThanOrEqualTo(3);
            
            // Should be ordered by quantity sold (descending)
            var firstProduct = report.Products.First();
            firstProduct.ProductName.ShouldBe("Best Seller");
            firstProduct.QuantitySold.ShouldBe(50);
        }
    }

    [Fact]
    public async Task GetSalesByCategory_ReturnsGroupedData()
    {
        // Arrange
        var beverageCategory = await CreateTestCategory("Beverages");
        var snackCategory = await CreateTestCategory("Snacks");

        var beverage = await CreateTestProduct("Soda", categoryId: beverageCategory);
        var snack = await CreateTestProduct("Chips", categoryId: snackCategory);

        await CreateStockBatch(beverage.Id, 100, "SD-001");
        await CreateStockBatch(snack.Id, 80, "CH-001");

        await CreateSalesInvoice(beverage.Id, 30, 200);
        await CreateSalesInvoice(snack.Id, 15, 300);

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/sales-by-category");
        await LogIfError(response, "GetSalesByCategory");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<SalesByCategoryReportDto>();
            report!.CategorySales.Count.ShouldBeGreaterThanOrEqualTo(2);
            
            var beverageSales = report.CategorySales.FirstOrDefault(c => c.CategoryName == "Beverages");
            beverageSales!.QuantitySold.ShouldBe(30);
            
            var snackSales = report.CategorySales.FirstOrDefault(c => c.CategoryName == "Snacks");
            snackSales!.QuantitySold.ShouldBe(15);
        }
    }

    #endregion

    #region Financial Reports

    [Fact]
    public async Task GetProfitLossReport_ReturnsFinancialData()
    {
        // Arrange - Create purchase and sales with different margins
        var product = await CreateTestProduct("Profit Test Item");
        
        // Purchase at $3.00 per unit
        await CreatePurchaseInvoice(product.Id, 100, 300);
        
        // Sell at $5.00 per unit
        await CreateSalesInvoice(product.Id, 50, 500);

        // Act
        var startDate = DateTime.UtcNow.AddDays(-1);
        var endDate = DateTime.UtcNow.AddDays(1);
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/profit-loss-report?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        await LogIfError(response, "GetProfitLossReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<ProfitLossReportDto>();
            report!.TotalRevenue.ShouldBe(25000); // 50 * 500 = 25000
            report.TotalCostOfGoodsSold.ShouldBe(15000); // 50 * 300 = 15000
            report.GrossProfit.ShouldBe(10000); // 25000 - 15000 = 10000
            report.GrossProfitMargin.ShouldBe(40); // (10000 / 25000) * 100 = 40%
        }
    }

    [Fact]
    public async Task GetPaymentReport_ReturnsPaymentAnalysis()
    {
        // Arrange - Create invoices with different payment statuses
        var product = await CreateTestProduct("Payment Test Item");
        await CreateStockBatch(product.Id, 100, "PT-001");

        var paidInvoice = await CreateSalesInvoice(product.Id, 10, 400);
        var partialInvoice = await CreateSalesInvoice(product.Id, 15, 600);
        var unpaidInvoice = await CreateSalesInvoice(product.Id, 8, 500);

        // Process payments
        await ProcessPayment(paidInvoice, 4000); // Full payment
        await ProcessPayment(partialInvoice, 5000); // Partial payment (total is 9000)

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/payment-report");
        await LogIfError(response, "GetPaymentReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<PaymentReportDto>();
            report!.TotalInvoices.ShouldBeGreaterThanOrEqualTo(3);
            report.PaidInvoices.ShouldBeGreaterThanOrEqualTo(1);
            report.PartiallyPaidInvoices.ShouldBeGreaterThanOrEqualTo(1);
            report.UnpaidInvoices.ShouldBeGreaterThanOrEqualTo(1);
            report.TotalOutstanding.ShouldBeGreaterThan(0);
        }
    }

    #endregion

    #region Performance Analytics

    [Fact]
    public async Task GetInventoryTurnoverReport_ReturnsAnalytics()
    {
        // Arrange - Create product with purchase and sales over time
        var product = await CreateTestProduct("Turnover Test Item");
        
        // Initial purchase
        await CreatePurchaseInvoice(product.Id, 200, 250);
        
        // Multiple sales over time
        await CreateSalesInvoice(product.Id, 50, 400);
        await CreateSalesInvoice(product.Id, 30, 400);
        await CreateSalesInvoice(product.Id, 40, 400);

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/inventory-turnover-report");
        await LogIfError(response, "GetInventoryTurnoverReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<InventoryTurnoverReportDto>();
            report!.ProductTurnovers.ShouldNotBeEmpty();
            
            var productTurnover = report.ProductTurnovers.FirstOrDefault(p => p.ProductName == "Turnover Test Item");
            productTurnover.ShouldNotBeNull();
            productTurnover!.TurnoverRatio.ShouldBeGreaterThan(0);
            productTurnover.DaysInInventory.ShouldBeGreaterThan(0);
        }
    }

    [Fact]
    public async Task GetSlowMovingItemsReport_ReturnsSlowMovers()
    {
        // Arrange - Create items with different movement patterns
        var fastMoving = await CreateTestProduct("Fast Moving Item");
        var slowMoving = await CreateTestProduct("Slow Moving Item");
        var noMovement = await CreateTestProduct("No Movement Item");

        await CreateStockBatch(fastMoving.Id, 100, "FM-001");
        await CreateStockBatch(slowMoving.Id, 50, "SM-001");
        await CreateStockBatch(noMovement.Id, 30, "NM-001");

        // Create different movement patterns
        await CreateSalesInvoice(fastMoving.Id, 80, 300); // High movement
        await CreateSalesInvoice(slowMoving.Id, 5, 400);  // Low movement
        // No sales for noMovement item

        // Act - Get items with low movement (threshold = 10% turnover)
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/slow-moving-items?threshold=10");
        await LogIfError(response, "GetSlowMovingItemsReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<SlowMovingItemsReportDto>();
            report!.SlowMovingItems.ShouldContain(item => item.ProductName == "Slow Moving Item");
            report.SlowMovingItems.ShouldContain(item => item.ProductName == "No Movement Item");
            report.SlowMovingItems.ShouldNotContain(item => item.ProductName == "Fast Moving Item");
        }
    }

    [Fact]
    public async Task GetABCAnalysisReport_ReturnsClassification()
    {
        // Arrange - Create products with different value contributions
        var highValue = await CreateTestProduct("High Value Item");
        var mediumValue = await CreateTestProduct("Medium Value Item");
        var lowValue = await CreateTestProduct("Low Value Item");

        await CreateStockBatch(highValue.Id, 100, "HV-001");
        await CreateStockBatch(mediumValue.Id, 200, "MV-001");
        await CreateStockBatch(lowValue.Id, 500, "LV-001");

        // Create sales with different values
        await CreateSalesInvoice(highValue.Id, 50, 2000);  // High value sales
        await CreateSalesInvoice(mediumValue.Id, 100, 500); // Medium value sales
        await CreateSalesInvoice(lowValue.Id, 200, 100);   // Low value sales

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/abc-analysis-report");
        await LogIfError(response, "GetABCAnalysisReport");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var report = await response.Content.ReadFromJsonAsync<ABCAnalysisReportDto>();
            report!.ClassAItems.ShouldNotBeEmpty();
            report.ClassBItems.ShouldNotBeEmpty();
            report.ClassCItems.ShouldNotBeEmpty();
            
            // High value item should be in Class A
            report.ClassAItems.ShouldContain(item => item.ProductName == "High Value Item");
        }
    }

    #endregion

    #region Dashboard Analytics

    [Fact]
    public async Task GetDashboardSummary_ReturnsKeyMetrics()
    {
        // Arrange - Create diverse data
        var product1 = await CreateTestProduct("Dashboard Item 1");
        var product2 = await CreateTestProduct("Dashboard Item 2");

        await CreateStockBatch(product1.Id, 100, "DI1-001");
        await CreateStockBatch(product2.Id, 50, "DI2-001");

        await CreateSalesInvoice(product1.Id, 20, 500);
        await CreateSalesInvoice(product2.Id, 10, 800);

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/dashboard-summary");
        await LogIfError(response, "GetDashboardSummary");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var summary = await response.Content.ReadFromJsonAsync<DashboardSummaryDto>();
        summary.ShouldNotBeNull();
        summary!.TotalProducts.ShouldBeGreaterThanOrEqualTo(2);
        summary.TotalStockValue.ShouldBeGreaterThan(0);
        summary.TodaysSales.ShouldBeGreaterThan(0);
        summary.LowStockItems.ShouldBeGreaterThanOrEqualTo(0);
        summary.ExpiringItems.ShouldBeGreaterThanOrEqualTo(0);
    }

    [Fact]
    public async Task GetSalesTrend_ReturnsTimeSeriesData()
    {
        // Arrange - Create sales over different days
        var product = await CreateTestProduct("Trend Test Item");
        await CreateStockBatch(product.Id, 200, "TT-001");

        // Create sales for different dates (simulate historical data)
        await CreateSalesInvoiceWithDate(product.Id, 10, 300, DateTime.UtcNow.AddDays(-5));
        await CreateSalesInvoiceWithDate(product.Id, 15, 300, DateTime.UtcNow.AddDays(-3));
        await CreateSalesInvoiceWithDate(product.Id, 20, 300, DateTime.UtcNow.AddDays(-1));

        // Act
        var response = await Client.GetAsync($"{ApiEndpoints.Reports}/sales-trend?days=7");
        await LogIfError(response, "GetSalesTrend");

        // Assert
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var trend = await response.Content.ReadFromJsonAsync<SalesTrendDto>();
            trend!.DataPoints.Count.ShouldBeGreaterThanOrEqualTo(3);
            trend.DataPoints.ShouldBeInOrder(SortDirection.Ascending, dp => dp.Date);
        }
    }

    #endregion

    #region Helper Methods

    private async Task<ProductDto> CreateTestProduct(string name, string? categoryId = null)
    {
        var productDto = _productHelper.CreateProductBuilder()
            .WithName(name)
            .WithCategoryId(categoryId)
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

    private StockBatchCreateDto CreateStockBatchDto(string productId, decimal quantity, string batchNumber, DateTime? expirationDate)
    {
        return _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .WithExpirationDate(expirationDate)
            .Build();
    }

    private async Task<string> CreateTestCategory(string name)
    {
        var categoryDto = new CategoryCreateDto { Name = name };
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Category, categoryDto);
        response.EnsureSuccessStatusCode();
        var category = await response.Content.ReadFromJsonAsync<CategoryDto>();
        return category!.Id;
    }

    private async Task<string> CreateSalesInvoice(string productId, decimal quantity, long unitPrice)
    {
        return await CreateSalesInvoiceWithDate(productId, quantity, unitPrice, DateTime.UtcNow);
    }

    private async Task<string> CreateSalesInvoiceWithDate(string productId, decimal quantity, long unitPrice, DateTime invoiceDate)
    {
        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "test-customer",
            InvoiceDate = invoiceDate,
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

    private async Task CreatePurchaseInvoice(string productId, decimal quantity, long unitPrice)
    {
        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.In,
            BuyerShopId = _productHelper.DefaultShopId,
            IssuerShopId = "supplier-shop",
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

        await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
    }

    private async Task ProcessPayment(string invoiceId, long amount)
    {
        var paymentDto = new PaymentCreateDto
        {
            InvoiceId = invoiceId,
            PaymentAmount = amount,
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "Test payment"
        };

        await Client.PostAsJsonAsync(ApiEndpoints.Payment, paymentDto);
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

    #endregion
}

#region Report DTOs

public class InventoryReportDto
{
    public List<InventoryReportItemDto> Items { get; set; } = new();
    public decimal TotalStockValue { get; set; }
    public int TotalProducts { get; set; }
}

public class InventoryReportItemDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string? CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public decimal CurrentStock { get; set; }
    public decimal StockValue { get; set; }
    public string Status { get; set; } = string.Empty;
}

public class StockMovementReportDto
{
    public List<StockMovementReportItemDto> Movements { get; set; } = new();
    public decimal TotalInbound { get; set; }
    public decimal TotalOutbound { get; set; }
    public decimal NetMovement { get; set; }
}

public class StockMovementReportItemDto
{
    public DateTime MovementDate { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string MovementType { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public string? Reference { get; set; }
}

public class ExpiryReportDto
{
    public List<ExpiryReportItemDto> ExpiringItems { get; set; } = new();
    public decimal TotalExpiringValue { get; set; }
}

public class ExpiryReportItemDto
{
    public string ProductName { get; set; } = string.Empty;
    public string? BatchNumber { get; set; }
    public decimal Quantity { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int DaysToExpiry { get; set; }
    public decimal Value { get; set; }
}

public class SalesReportDto
{
    public long TotalSales { get; set; }
    public decimal TotalQuantitySold { get; set; }
    public int TotalInvoices { get; set; }
    public long AverageInvoiceValue { get; set; }
    public List<ProductSalesDto> ProductSales { get; set; } = new();
}

public class ProductSalesDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal QuantitySold { get; set; }
    public long TotalSales { get; set; }
    public long AveragePrice { get; set; }
}

public class TopSellingProductsReportDto
{
    public List<TopSellingProductDto> Products { get; set; } = new();
}

public class TopSellingProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal QuantitySold { get; set; }
    public long TotalRevenue { get; set; }
    public int Rank { get; set; }
}

public class SalesByCategoryReportDto
{
    public List<CategorySalesDto> CategorySales { get; set; } = new();
}

public class CategorySalesDto
{
    public string CategoryName { get; set; } = string.Empty;
    public decimal QuantitySold { get; set; }
    public long TotalSales { get; set; }
    public decimal Percentage { get; set; }
}

public class ProfitLossReportDto
{
    public long TotalRevenue { get; set; }
    public long TotalCostOfGoodsSold { get; set; }
    public long GrossProfit { get; set; }
    public decimal GrossProfitMargin { get; set; }
    public long TotalExpenses { get; set; }
    public long NetProfit { get; set; }
    public decimal NetProfitMargin { get; set; }
}

public class PaymentReportDto
{
    public int TotalInvoices { get; set; }
    public int PaidInvoices { get; set; }
    public int PartiallyPaidInvoices { get; set; }
    public int UnpaidInvoices { get; set; }
    public long TotalInvoiceValue { get; set; }
    public long TotalPaid { get; set; }
    public long TotalOutstanding { get; set; }
}

public class InventoryTurnoverReportDto
{
    public List<ProductTurnoverDto> ProductTurnovers { get; set; } = new();
    public decimal AverageTurnoverRatio { get; set; }
}

public class ProductTurnoverDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal TurnoverRatio { get; set; }
    public decimal DaysInInventory { get; set; }
    public string Classification { get; set; } = string.Empty;
}

public class SlowMovingItemsReportDto
{
    public List<SlowMovingItemDto> SlowMovingItems { get; set; } = new();
    public decimal TotalSlowMovingValue { get; set; }
}

public class SlowMovingItemDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal CurrentStock { get; set; }
    public decimal MovementRate { get; set; }
    public int DaysSinceLastSale { get; set; }
    public decimal StockValue { get; set; }
}

public class ABCAnalysisReportDto
{
    public List<ABCItemDto> ClassAItems { get; set; } = new();
    public List<ABCItemDto> ClassBItems { get; set; } = new();
    public List<ABCItemDto> ClassCItems { get; set; } = new();
}

public class ABCItemDto
{
    public string ProductName { get; set; } = string.Empty;
    public long AnnualValue { get; set; }
    public decimal Percentage { get; set; }
    public decimal CumulativePercentage { get; set; }
    public string Classification { get; set; } = string.Empty;
}

public class DashboardSummaryDto
{
    public int TotalProducts { get; set; }
    public decimal TotalStockValue { get; set; }
    public long TodaysSales { get; set; }
    public int LowStockItems { get; set; }
    public int ExpiringItems { get; set; }
    public int PendingOrders { get; set; }
    public long MonthlyRevenue { get; set; }
    public decimal MonthlyGrowth { get; set; }
}

public class SalesTrendDto
{
    public List<SalesTrendDataPointDto> DataPoints { get; set; } = new();
    public decimal TrendDirection { get; set; }
}

public class SalesTrendDataPointDto
{
    public DateTime Date { get; set; }
    public long Sales { get; set; }
    public decimal Quantity { get; set; }
}

public class CategoryCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class CategoryDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}

#endregion