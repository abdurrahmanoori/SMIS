using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class StockBatchTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedProductId;
    private string? _cachedUnitId;

    public StockBatchTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string productId, string unitId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedProductId!, _cachedUnitId!);

        _cachedUnitId = await CreateUnitAsync();
        _cachedProductId = await CreateProductAsync();

        return (_cachedProductId, _cachedUnitId);
    }

    public StockBatchFixtureBuilder CreateStockBatchBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new StockBatchFixtureBuilder()
            .WithDependencies(_cachedProductId!, _cachedUnitId!);
    }

    private bool HasCachedDependencies() => 
        _cachedProductId != null && _cachedUnitId != null;

    private async Task<string> CreateUnitAsync()
    {
        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Bottle",
            Symbol = "btl",
            Description = "Bottle unit for stock batch tests"
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.UnitOfMeasure, unitDto);
        response.EnsureSuccessStatusCode();
        
        var createdUnit = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        return createdUnit!.Id;
    }

    private async Task<string> CreateProductAsync()
    {
        var categoryId = await CreateCategoryAsync();
        var baseUnitId = await CreateBaseUnitAsync();
        var shopId = await CreateShopAsync();

        var productDto = new ProductCreateDto
        {
            Name = "Test Product for StockBatch",
            ShopId = shopId,
            BaseUnitId = baseUnitId,
            CategoryId = categoryId,
            SalePricePerBaseUnit = 1000,
            SKU = $"SKU-SB-{Guid.NewGuid()}",
            IsActive = true
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        response.EnsureSuccessStatusCode();
        
        var createdProduct = await response.Content.ReadFromJsonAsync<ProductDto>();
        return createdProduct!.Id;
    }

    private async Task<string> CreateCategoryAsync()
    {
        var categoryDto = new CategoryCreateDto
        {
            Name = "Test Category for StockBatch",
            Code = "TCSB",
            Description = "Test category for stock batch tests",
            IsActive = true
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Category, categoryDto);
        response.EnsureSuccessStatusCode();
        
        var createdCategory = await response.Content.ReadFromJsonAsync<CategoryDto>();
        return createdCategory!.Id;
    }

    private async Task<string> CreateBaseUnitAsync()
    {
        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Piece",
            Symbol = "pcs",
            Description = "Base unit for product"
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.UnitOfMeasure, unitDto);
        response.EnsureSuccessStatusCode();
        
        var createdUnit = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        return createdUnit!.Id;
    }

    private async Task<string> CreateShopAsync()
    {
        var shopDto = new ShopCreateDto
        {
            Name = "Test Shop for StockBatch",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 Main St",
            PhoneNumber = "+1234567890",
            Email = "testsb@shop.com",
            TaxNumber = "TAXSB001",
            IsActive = true
        };
        
        var createResponse = await _client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        createResponse.EnsureSuccessStatusCode();

        var listResponse = await _client.GetAsync(ApiEndpoints.Shop);
        listResponse.EnsureSuccessStatusCode();
        
        var shopsList = await listResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        return shopsList!.Items.Last().Id;
    }
}
