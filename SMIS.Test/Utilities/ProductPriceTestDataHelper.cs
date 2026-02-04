using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ProductPriceTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedProductId;
    private readonly ProductTestDataHelper _productHelper;

    public ProductPriceTestDataHelper(HttpClient client)
    {
        _client = client;
        _productHelper = new ProductTestDataHelper(client);
    }

    public async Task<string> GetOrCreateDependencies()
    {
        if (_cachedProductId != null)
            return _cachedProductId;

        await _productHelper.GetOrCreateDependencies();
        _cachedProductId = await CreateProductAsync();

        return _cachedProductId;
    }

    public ProductPriceFixtureBuilder CreateProductPriceBuilder()
    {
        if (_cachedProductId == null)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ProductPriceFixtureBuilder()
            .WithDependencies(_cachedProductId);
    }

    private async Task<string> CreateProductAsync()
    {
        var productDto = _productHelper.CreateProductBuilder().Build();
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        response.EnsureSuccessStatusCode();
        
        var createdProduct = await response.Content.ReadFromJsonAsync<ProductDto>();
        return createdProduct!.Id;
    }
}
