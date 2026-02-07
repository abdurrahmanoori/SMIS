using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ProductPriceTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedProductId;
    private string? _cachedProductUnitId;
    private readonly ProductTestDataHelper _productHelper;
    private readonly ProductUnitTestDataHelper _productUnitHelper;

    public ProductPriceTestDataHelper(HttpClient client)
    {
        _client = client;
        _productHelper = new ProductTestDataHelper(client);
        _productUnitHelper = new ProductUnitTestDataHelper(client);
    }

    public async Task<(string ProductId, string ProductUnitId)> GetOrCreateDependencies()
    {
        if (_cachedProductId != null && _cachedProductUnitId != null)
            return (_cachedProductId, _cachedProductUnitId);

        await _productHelper.GetOrCreateDependencies();
        _cachedProductId = await CreateProductAsync();
        _cachedProductUnitId = await _productUnitHelper.CreateProductUnitForProductAsync(_cachedProductId);

        return (_cachedProductId, _cachedProductUnitId);
    }

    public ProductPriceFixtureBuilder CreateProductPriceBuilder()
    {
        if (_cachedProductId == null || _cachedProductUnitId == null)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ProductPriceFixtureBuilder()
            .WithDependencies(_cachedProductId, _cachedProductUnitId);
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
