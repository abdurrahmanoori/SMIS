namespace SMIS.Test.Utilities;

/// <summary>
/// Centralized API endpoint definitions for integration tests.
/// This class contains all the API endpoints used throughout the test suite.
/// </summary>
public static class ApiEndpoints
{
    // Base API path
    private const string ApiBase = "/api";

    #region Core Entity Endpoints

    // Category endpoints
    public static readonly string Category = $"{ApiBase}/categories";

    // Product endpoints
    public static readonly string Product = $"{ApiBase}/products";

    // Shop endpoints
    public static readonly string Shop = $"{ApiBase}/shops";

    // Unit of Measure endpoints
    public static readonly string UnitOfMeasure = $"{ApiBase}/units-of-measure";

    // Product Unit endpoints
    public static readonly string ProductUnit = $"{ApiBase}/product-units";

    #endregion

    #region Inventory Management Endpoints

    // Stock Batch endpoints
    public static readonly string StockBatch = $"{ApiBase}/stock-batches";

    // Stock Transaction endpoints
    public static readonly string StockTransaction = $"{ApiBase}/stock-transactions";

    // Stock Consumption endpoints
    public static readonly string StockConsumption = $"{ApiBase}/stock-consumptions";

    // Inventory management endpoints
    public static readonly string Inventory = $"{ApiBase}/inventory";

    #endregion

    #region Sales and Purchase Endpoints

    // Invoice endpoints
    public static readonly string Invoice = $"{ApiBase}/invoices";

    // Payment endpoints
    public static readonly string Payment = $"{ApiBase}/payments";

    // Credit payment endpoints
    public static readonly string CreditPayment = $"{ApiBase}/credit-payments";

    // Customer credit endpoints
    public static readonly string CustomerCredit = $"{ApiBase}/customer-credit";

    #endregion

    #region Reporting and Analytics Endpoints

    // Reports endpoints
    public static readonly string Reports = $"{ApiBase}/reports";

    // Analytics endpoints
    public static readonly string Analytics = $"{ApiBase}/analytics";

    #endregion

    #region Quality Control Endpoints

    // Quality control endpoints
    public static readonly string QualityControl = $"{ApiBase}/quality-control";

    #endregion

    #region User Management Endpoints

    // User endpoints
    public static readonly string Users = $"{ApiBase}/users";

    // Authentication endpoints
    public static readonly string Auth = $"{ApiBase}/auth";

    #endregion

    #region Localization Endpoints

    // Language endpoints
    public static readonly string Language = $"{ApiBase}/languages";

    // Translation Key endpoints
    public static readonly string TranslationKey = $"{ApiBase}/translation-keys";

    // Translation endpoints
    public static readonly string Translation = $"{ApiBase}/translations";

    #endregion

    #region Location Endpoints

    // Province endpoints
    public static readonly string Province = $"{ApiBase}/provinces";

    // District endpoints
    public static readonly string District = $"{ApiBase}/districts";

    // Province Translation endpoints
    public static readonly string ProvinceTranslation = $"{ApiBase}/province-translations";

    #endregion

    #region Test Data Endpoints

    // Test data creation endpoints (for integration tests)
    public static readonly string TestData = $"{ApiBase}/test-data";

    #endregion

    #region Specific Inventory Operations

    /// <summary>
    /// Inventory-specific operation endpoints
    /// </summary>
    public static class InventoryOperations
    {
        public static readonly string ConsumeStock = $"{Inventory}/consume-stock";
        public static readonly string AdjustStock = $"{Inventory}/adjust-stock";
        public static readonly string AdjustStockWithApproval = $"{Inventory}/adjust-stock-with-approval";
        public static readonly string ApproveAdjustment = $"{Inventory}/approve-adjustment";
        public static readonly string BulkStockAdjustment = $"{Inventory}/bulk-stock-adjustment";
        public static readonly string TransferStock = $"{Inventory}/transfer-stock";
        public static readonly string InterShopTransfer = $"{Inventory}/inter-shop-transfer";
        public static readonly string MarkExpired = $"{Inventory}/mark-expired";
        public static readonly string CleanupExpiredBatches = $"{Inventory}/cleanup-expired-batches";
        public static readonly string CheckAutoReorder = $"{Inventory}/check-auto-reorder";
        public static readonly string AutoReorderRules = $"{Inventory}/auto-reorder-rules";
        public static readonly string Forecast = $"{Inventory}/forecast";
    }

    /// <summary>
    /// Inventory query endpoints
    /// </summary>
    public static class InventoryQueries
    {
        public static readonly string StockSummary = $"{Inventory}/stock-summary";
        public static readonly string ShopStock = $"{Inventory}/shop-stock";
        public static readonly string ConsolidatedStock = $"{Inventory}/consolidated-stock";
        public static readonly string AvailableStock = $"{Inventory}/available-stock";
        public static readonly string ExpiringStock = $"{Inventory}/expiring-stock";
        public static readonly string LowStock = $"{Inventory}/low-stock";
        public static readonly string StockValuation = $"{Inventory}/stock-valuation";
        public static readonly string MovementHistory = $"{Inventory}/movement-history";
        public static readonly string Transfers = $"{Inventory}/transfers";
    }

    #endregion

    #region Specific Report Endpoints

    /// <summary>
    /// Report-specific endpoints
    /// </summary>
    public static class ReportEndpoints
    {
        public static readonly string InventoryReport = $"{Reports}/inventory-report";
        public static readonly string StockMovementReport = $"{Reports}/stock-movement-report";
        public static readonly string ExpiryReport = $"{Reports}/expiry-report";
        public static readonly string SalesReport = $"{Reports}/sales-report";
        public static readonly string TopSellingProducts = $"{Reports}/top-selling-products";
        public static readonly string SalesByCategory = $"{Reports}/sales-by-category";
        public static readonly string ProfitLossReport = $"{Reports}/profit-loss-report";
        public static readonly string PaymentReport = $"{Reports}/payment-report";
        public static readonly string InventoryTurnoverReport = $"{Reports}/inventory-turnover-report";
        public static readonly string SlowMovingItems = $"{Reports}/slow-moving-items";
        public static readonly string ABCAnalysisReport = $"{Reports}/abc-analysis-report";
        public static readonly string DashboardSummary = $"{Reports}/dashboard-summary";
        public static readonly string SalesTrend = $"{Reports}/sales-trend";
    }

    #endregion

    #region Specific Analytics Endpoints

    /// <summary>
    /// Analytics-specific endpoints
    /// </summary>
    public static class AnalyticsEndpoints
    {
        public static readonly string SeasonalityAnalysis = $"{Analytics}/seasonality-analysis";
        public static readonly string DemandForecast = $"{Analytics}/demand-forecast";
        public static readonly string InventoryOptimization = $"{Analytics}/inventory-optimization";
        public static readonly string PriceAnalysis = $"{Analytics}/price-analysis";
        public static readonly string CustomerAnalysis = $"{Analytics}/customer-analysis";
        public static readonly string SupplierAnalysis = $"{Analytics}/supplier-analysis";
    }

    #endregion

    #region Quality Control Endpoints

    /// <summary>
    /// Quality control specific endpoints
    /// </summary>
    public static class QualityControlEndpoints
    {
        public static readonly string InspectBatch = $"{QualityControl}/inspect-batch";
        public static readonly string InitiateRecall = $"{QualityControl}/initiate-recall";
        public static readonly string QualityReports = $"{QualityControl}/quality-reports";
        public static readonly string DefectTracking = $"{QualityControl}/defect-tracking";
        public static readonly string ComplianceCheck = $"{QualityControl}/compliance-check";
    }

    #endregion

    #region Test Data Creation Endpoints

    /// <summary>
    /// Test data creation endpoints for integration testing
    /// </summary>
    public static class TestDataEndpoints
    {
        public static readonly string CreateHistoricalSales = $"{TestData}/create-historical-sales";
        public static readonly string CreateSeasonalSales = $"{TestData}/create-seasonal-sales";
        public static readonly string CreateTestCustomers = $"{TestData}/create-test-customers";
        public static readonly string CreateTestSuppliers = $"{TestData}/create-test-suppliers";
        public static readonly string GenerateTestTransactions = $"{TestData}/generate-test-transactions";
        public static readonly string CleanupTestData = $"{TestData}/cleanup-test-data";
    }

    #endregion

    #region Helper Methods

    /// <summary>
    /// Gets the endpoint for a specific entity by ID
    /// </summary>
    /// <param name="baseEndpoint">The base endpoint</param>
    /// <param name="id">The entity ID</param>
    /// <returns>The full endpoint path</returns>
    public static string GetByIdEndpoint(string baseEndpoint, string id)
    {
        return $"{baseEndpoint}/{id}";
    }

    /// <summary>
    /// Gets the endpoint for paginated results
    /// </summary>
    /// <param name="baseEndpoint">The base endpoint</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <returns>The full endpoint path with pagination parameters</returns>
    public static string GetPaginatedEndpoint(string baseEndpoint, int pageNumber = 1, int pageSize = 10)
    {
        return $"{baseEndpoint}?pageNumber={pageNumber}&pageSize={pageSize}";
    }

    /// <summary>
    /// Gets the endpoint for filtered results
    /// </summary>
    /// <param name="baseEndpoint">The base endpoint</param>
    /// <param name="filters">Dictionary of filter parameters</param>
    /// <returns>The full endpoint path with filter parameters</returns>
    public static string GetFilteredEndpoint(string baseEndpoint, Dictionary<string, string> filters)
    {
        if (filters == null || !filters.Any())
            return baseEndpoint;

        var queryString = string.Join("&", filters.Select(kvp => $"{kvp.Key}={kvp.Value}"));
        return $"{baseEndpoint}?{queryString}";
    }

    /// <summary>
    /// Gets the endpoint for date range queries
    /// </summary>
    /// <param name="baseEndpoint">The base endpoint</param>
    /// <param name="startDate">Start date</param>
    /// <param name="endDate">End date</param>
    /// <returns>The full endpoint path with date range parameters</returns>
    public static string GetDateRangeEndpoint(string baseEndpoint, DateTime startDate, DateTime endDate)
    {
        return $"{baseEndpoint}?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
    }

    #endregion
}