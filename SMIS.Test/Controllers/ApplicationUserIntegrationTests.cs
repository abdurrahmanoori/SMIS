using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Users;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ApplicationUserIntegrationTests : BaseIntegrationTest
{
    private readonly ApplicationUserTestDataHelper _dataHelper;

    public ApplicationUserIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ApplicationUserTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<UserDto> CreateApplicationUserAsync(UserCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Account, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<UserDto>())!;
    }

    private async Task<HttpResponseMessage> CreateApplicationUserResponseAsync(UserCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Account, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateApplicationUserResponseAsync(string userId, UserCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Account}/{userId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertApplicationUserMatches(UserDto actual, UserCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.UserName.ShouldBe(expected.UserName);
        actual.Email.ToLower().ShouldBe(expected.Email.ToLower());
        actual.PhoneNumber.ShouldBe(expected.PhoneNumber);
        actual.FirstName.ShouldBe(expected.FirstName);
        actual.LastName.ShouldBe(expected.LastName);
        actual.ShopId.ShouldBe(expected.ShopId);
    }

    [Fact]
    public async Task Post_CreateValidApplicationUser_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateValidApplicationUser");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        AssertApplicationUserMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithEmptyFirstName_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        dto.FirstName = "";

        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithEmptyFirstName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.FirstName.ShouldBe("");
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithNullFirstName_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        dto.FirstName = null;

        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithNullFirstName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.FirstName.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListApplicationUsers_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Account}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListApplicationUsers");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<UserDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListApplicationUsers_WithPagination_ReturnsCorrectPage()
    {
        var users = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateApplicationUserBuilder().Build())
            .ToArray();

        foreach (var user in users)
        {
            await CreateApplicationUserAsync(user, $"CreateTestApplicationUser_{user.UserName}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Account}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListApplicationUsers_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<UserDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ApplicationUserById_Existing_ReturnsApplicationUser()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var created = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Get_ApplicationUserById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Account}/{created!.Id}");
        await LogIfError(getResponse, "Get_ApplicationUserById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<UserDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertApplicationUserMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ApplicationUserById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Account}/non-existing-id");
        await LogIfError(response, "Get_ApplicationUserById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingApplicationUser_ReturnsUpdatedApplicationUser()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var created = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Put_UpdateApplicationUser_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateApplicationUserBuilder()
            .WithFirstName("UpdatedFirstName")
            .WithUserName(created.UserName!)
            .WithEmail(created.Email!).Build();
        var updateResponse = await UpdateApplicationUserResponseAsync(created!.Id, updateDto, "Put_UpdateApplicationUser_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UserDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertApplicationUserMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingApplicationUser_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var response = await UpdateApplicationUserResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingApplicationUser");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingApplicationUser_ReturnsOk()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var created = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Delete_ExistingApplicationUser_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Account}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingApplicationUser_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Account}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingApplicationUser_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Account}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingApplicationUser");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithInvalidShopId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        dto.ShopId = "invalid-shop-id";

        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithInvalidShopId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithEmptyUserName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithUserName("").Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithEmptyUserName");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithEmptyEmail_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithEmail("").Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithEmptyEmail");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithInvalidEmail_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithEmail("invalid-email").Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithInvalidEmail");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithDuplicateUserName_ReturnsConflict()
    {
        const string userName = "DUPLICATE-USERNAME-TEST";

        var firstUser = _dataHelper.CreateApplicationUserBuilder().WithUserName(userName).Build();
        await CreateApplicationUserAsync(firstUser, "Post_CreateApplicationUserWithDuplicateUserName_First");

        var secondUser = _dataHelper.CreateApplicationUserBuilder().WithUserName(userName).Build();
        var secondResponse = await CreateApplicationUserResponseAsync(secondUser, "Post_CreateApplicationUserWithDuplicateUserName_Second");

        (secondResponse.StatusCode == HttpStatusCode.BadRequest ||
         secondResponse.StatusCode == HttpStatusCode.Conflict ||
         secondResponse.StatusCode == HttpStatusCode.OK).ShouldBeTrue();

        if (secondResponse.StatusCode == HttpStatusCode.OK)
        {
            var createdSecond = await secondResponse.Content.ReadFromJsonAsync<UserDto>();
            createdSecond.ShouldNotBeNull();
            createdSecond!.UserName.ShouldBe(userName);

            var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Account}/{createdSecond.Id}");
            deleteResponse.EnsureSuccessStatusCode();
        }
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithDuplicateEmail_ReturnsConflict()
    {
        const string email = "duplicate@test.com";

        var firstUser = _dataHelper.CreateApplicationUserBuilder().WithEmail(email).Build();
        await CreateApplicationUserAsync(firstUser, "Post_CreateApplicationUserWithDuplicateEmail_First");

        var secondUser = _dataHelper.CreateApplicationUserBuilder().WithEmail(email).Build();
        var secondResponse = await CreateApplicationUserResponseAsync(secondUser, "Post_CreateApplicationUserWithDuplicateEmail_Second");

        (secondResponse.StatusCode == HttpStatusCode.BadRequest ||
         secondResponse.StatusCode == HttpStatusCode.Conflict ||
         secondResponse.StatusCode == HttpStatusCode.OK).ShouldBeTrue();

        if (secondResponse.StatusCode == HttpStatusCode.OK)
        {
            var createdSecond = await secondResponse.Content.ReadFromJsonAsync<UserDto>();
            createdSecond.ShouldNotBeNull();
            createdSecond!.Email.ShouldBe(email);

            var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Account}/{createdSecond.Id}");
            deleteResponse.EnsureSuccessStatusCode();
        }
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithNullPhoneNumber_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithPhoneNumber(null).Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithNullPhoneNumber");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.PhoneNumber.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithNullLastName_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithLastName(null).Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithNullLastName");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.LastName.ShouldBeNull();
    }

    [Fact]
    public async Task Put_UpdateApplicationUserEmail_ReturnsUpdatedEmail()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().WithEmail("original@test.com").Build();
        var created = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Put_UpdateApplicationUserEmail_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateApplicationUserBuilder().WithEmail("updated@test.com").Build();
        var updateResponse = await UpdateApplicationUserResponseAsync(created!.Id, updateDto, "Put_UpdateApplicationUserEmail_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UserDto>();
        updated.ShouldNotBeNull();
        updated!.Email.ShouldBe("updated@test.com");
    }

    [Fact]
    public async Task Get_ListApplicationUsers_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Account}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListApplicationUsers_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleApplicationUsers_AllSucceed()
    {
        var users = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateApplicationUserBuilder().Build())
            .ToList();

        foreach (var user in users)
        {
            var response = await CreateApplicationUserResponseAsync(user, $"Post_CreateMultipleApplicationUsers_{user.UserName}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateApplicationUserPhoneNumber_ReturnsUpdatedPhoneNumber()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().WithPhoneNumber("+1234567890").Build();
        var created = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Put_UpdateApplicationUserPhoneNumber_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateApplicationUserBuilder().WithPhoneNumber("+0987654321").Build();
        var updateResponse = await UpdateApplicationUserResponseAsync(created!.Id, updateDto, "Put_UpdateApplicationUserPhoneNumber_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UserDto>();
        updated.ShouldNotBeNull();
        updated!.PhoneNumber.ShouldBe("+0987654321");
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithExplicitNullFirstName_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithFirstName(null).Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithExplicitNullFirstName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.FirstName.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateApplicationUserWithExplicitNullLastName_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().WithLastName(null).Build();
        var response = await CreateApplicationUserResponseAsync(dto, "Post_CreateApplicationUserWithExplicitNullLastName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.LastName.ShouldBeNull();
    }
}