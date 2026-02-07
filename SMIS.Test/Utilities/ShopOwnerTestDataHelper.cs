using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ShopOwnerTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;
    private string? _cachedUserId;

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

        return (_cachedShopId, _cachedUserId);
    }

    public ShopOwnerFixtureBuilder CreateShopOwnerBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ShopOwnerFixtureBuilder()
            .WithDependencies(_cachedShopId!, _cachedUserId!);
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

    private async Task<string> CreateUserAsync()
    {
        // For now, return a default user ID - in real implementation, 
        // this would create a test user via the Account API
        return "test-user-id-" + Guid.NewGuid().ToString("N")[..8];
    }
}