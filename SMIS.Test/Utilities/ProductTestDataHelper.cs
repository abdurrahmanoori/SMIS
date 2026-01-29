using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ProductTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;
    private string? _cachedUnitId;
    private string? _cachedCategoryId;

    public ProductTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string shopId, string unitId, string categoryId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedShopId!, _cachedUnitId!, _cachedCategoryId!);

        _cachedCategoryId = await CreateCategoryAsync();
        _cachedUnitId = await CreateUnitAsync();
        _cachedShopId = await CreateShopAsync();

        return (_cachedShopId, _cachedUnitId, _cachedCategoryId);
    }

    public ProductFixtureBuilder CreateProductBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ProductFixtureBuilder()
            .WithDependencies(_cachedShopId!, _cachedUnitId!, _cachedCategoryId!);
    }

    private bool HasCachedDependencies() => 
        _cachedShopId != null && _cachedUnitId != null && _cachedCategoryId != null;

    private async Task<string> CreateCategoryAsync()
    {
        var categoryDto = new CategoryCreateDto
        {
            Name = "Test Category for Products",
            Code = "TCP",
            Description = "Test category created for product tests",
            IsActive = true
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Category, categoryDto);
        response.EnsureSuccessStatusCode();
        
        var createdCategory = await response.Content.ReadFromJsonAsync<CategoryDto>();
        return createdCategory!.Id;
    }

    private async Task<string> CreateUnitAsync()
    {
        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Piece",
            Symbol = "pcs",
            Description = "Piece unit"
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
            Name = "Test Shop",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 Main St",
            PhoneNumber = "+1234567890",
            Email = "test@shop.com",
            TaxNumber = "TAX001",
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