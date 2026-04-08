using System.Net;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
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
        await TokenHelper.SetAuthorizationHeaderAsync();
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
        actual.Should().NotBeNull();
        actual.Name.Should().Be(expected.Name);
        actual.ShopType.Should().Be(expected.ShopType);
        actual.Address.Should().Be(expected.Address);
        actual.PhoneNumber.Should().Be(expected.PhoneNumber);
        actual.Email.Should().Be(expected.Email);
        actual.TaxNumber.Should().Be(expected.TaxNumber);
        actual.IsActive.Should().Be(expected.IsActive);
    }

    [Fact]
    public async Task Post_CreateValidShop_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder().Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateValidShop");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        AssertShopMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateShopWithEmptyName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopBuilder().WithName("").Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithEmptyName");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateShopWithNullOptionalFields_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder()
            .WithAddress(null)
            .WithPhoneNumber(null)
            .WithEmail(null)
            .WithTaxNumber(null)
            .Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithNullOptionalFields");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        created.Should().NotBeNull();
        created!.Address.Should().BeNull();
        created.PhoneNumber.Should().BeNull();
        created.Email.Should().BeNull();
        created.TaxNumber.Should().BeNull();
    }

    [Fact]
    public async Task Post_CreateShopWithEmptyOptionalFields_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopBuilder()
            .WithAddress("")
            .WithPhoneNumber("")
            .WithEmail("")
            .WithTaxNumber("")
            .Build();
        var response = await CreateShopResponseAsync(dto, "Post_CreateShopWithEmptyOptionalFields");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopDto>();
        created.Should().NotBeNull();
        created!.Address.Should().Be("");
        created.PhoneNumber.Should().Be("");
        created.Email.Should().Be("");
        created.TaxNumber.Should().Be("");
    }

    [Fact]
    public async Task Get_ListShops_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Shop}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListShops");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Should().NotBeNull();
        paged.Items.Count.Should().BeGreaterOrEqualTo(0);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(10);
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

        paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Count.Should().BeLessOrEqualTo(2);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(2);
        paged.TotalCount.Should().BeGreaterOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ShopById_Existing_ReturnsShop()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Get_ShopById_Seed");
        created.Should().NotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Shop}/{created!.Id}");
        await LogIfError(getResponse, "Get_ShopById_Get");

        getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ShopDto>();
        retrieved.Should().NotBeNull();
        retrieved!.Id.Should().Be(created.Id);
        AssertShopMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ShopById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Shop}/non-existing-id");
        await LogIfError(response, "Get_ShopById_NonExisting");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingShop_ReturnsUpdatedShop()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShop_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateShopBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateShopResponseAsync(created!.Id, updateDto, "Put_UpdateShop_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.Should().NotBeNull();
        updated!.Id.Should().Be(created.Id);
        AssertShopMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingShop_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateShopBuilder().Build();
        var response = await UpdateShopResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingShop");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateShopName_ReturnsUpdatedName()
    {
        var createDto = _dataHelper.CreateShopBuilder().WithName("Original Shop").Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Put_UpdateShopName_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateShopBuilder().WithName("Updated Shop").Build();
        var updateResponse = await UpdateShopResponseAsync(created!.Id, updateDto, "Put_UpdateShopName_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopDto>();
        updated.Should().NotBeNull();
        updated!.Name.Should().Be("Updated Shop");
    }

    [Fact]
    public async Task Delete_ExistingShop_ReturnsOk()
    {
        var createDto = _dataHelper.CreateShopBuilder().Build();
        var created = await PostAndGetAsync<ShopDto>(ApiEndpoints.Shop, createDto, "Delete_ExistingShop_Seed");
        created.Should().NotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Shop}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingShop_Delete");

        deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Shop}/{created.Id}");
        getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingShop_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Shop}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingShop");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
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
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
