using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ShopIntegrationTests : BaseIntegrationTest
{
    private readonly ShopTestDataHelper _dataHelper;

    public ShopIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ShopTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<ShopDto> CreateShopAsync(ShopCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Shop, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ShopDto>())!;
    }

    private async Task<HttpResponseMessage> CreateShopResponseAsync(ShopCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Shop, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateShopResponseAsync(string shopId, ShopCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Shop}/{shopId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertShopMatches(ShopDto actual, ShopCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.Name.ShouldBe(expected.Name);
        actual.ShopType.ShouldBe(expected.ShopType);
        actual.Address.ShouldBe(expected.Address);
        actual.PhoneNumber.ShouldBe(expected.PhoneNumber);
        actual.Email.ToLower().ShouldBe(expected.Email.ToLower());
        actual.TaxNumber.ShouldBe(expected.TaxNumber);
        actual.IsActive.ShouldBe(expected.IsActive);
    }

    [Fact]
    public async Task Post_CreateValidShop_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder().Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateValidShop");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        AssertShopMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateShopWithEmptyAddress_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder().Build();
        dto.Address = "";

        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithEmptyAddress");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        created.ShouldNotBeNull();
        created!.Address.ShouldBe("");
    }

    [Fact]
    public async Task Get_ListShops_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Shop}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListShops");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListShops_WithPagination_ReturnsCorrectPage()
    {
        var shops = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateShopBuilder().Build())
            .ToArray();

        foreach (var shop in shops)
        {
            await CreateShopAsync(shop, $"CreateTestShop_{shop.Name}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Shop}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListShops_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ShopById_Existing_ReturnsShop()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Get_ShopById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Shop}/{created!.Id}");
        await LogIfError(getResponse, "Get_ShopById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ShopDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertShopMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ShopById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Shop}/non-existing-id");
        await LogIfError(response, "Get_ShopById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingShop_ReturnsUpdatedShop()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShop_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateShopResponseAsync(created!.Id, updateDto, "Put_UpdateShop_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertShopMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingShop_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateShopBuilder().Build();
        var response = await UpdateShopResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingShop");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingShop_ReturnsOk()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Delete_ExistingShop_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Shop}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingShop_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Shop}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingShop_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Shop}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingShop");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateShopWithEmptyName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopBuilder().WithName("").Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithEmptyName");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateShopWithInvalidEmail_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopBuilder().WithEmail("invalid-email").Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithInvalidEmail");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateShopWithInvalidPhoneNumber_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopBuilder().WithPhoneNumber("123").Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithInvalidPhoneNumber");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Put_UpdateShopToInactive_ReturnsInactiveShop()
    {
        var createDto = _dataHelper.CreateShopBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShopToInactive_Seed");
        created.ShouldNotBeNull();
        created!.IsActive.ShouldBeTrue();

        var updateDto = _dataHelper.CreateShopBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateShopResponseAsync(created.Id, updateDto, "Put_UpdateShopToInactive_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.ShouldNotBeNull();
        updated!.IsActive.ShouldBeFalse();
    }

    [Fact]
    public async Task Get_ListShops_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Shop}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListShops_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleShops_AllSucceed()
    {
        var shops = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateShopBuilder().Build())
            .ToList();

        foreach (var shop in shops)
        {
            var response = await CreateShopResponseAsync(shop, $"Post_CreateMultipleShops_{shop.Name}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Post_CreateShopWithRetailShopType_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder().WithShopType(ShopType.RetailShop).Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithRetailShopType");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        created.ShouldNotBeNull();
        created!.ShopType.ShouldBe(ShopType.RetailShop);
    }

    [Fact]
    public async Task Post_CreateShopWithWholesaleShopType_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder().WithShopType(ShopType.WholesaleShop).Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithWholesaleShopType");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        created.ShouldNotBeNull();
        created!.ShopType.ShouldBe(ShopType.WholesaleShop);
    }

    [Fact]
    public async Task Put_UpdateShopName_ReturnsUpdatedName()
    {
        var createDto = _dataHelper.CreateShopBuilder().WithName("Old Shop Name").Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShopName_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopBuilder().WithName("New Shop Name").Build();
        var updateResponse = await UpdateShopResponseAsync(created!.Id, updateDto, "Put_UpdateShopName_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.ShouldNotBeNull();
        updated!.Name.ShouldBe("New Shop Name");
    }

    [Fact]
    public async Task Put_UpdateShopAddress_ReturnsUpdatedAddress()
    {
        var createDto = _dataHelper.CreateShopBuilder().WithAddress("Old Address").Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShopAddress_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopBuilder().WithAddress("New Address").Build();
        var updateResponse = await UpdateShopResponseAsync(created!.Id, updateDto, "Put_UpdateShopAddress_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.ShouldNotBeNull();
        updated!.Address.ShouldBe("New Address");
    }
}
