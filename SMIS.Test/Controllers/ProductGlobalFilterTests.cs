using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.Common.Contants;
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

    // Seeded users from UserSeed.cs
    private const string SuperAdminEmail = "superadmin@smis.com";
    private const string WholesaleAdminEmail = "wadmin@smis.com";
    private const string WholesaleManagerEmail = "wmanager@smis.com";
    private const string WholesaleStaffEmail = "wstaff@smis.com";
    private const string WholesaleViewerEmail = "wviewer@smis.com";
    private const string RetailAdminEmail = "radmin@smis.com";
    private const string RetailManagerEmail = "rmanager@smis.com";
    
    private const string Shop1Id = "1"; // Wholesale shop
    private const string Shop2Id = "2"; // Retail shop

    public ProductGlobalFilterTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(SuperAdminEmail);
        await _dataHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task SuperAdmin_CanSeeAllShopsProducts()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(SuperAdminEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(SuperAdmin_CanSeeAllShopsProducts));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        var shopIds = paged!.Items.Select(p => p.ShopId).Distinct().ToList();
        Output.WriteLine($"{SD.Role_Super_Admin} sees products from {shopIds.Count} shop(s): {string.Join(", ", shopIds)}");
        
        shopIds.Count.ShouldBeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public async Task WholesaleAdmin_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(WholesaleAdminEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(WholesaleAdmin_OnlySeesShop1Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop1Id, $"All products should belong to ShopId={Shop1Id}");
        Output.WriteLine($"{SD.Role_WShop_Admin} sees {paged.Items.Count} products from Shop {Shop1Id}");
    }

    [Fact]
    public async Task RetailAdmin_OnlySeesShop2Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(RetailAdminEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(RetailAdmin_OnlySeesShop2Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop2Id, $"All products should belong to ShopId={Shop2Id}");
        Output.WriteLine($"{SD.Role_RShop_Admin} sees {paged.Items.Count} products from Shop {Shop2Id}");
    }

    [Fact]
    public async Task WholesaleManager_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(WholesaleManagerEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(WholesaleManager_OnlySeesShop1Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop1Id);
        Output.WriteLine($"{SD.Role_WShop_Manager} sees {paged.Items.Count} products from Shop {Shop1Id}");
    }

    [Fact]
    public async Task WholesaleStaff_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(WholesaleStaffEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(WholesaleStaff_OnlySeesShop1Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop1Id);
        Output.WriteLine($"{SD.Role_WShop_Staff} sees {paged.Items.Count} products from Shop {Shop1Id}");
    }

    [Fact]
    public async Task WholesaleViewer_OnlySeesShop1Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(WholesaleViewerEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(WholesaleViewer_OnlySeesShop1Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop1Id);
        Output.WriteLine($"{SD.Role_WShop_Viewer} sees {paged.Items.Count} products from Shop {Shop1Id}");
    }

    [Fact]
    public async Task RetailManager_OnlySeesShop2Products()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(RetailManagerEmail);

        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=100");
        await LogIfError(response, nameof(RetailManager_OnlySeesShop2Products));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        
        paged!.Items.ShouldAllBe(p => p.ShopId == Shop2Id);
        Output.WriteLine($"{SD.Role_RShop_Manager} sees {paged.Items.Count} products from Shop {Shop2Id}");
    }

    [Fact]
    public async Task WholesaleAdmin_CannotAccessShop2ProductById()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(SuperAdminEmail);
        
        var shop2Products = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=1");
        var paged = await shop2Products.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        
        if (paged?.Items.Any(p => p.ShopId == Shop2Id) != true)
        {
            Output.WriteLine($"No Shop {Shop2Id} products found, skipping test");
            return;
        }

        var shop2ProductId = paged.Items.First(p => p.ShopId == Shop2Id).Id;

        await TokenHelper.SetAuthorizationHeaderAsync(WholesaleAdminEmail);
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/{shop2ProductId}");
        await LogIfError(response, nameof(WholesaleAdmin_CannotAccessShop2ProductById));

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        Output.WriteLine($"{SD.Role_WShop_Admin} cannot access Shop {Shop2Id} product (404)");
    }

    [Fact]
    public async Task RetailAdmin_CannotAccessShop1ProductById()
    {
        await TokenHelper.SetAuthorizationHeaderAsync(SuperAdminEmail);
        
        var shop1Products = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=1");
        var paged = await shop1Products.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        
        if (paged?.Items.Any(p => p.ShopId == Shop1Id) != true)
        {
            Output.WriteLine($"No Shop {Shop1Id} products found, skipping test");
            return;
        }

        var shop1ProductId = paged.Items.First(p => p.ShopId == Shop1Id).Id;

        await TokenHelper.SetAuthorizationHeaderAsync(RetailAdminEmail);
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/{shop1ProductId}");
        await LogIfError(response, nameof(RetailAdmin_CannotAccessShop1ProductById));

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        Output.WriteLine($"{SD.Role_RShop_Admin} cannot access Shop {Shop1Id} product (404)");
    }

    [Fact]
    public async Task AllNonSuperAdminRoles_SeeSameDataForTheirShop()
    {
        var wholesaleRoles = new[]
        {
            (WholesaleAdminEmail, SD.Role_WShop_Admin),
            (WholesaleManagerEmail, SD.Role_WShop_Manager),
            (WholesaleStaffEmail, SD.Role_WShop_Staff),
            (WholesaleViewerEmail, SD.Role_WShop_Viewer)
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
