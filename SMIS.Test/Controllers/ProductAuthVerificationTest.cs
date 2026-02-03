using System.Net;
using Shouldly;
using SMIS.Application.DTO.Auth;
using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

/// <summary>
/// Verification test to confirm that the Product controller authorization issue has been fixed
/// </summary>
public class ProductAuthVerificationTest : BaseIntegrationTest
{
    private readonly ProductTestDataHelper _productHelper;

    public ProductAuthVerificationTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _productHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _productHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task Authenticated_GetAllProducts_ShouldReturnUsersShopProducts()
    {
        // Arrange - Login with a seeded user (wadmin belongs to shop 1)
        var loginDto = new LoginDto
        {
            Email = "wadmin@smis.com",  // From UserSeed.cs - belongs to shop 1
            Password = "Pass123!"
        };

        // Login to get JWT token
        var loginResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        loginResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResponseDto>();
        loginResult.ShouldNotBeNull();
        loginResult!.Token.ShouldNotBeNullOrWhiteSpace();

        // Set Authorization header with JWT token
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginResult.Token}");

        // Create a product for this user's shop to ensure there's data to return
        var productDto = _productHelper.CreateProductBuilder().Build();
        var createResponse = await Client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        createResponse.EnsureSuccessStatusCode();
        var createdProduct = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
        createdProduct.ShouldNotBeNull();

        // Act - Call the authenticated GET endpoint
        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");

        // Assert - Should return OK with products
        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        var productList = await getResponse.Content.ReadFromJsonAsync<Application.Common.PagedList<ProductDto>>();
        productList.ShouldNotBeNull();
        productList!.Items.ShouldNotBeNull();
        Output.WriteLine($"Retrieved {productList.Items.Count} products for user's shop");
        Output.WriteLine($"Total count: {productList.TotalCount}");
        
        // Verify that all returned products belong to the user's shop
        foreach (var product in productList.Items)
        {
            product.ShopId.ShouldBe("1"); // wadmin belongs to shop 1
        }
    }

    [Fact]
    public async Task Unauthenticated_GetAllProducts_ShouldReturnUnauthorized()
    {
        // Arrange - Clear any auth headers
        Client.DefaultRequestHeaders.Clear();

        // Act - Call the GET endpoint without authentication
        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");

        // Assert - Should return Unauthorized due to [Authorize] attribute
        getResponse.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
    }
}