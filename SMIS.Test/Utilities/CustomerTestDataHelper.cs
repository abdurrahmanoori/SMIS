using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Districts;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class CustomerTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;
    private string? _cachedProvinceId;
    private string? _cachedDistrictId;

    public CustomerTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string shopId, string provinceId, string districtId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedShopId!, _cachedProvinceId!, _cachedDistrictId!);

        _cachedShopId = await CreateShopAsync();
        _cachedProvinceId = await CreateProvinceAsync();
        _cachedDistrictId = await CreateDistrictAsync();

        return (_cachedShopId, _cachedProvinceId, _cachedDistrictId);
    }

    public CustomerFixtureBuilder CreateCustomerBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new CustomerFixtureBuilder()
            .WithDependencies(_cachedShopId!, _cachedProvinceId!, _cachedDistrictId!);
    }

    private bool HasCachedDependencies() => 
        _cachedShopId != null && _cachedProvinceId != null && _cachedDistrictId != null;

    private async Task<string> CreateShopAsync()
    {
        var shopDto = new ShopCreateDto
        {
            Name = "Test Shop for Customers",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 Customer Test St",
            PhoneNumber = "+1234567890",
            Email = "customertest@shop.com",
            TaxNumber = "CTAX001",
            IsActive = true
        };
        
        var createResponse = await _client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        createResponse.EnsureSuccessStatusCode();

        var listResponse = await _client.GetAsync(ApiEndpoints.Shop);
        listResponse.EnsureSuccessStatusCode();
        
        var shopsList = await listResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        return shopsList!.Items.Last().Id;
    }

    private async Task<string> CreateProvinceAsync()
    {
        var provinceDto = new ProvinceCreateDto
        {
            Name = "Test Province for Customers"
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Province, provinceDto);
        response.EnsureSuccessStatusCode();
        
        var createdProvince = await response.Content.ReadFromJsonAsync<ProvinceDto>();
        return createdProvince!.Id;
    }

    private async Task<string> CreateDistrictAsync()
    {
        var districtDto = new DistrictCreateDto
        {
            Name = "Test District for Customers",
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.District, districtDto);
        response.EnsureSuccessStatusCode();
        
        var createdDistrict = await response.Content.ReadFromJsonAsync<DistrictDto>();
        return createdDistrict!.Id;
    }
}