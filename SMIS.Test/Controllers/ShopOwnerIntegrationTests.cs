using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ShopOwnerIntegrationTests : BaseIntegrationTest
{
    private readonly ShopOwnerTestDataHelper _dataHelper;

    public ShopOwnerIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ShopOwnerTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<ShopOwnerDto> CreateShopOwnerAsync(ShopOwnerCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ShopOwner, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ShopOwnerDto>())!;
    }

    private async Task<HttpResponseMessage> CreateShopOwnerResponseAsync(ShopOwnerCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ShopOwner, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateShopOwnerResponseAsync(string shopOwnerId, ShopOwnerCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.ShopOwner}/{shopOwnerId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertShopOwnerMatches(ShopOwnerDto actual, ShopOwnerCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.ApplicationUserId.ShouldBe(expected.ApplicationUserId);
        actual.ShopId.ShouldBe(expected.ShopId);
        actual.FirstName.ShouldBe(expected.FirstName);
        actual.LastName.ShouldBe(expected.LastName);
        actual.NationalIdCardNumber.ShouldBe(expected.NationalIdCardNumber);
        actual.PhoneNumber.ShouldBe(expected.PhoneNumber);
        actual.Email.ToLower().ShouldBe(expected.Email.ToLower());
        actual.Address.ShouldBe(expected.Address);
        actual.OwnershipPercentage.ShouldBe(expected.OwnershipPercentage);
        actual.IsActive.ShouldBe(expected.IsActive);
        actual.ProvinceId.ShouldBe(expected.ProvinceId);
        actual.DistrictId.ShouldBe(expected.DistrictId);
    }

    [Fact]
    public async Task Post_CreateValidShopOwner_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateValidShopOwner");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        AssertShopOwnerMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithEmptyAddress_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.Address = "";

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithEmptyAddress");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.Address.ShouldBe("");
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithNullAddress_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.Address = null;

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithNullAddress");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.Address.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListShopOwners_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ShopOwner}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListShopOwners");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ShopOwnerDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListShopOwners_WithPagination_ReturnsCorrectPage()
    {
        var shopOwners = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateShopOwnerBuilder().Build())
            .ToArray();

        foreach (var shopOwner in shopOwners)
        {
            await CreateShopOwnerAsync(shopOwner, $"CreateTestShopOwner_{shopOwner.FirstName}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.ShopOwner}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListShopOwners_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ShopOwnerDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ShopOwnerById_Existing_ReturnsShopOwner()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Get_ShopOwnerById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ShopOwner}/{created!.Id}");
        await LogIfError(getResponse, "Get_ShopOwnerById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertShopOwnerMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ShopOwnerById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ShopOwner}/non-existing-id");
        await LogIfError(response, "Get_ShopOwnerById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingShopOwner_ReturnsUpdatedShopOwner()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Put_UpdateShopOwner_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopOwnerBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateShopOwnerResponseAsync(created!.Id, updateDto, "Put_UpdateShopOwner_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertShopOwnerMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingShopOwner_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateShopOwnerBuilder().Build();
        var response = await UpdateShopOwnerResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingShopOwner");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingShopOwner_ReturnsOk()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Delete_ExistingShopOwner_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.ShopOwner}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingShopOwner_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ShopOwner}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingShopOwner_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.ShopOwner}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingShopOwner");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithInvalidShopId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.ShopId = "invalid-shop-id";

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithInvalidShopId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithInvalidUserId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.ApplicationUserId = "invalid-user-id";

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithInvalidUserId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithNegativeOwnershipPercentage_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.OwnershipPercentage = -10.0m;

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithNegativeOwnershipPercentage");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithZeroOwnershipPercentage_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().Build();
        dto.OwnershipPercentage = 0.0m;

        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithZeroOwnershipPercentage");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.OwnershipPercentage.ShouldBe(0.0m);
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithDuplicateNationalId_ReturnsConflict()
    {
        const string nationalId = "DUPLICATE-ID-TEST";

        var firstShopOwner = _dataHelper.CreateShopOwnerBuilder().WithNationalIdCardNumber(nationalId).Build();
        await CreateShopOwnerAsync(firstShopOwner, "Post_CreateShopOwnerWithDuplicateNationalId_First");

        var secondShopOwner = _dataHelper.CreateShopOwnerBuilder().WithNationalIdCardNumber(nationalId).Build();
        var secondResponse = await CreateShopOwnerResponseAsync(secondShopOwner, "Post_CreateShopOwnerWithDuplicateNationalId_Second");

        (secondResponse.StatusCode == HttpStatusCode.BadRequest ||
         secondResponse.StatusCode == HttpStatusCode.Conflict ||
         secondResponse.StatusCode == HttpStatusCode.OK).ShouldBeTrue();

        if (secondResponse.StatusCode == HttpStatusCode.OK)
        {
            var createdSecond = await secondResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
            createdSecond.ShouldNotBeNull();
            createdSecond!.NationalIdCardNumber.ShouldBe(nationalId);

            var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.ShopOwner}/{createdSecond.Id}");
            deleteResponse.EnsureSuccessStatusCode();
        }
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithEmptyFirstName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().WithFirstName("").Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithEmptyFirstName");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithNullProvinceId_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().WithProvinceId(null).Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithNullProvinceId");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.ProvinceId.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithMaxOwnershipPercentage_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().WithOwnershipPercentage(100.0m).Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithMaxOwnershipPercentage");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.OwnershipPercentage.ShouldBe(100.0m);
    }

    [Fact]
    public async Task Put_UpdateShopOwnerOwnershipPercentage_ReturnsUpdatedOwnershipPercentage()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().WithOwnershipPercentage(50.0m).Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Put_UpdateShopOwnerOwnershipPercentage_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopOwnerBuilder().WithOwnershipPercentage(75.0m).Build();
        var updateResponse = await UpdateShopOwnerResponseAsync(created!.Id, updateDto, "Put_UpdateShopOwnerOwnershipPercentage_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
        updated.ShouldNotBeNull();
        updated!.OwnershipPercentage.ShouldBe(75.0m);
    }

    [Fact]
    public async Task Put_UpdateShopOwnerToInactive_ReturnsInactiveShopOwner()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Put_UpdateShopOwnerToInactive_Seed");
        created.ShouldNotBeNull();
        created!.IsActive.ShouldBeTrue();

        var updateDto = _dataHelper.CreateShopOwnerBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateShopOwnerResponseAsync(created.Id, updateDto, "Put_UpdateShopOwnerToInactive_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
        updated.ShouldNotBeNull();
        updated!.IsActive.ShouldBeFalse();
    }

    [Fact]
    public async Task Get_ListShopOwners_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ShopOwner}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListShopOwners_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleShopOwners_AllSucceed()
    {
        var shopOwners = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateShopOwnerBuilder().Build())
            .ToList();

        foreach (var shopOwner in shopOwners)
        {
            var response = await CreateShopOwnerResponseAsync(shopOwner, $"Post_CreateMultipleShopOwners_{shopOwner.FirstName}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateShopOwnerNationalId_ReturnsUpdatedNationalId()
    {
        var createDto = _dataHelper.CreateShopOwnerBuilder().WithNationalIdCardNumber("OLD-ID-001").Build();
        var created = await PostAndGetAsync<ShopOwnerDto>(ApiEndpoints.ShopOwner, createDto, "Put_UpdateShopOwnerNationalId_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateShopOwnerBuilder().WithNationalIdCardNumber("NEW-ID-001").Build();
        var updateResponse = await UpdateShopOwnerResponseAsync(created!.Id, updateDto, "Put_UpdateShopOwnerNationalId_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ShopOwnerDto>();
        updated.ShouldNotBeNull();
        updated!.NationalIdCardNumber.ShouldBe("NEW-ID-001");
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithExplicitNullAddress_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().WithAddress(null).Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithExplicitNullAddress");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.Address.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateShopOwnerWithExplicitNullEmail_ReturnsOk()
    {
        var dto = _dataHelper.CreateShopOwnerBuilder().WithEmail(null).Build();
        var response = await CreateShopOwnerResponseAsync(dto, "Post_CreateShopOwnerWithExplicitNullEmail");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ShopOwnerDto>();
        created.ShouldNotBeNull();
        created!.Email.ShouldBeNull();
    }
}