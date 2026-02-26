using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ProductUnitTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedProductId;
    private string? _cachedUnitId;
    private string? _cachedShopId;

    public ProductUnitTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string productId, string unitId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedProductId!, _cachedUnitId!);

        _cachedShopId = await CreateShopAsync();
        _cachedUnitId = await CreateUnitAsync();
        _cachedProductId = await CreateProductAsync();

        return (_cachedProductId, _cachedUnitId);
    }

    public ProductUnitFixtureBuilder CreateProductUnitBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ProductUnitFixtureBuilder()
            .WithDependencies(_cachedProductId!, _cachedUnitId!);
    }

    public async Task<string> CreateProductUnitForProductAsync(string productId)
    {
        await GetOrCreateDependencies();
        
        var productUnitDto = new ProductUnitFixtureBuilder()
            .WithDependencies(productId, _cachedUnitId!)
            .Build();
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.ProductUnit, productUnitDto);
        response.EnsureSuccessStatusCode();
        
        var createdProductUnit = await response.Content.ReadFromJsonAsync<ProductUnitDto>();
        return createdProductUnit!.Id;
    }

    private bool HasCachedDependencies() => 
        _cachedProductId != null && _cachedUnitId != null;

    private async Task<string> CreateUnitAsync()
    {
        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Box",
            Symbol = "box",
            Description = "Box unit for product unit tests",
            ShopId = _cachedShopId!
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

        var productDto = new ProductCreateDto
        {
            Name = "Test Product for ProductUnit",
            ShopId = _cachedShopId!,
            BaseUnitId = baseUnitId,
            CategoryId = categoryId,
            SKU = $"SKU-PU-{Guid.NewGuid()}",
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
            Name = "Test Category for ProductUnit",
            Code = "TCPU",
            Description = "Test category for product unit tests",
            IsActive = true,
            //ShopId = _cachedShopId!
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
            Description = "Base unit for product",
            ShopId = _cachedShopId!
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
            Name = "Test Shop for ProductUnit",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 Main St",
            PhoneNumber = "+1234567890",
            Email = "testpu@shop.com",
            TaxNumber = "TAXPU001",
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
