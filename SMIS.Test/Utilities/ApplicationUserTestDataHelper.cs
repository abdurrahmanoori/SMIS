using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ApplicationUserTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;

    public ApplicationUserTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return _cachedShopId!;

        _cachedShopId = await CreateShopAsync();

        return _cachedShopId;
    }

    public ApplicationUserFixtureBuilder CreateApplicationUserBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ApplicationUserFixtureBuilder()
            .WithDependencies(_cachedShopId!);
    }

    private bool HasCachedDependencies() => 
        _cachedShopId != null;

    private async Task<string> CreateShopAsync()
    {
        var shopDto = new ShopCreateDto
        {
            Name = "Test Shop for Users",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 Main St",
            PhoneNumber = "+1234567890",
            Email = "testshop@users.com",
            TaxNumber = "TAX002",
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