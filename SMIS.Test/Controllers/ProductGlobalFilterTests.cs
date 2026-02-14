using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ProductGlobalFilterTests : BaseIntegrationTest
{
    private readonly ProductTestDataHelper _dataHelper;

    public ProductGlobalFilterTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("superadmin@smis.com");
        await _dataHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task SuperAdmin_CanSeeAllShopsProducts()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("superadmin@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "SuperAdmin_GetAllProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        var shopIds = paged!.Items.Select(p => p.ShopId).Distinct().ToList();
        Output.WriteLine($"SuperAdmin sees products from {shopIds.Count} shop(s): {string.Join(", ", shopIds)}");
        
        shopIds.Count.ShouldBeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public async Task WholesaleAdmin_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("wadmin@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "WholesaleAdmin_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "1", "All products should belong to ShopId=1");
        Output.WriteLine($"WholesaleAdmin sees {paged.Items.Count} products from Shop 1");
    }

    [Fact]
    public async Task RetailAdmin_OnlySeesShop2Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("radmin@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "RetailAdmin_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "2", "All products should belong to ShopId=2");
        Output.WriteLine($"RetailAdmin sees {paged.Items.Count} products from Shop 2");
    }

    [Fact]
    public async Task WholesaleManager_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("wmanager@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "WholesaleManager_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "1");
    }

    [Fact]
    public async Task WholesaleStaff_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("wstaff@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "WholesaleStaff_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "1");
    }

    [Fact]
    public async Task WholesaleViewer_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("wviewer@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "WholesaleViewer_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "1");
    }

    [Fact]
    public async Task RetailManager_OnlySeesShop2Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("rmanager@smis.com");

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, "RetailManager_GetProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == "2");
    }

    [Fact]
    public async Task WholesaleAdmin_CannotAccessShop2ProductById()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("superadmin@smis.com");
        
        var shop2Products = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=1");
        var paged = await shop2Products.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        
        if (paged?.Items.Any(p => p.ShopId == "2") != true)
        {
            Output.WriteLine("No Shop 2 products found, skipping test");
            return;
        }

        var shop2ProductId = paged.Items.First(p => p.ShopId == "2").Id;

        await TokenHelper.SetAuthorizationHeaderAsync("wadmin@smis.com");
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/{shop2ProductId}");
        await LogIfError(response, "WholesaleAdmin_AccessShop2Product");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task RetailAdmin_CannotAccessShop1ProductById()
    {
        await TokenHelper.SetAuthorizationHeaderAsync("superadmin@smis.com");
        
        var shop1Products = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=1");
        var paged = await shop1Products.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        
        if (paged?.Items.Any(p => p.ShopId == "1") != true)
        {
            Output.WriteLine("No Shop 1 products found, skipping test");
            return;
        }

        var shop1ProductId = paged.Items.First(p => p.ShopId == "1").Id;

        await TokenHelper.SetAuthorizationHeaderAsync("radmin@smis.com");
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/{shop1ProductId}");
        await LogIfError(response, "RetailAdmin_AccessShop1Product");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task AllNonSuperAdminRoles_SeeSameDataForTheirShop()
    {
        var wholesaleRoles = new[]
        {
            ("wadmin@smis.com", "WShopAdmin"),
            ("wmanager@smis.com", "WShopManager"),
            ("wstaff@smis.com", "WShopStaff"),
            ("wviewer@smis.com", "WShopViewer")
        };

        var productCounts = new Dictionary<string, int>();

        foreach (var (email, roleName) in wholesaleRoles)
        {
            await TokenHelper.SetAuthorizationHeaderAsync(email);
            var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
            
            var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            productCounts[roleName] = paged!.TotalCount;
            
            Output.WriteLine($"{roleName} sees {paged.TotalCount} products");
        }

        var distinctCounts = productCounts.Values.Distinct().ToList();
        distinctCounts.Count.ShouldBe(1, "All roles in same shop should see same number of products");
    }
}
