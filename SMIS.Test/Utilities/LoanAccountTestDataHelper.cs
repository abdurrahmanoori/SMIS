using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class LoanAccountTestDataHelper
{
    private readonly HttpClient _client;
    private string? _cachedShopId;
    private string? _cachedCustomerId;
    private string? _cachedProductId;
    private string? _cachedUnitId;

    public LoanAccountTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<(string shopId, string customerId, string productId, string unitId)> GetOrCreateDependencies()
    {
        if (HasCachedDependencies())
            return (_cachedShopId!, _cachedCustomerId!, _cachedProductId!, _cachedUnitId!);

        _cachedShopId = await CreateShopAsync();
        _cachedUnitId = await CreateUnitOfMeasureAsync();
        _cachedCustomerId = await CreateCustomerAsync();
        _cachedProductId = await CreateProductAsync();

        return (_cachedShopId, _cachedCustomerId, _cachedProductId, _cachedUnitId);
    }

    public LoanAccountFixtureBuilder CreateLoanAccountBuilder()
    {
        if (!HasCachedDependencies())
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new LoanAccountFixtureBuilder()
            .WithDependencies(_cachedShopId!, _cachedCustomerId!, _cachedProductId!, _cachedUnitId!);
    }

    private bool HasCachedDependencies() => 
        _cachedShopId != null && _cachedCustomerId != null && _cachedProductId != null && _cachedUnitId != null;

    private async Task<string> CreateShopAsync()
    {
        var shopDto = new ShopCreateDto
        {
            Name = "Test Shop for LoanAccounts",
            ShopType = Domain.Enums.ShopType.RetailShop,
            Address = "123 LoanAccount Test St",
            PhoneNumber = "+1234567890",
            Email = "loanaccounttest@shop.com",
            TaxNumber = "LTAX001",
            IsActive = true
        };
        
        var createResponse = await _client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        createResponse.EnsureSuccessStatusCode();

        var listResponse = await _client.GetAsync(ApiEndpoints.Shop);
        listResponse.EnsureSuccessStatusCode();
        
        var shopsList = await listResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        return shopsList!.Items.Last().Id;
    }

    private async Task<string> CreateCustomerAsync()
    {
        var customerDto = new CustomerCreateDto
        {
            FirstName = "Test",
            LastName = "Customer",
            ShopId = _cachedShopId!,
            CustomerType = Domain.Enums.CustomerType.Individual,
            PhoneNumber = "+855123456789",
            IsActive = true
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Customer, customerDto);
        response.EnsureSuccessStatusCode();
        
        var createdCustomer = await response.Content.ReadFromJsonAsync<CustomerDto>();
        return createdCustomer!.Id;
    }

    private async Task<string> CreateUnitOfMeasureAsync()
    {
        var unitDto = new UnitOfMeasureCreateDto
        {
            Name = "Piece",
            Symbol = "pc",
            ShopId = _cachedShopId!
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.UnitOfMeasure, unitDto);
        response.EnsureSuccessStatusCode();
        
        var createdUnit = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        return createdUnit!.Id;
    }

    private async Task<string> CreateProductAsync()
    {
        var productDto = new ProductCreateDto
        {
            Name = "Test Product for Loan",
            ShopId = _cachedShopId!,
            BaseUnitId = _cachedUnitId!,
            SKU = "TEST-LOAN-001",
            IsActive = true
        };
        
        var response = await _client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        response.EnsureSuccessStatusCode();
        
        var createdProduct = await response.Content.ReadFromJsonAsync<ProductDto>();
        return createdProduct!.Id;
    }
}
