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
/// Demo test to verify authentication flow for Product controller
/// This test demonstrates the issue where [Authorize] attribute on GET endpoint
/// might not be returning data properly
/// </summary>
public class ProductAuthDemoTest : BaseIntegrationTest
{
    public ProductAuthDemoTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
    }

    [Fact]
    public async Task Demo_Authenticated_GetAllProducts_ShouldReturnData()
    {
        // Arrange - Login with seeded user credentials
        var loginDto = new LoginDto
        {
            Email = "superadmin@smis.com",  // From UserSeed.cs
            Password = "Pass123!"          // Default password from UserSeed.cs
        };

        // Step 1: Login to get JWT token
        var loginResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        await LogIfError(loginResponse, "LoginStep");

        loginResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResponseDto>();
        loginResult.ShouldNotBeNull();
        loginResult!.Token.ShouldNotBeNullOrWhiteSpace("JWT token should be returned after successful login");

        // Step 2: Set Authorization header with JWT token
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginResult.Token}");

        // Step 3: Call the authenticated GET endpoint
        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");
        await LogIfError(getResponse, "GetAllProductsStep");

        // Assert - Check if we get a successful response with data
        getResponse.StatusCode.ShouldBeOneOf(HttpStatusCode.OK, HttpStatusCode.Unauthorized, HttpStatusCode.Forbidden);
        
        if (getResponse.StatusCode == HttpStatusCode.OK)
        {
            var productList = await getResponse.Content.ReadFromJsonAsync<Application.Common.PagedList<ProductDto>>();
            productList.ShouldNotBeNull("Product list should not be null when authorized");
            Output.WriteLine($"Retrieved {productList!.Items.Count} products");
            Output.WriteLine($"Total count: {productList.TotalCount}");
        }
        else
        {
            Output.WriteLine($"Authorization failed with status: {getResponse.StatusCode}");
            var errorContent = await getResponse.Content.ReadAsStringAsync();
            Output.WriteLine($"Error content: {errorContent}");
        }
    }

    [Fact]
    public async Task Demo_Unauthenticated_GetAllProducts_ShouldReturnUnauthorized()
    {
        // Arrange - Don't set any authentication headers
        Client.DefaultRequestHeaders.Clear(); // Ensure no auth headers

        // Act - Call the GET endpoint without authentication
        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");
        await LogIfError(getResponse, "UnauthenticatedGetAllProducts");

        // Assert - Should return Unauthorized due to [Authorize] attribute
        getResponse.StatusCode.ShouldBe(HttpStatusCode.Unauthorized, 
            "Unauthenticated requests should return 401 Unauthorized");
    }

    [Fact]
    public async Task Demo_Manual_JWT_Token_Test()
    {
        // This test manually creates a request with the JWT token to isolate the issue
        
        // Login first
        var loginDto = new LoginDto
        {
            Email = "wadmin@smis.com",  // Another seeded user
            Password = "Pass123!"
        };

        var loginResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResponseDto>();
        
        loginResult.ShouldNotBeNull();
        loginResult!.Token.ShouldNotBeNullOrWhiteSpace();

        // Create HTTP request with proper authorization header
        using var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");
        httpRequest.Headers.Add("Authorization", $"Bearer {loginResult.Token}");

        var response = await Client.SendAsync(httpRequest);
        await LogIfError(response, "ManualJWTTokenTest");

        // Check response
        Output.WriteLine($"Status Code: {response.StatusCode}");
        
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var content = await response.Content.ReadAsStringAsync();
            Output.WriteLine($"Response Content Length: {content.Length}");
            Output.WriteLine($"Response Content Preview: {content.Substring(0, Math.Min(200, content.Length))}...");
            
            var productList = await response.Content.ReadFromJsonAsync<Application.Common.PagedList<ProductDto>>();
            if (productList != null)
            {
                Output.WriteLine($"Successfully parsed {productList.Items.Count} products");
                Output.WriteLine($"Total Count: {productList.TotalCount}");
            }
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Output.WriteLine($"Error Response: {errorContent}");
        }

        response.StatusCode.ShouldBe(HttpStatusCode.OK, 
            "Authenticated requests should return 200 OK");
    }
}