using SMIS.Application.Common;
using SMIS.Application.DTO.Districts;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Shops;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ShopOwnerTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;
    private string? _cachedUserId;
    private string? _cachedProvinceId;
    private string? _cachedDistrictId;

    public ShopOwnerTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string shopId, string userId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedShopId!, _cachedUserId!);

        _cachedShopId = await CreateShopAsync();
        _cachedUserId = await CreateUserAsync();
        await GetOrCreateLocationAsync();

        return (_cachedShopId, _cachedUserId);
    }

    public ShopOwnerFixtureBuilder CreateShopOwnerBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ShopOwnerFixtureBuilder()
            .WithDependencies(_cachedShopId!, _cachedUserId!)
            .WithProvinceId(_cachedProvinceId)
            .WithDistrictId(_cachedDistrictId);
    }

    private bool HasCachedDependencies() => 
        _cachedShopId != null && _cachedUserId != null;

    private async Task<string> CreateShopAsync()
    {
        var shopDto = new ShopCreateDto
        {
            Name = "Test Shop for ShopOwners",
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

    private async Task GetOrCreateLocationAsync()
    {
        var provinceResponse = await _client.GetAsync($"{ApiEndpoints.Province}?pageNumber=1&pageSize=1");
        if (provinceResponse.IsSuccessStatusCode)
        {
            var provinces = await provinceResponse.Content.ReadFromJsonAsync<PagedList<ProvinceDto>>();
            if (provinces?.Items?.Count > 0)
            {
                _cachedProvinceId = provinces.Items[0].Id;
                
                var districtResponse = await _client.GetAsync($"{ApiEndpoints.District}?pageNumber=1&pageSize=1");
                if (districtResponse.IsSuccessStatusCode)
                {
                    var districts = await districtResponse.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
                    if (districts?.Items?.Count > 0)
                    {
                        _cachedDistrictId = districts.Items[0].Id;
                    }
                }
            }
        }
    }

    private async Task<string> CreateUserAsync()
    {
        var userResponse = await _client.GetAsync($"{ApiEndpoints.Account}?pageNumber=1&pageSize=1");
        if (userResponse.IsSuccessStatusCode)
        {
            var users = await userResponse.Content.ReadFromJsonAsync<PagedList<dynamic>>();
            if (users?.Items?.Count > 0)
            {
                return users.Items[0].GetProperty("id").GetString() ?? "1";
            }
        }
        return "1"; // Fallback to seeded superadmin user
    }
}