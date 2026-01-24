//using System.Net.Http.Json;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Common;
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
        if (_cachedShopId != null && _cachedUnitId != null && _cachedCategoryId != null)
            return (_cachedShopId, _cachedUnitId, _cachedCategoryId);

        var categoryDto = new CategoryCreateDto
        {
            Name = "Test Category for Products",
            Code = "TCP",
            Description = "Test category created for product tests",
            IsActive = true
        };
        var categoryResponse = await _client.PostAsJsonAsync("/api/category", categoryDto);
        categoryResponse.EnsureSuccessStatusCode();
        var createdCategory = await categoryResponse.Content.ReadFromJsonAsync<CategoryDto>();

        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Piece",
            Symbol = "pcs",
            Description = "Piece unit"
        };
        var unitResponse = await _client.PostAsJsonAsync("/api/unitofmeasure", unitDto);
        unitResponse.EnsureSuccessStatusCode();
        var createdUnit = await unitResponse.Content.ReadFromJsonAsync<UnitOfMeasureDto>();

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
        var shopResponse = await _client.PostAsJsonAsync("/api/shop", shopDto);
        shopResponse.EnsureSuccessStatusCode();

        var shopsResponse = await _client.GetAsync("/api/shop");
        shopsResponse.EnsureSuccessStatusCode();
        var shopsList = await shopsResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();

        _cachedShopId = shopsList!.Items.Last().Id;
        _cachedUnitId = createdUnit!.Id;
        _cachedCategoryId = createdCategory!.Id;

        return (_cachedShopId, _cachedUnitId, _cachedCategoryId);
    }
}
