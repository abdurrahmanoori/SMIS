using System.Net;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class CategoryIntegrationTests : BaseIntegrationTest
{
    private readonly CategoryTestDataHelper _dataHelper;

    public CategoryIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new CategoryTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Category, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<CategoryDto>())!;
    }

    private async Task<HttpResponseMessage> CreateCategoryResponseAsync(CategoryCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Category, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateCategoryResponseAsync(string categoryId, CategoryCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Category}/{categoryId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertCategoryMatches(CategoryDto actual, CategoryCreateDto expected)
    {
        actual.Should().NotBeNull();
        actual.Name.Should().Be(expected.Name);
        actual.Code.Should().Be(expected.Code);
        actual.Description.Should().Be(expected.Description);
        actual.IsActive.Should().Be(expected.IsActive);
        //actual.ShopId.Should().Be(expected.ShopId);
    }

    [Fact]
    public async Task Post_CreateValidCategory_ReturnsOk()
    {
        var dto = _dataHelper.CreateCategoryBuilder().Build();
        var response = await CreateCategoryResponseAsync(dto, "Post_CreateValidCategory");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        AssertCategoryMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateCategoryWithEmptyDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateCategoryBuilder().Build();
        dto.Description = "";

        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithEmptyDescription");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Description.Should().Be("");
    }

    [Fact]
    public async Task Post_CreateCategoryWithNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateCategoryBuilder().Build();
        dto.Description = null;

        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithNullDescription");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Description.Should().BeNull();
    }

    [Fact]
    public async Task Get_ListCategories_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Category}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListCategories");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Should().NotBeNull();
        paged.Items.Count.Should().BeGreaterOrEqualTo(0);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(10);
    }

    [Fact]
    public async Task Get_ListCategories_WithPagination_ReturnsCorrectPage()
    {
        var categories = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateCategoryBuilder().Build())
            .ToArray();

        foreach (var cat in categories)
        {
            await CreateCategoryAsync(cat, $"CreateTestCategory_{cat.Name}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Category}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListCategories_Pagination");

        paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Count.Should().BeLessOrEqualTo(2);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(2);
        paged.TotalCount.Should().BeGreaterOrEqualTo(5);
    }

    [Fact]
    public async Task Get_CategoryById_Existing_ReturnsCategory()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Get_CategoryById_Seed");
        created.Should().NotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Category}/{created!.Id}");
        await LogIfError(getResponse, "Get_CategoryById_Get");

        getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<CategoryDto>();
        retrieved.Should().NotBeNull();
        retrieved!.Id.Should().Be(created.Id);
        AssertCategoryMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_CategoryById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Category}/non-existing-id");
        await LogIfError(response, "Get_CategoryById_NonExisting");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingCategory_ReturnsUpdatedCategory()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Put_UpdateCategory_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateCategoryBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateCategoryResponseAsync(created!.Id, updateDto, "Put_UpdateCategory_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CategoryDto>();
        updated.Should().NotBeNull();
        updated!.Id.Should().Be(created.Id);
        AssertCategoryMatches(updated, updateDto);
        updated.CreatedDate.Should().Be(created.CreatedDate);
        updated.CreatedBy.Should().Be(created.CreatedBy);
        updated.UpdatedDate.Should().NotBeNull();
        updated.UpdatedBy.Should().NotBeNullOrWhiteSpace();
        updated.LastModifiedUtc.Should().BeOnOrAfter(created.LastModifiedUtc);
    }

    [Fact]
    public async Task Put_UpdateNonExistingCategory_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateCategoryBuilder().Build();
        var response = await UpdateCategoryResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingCategory");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingCategory_ReturnsOk()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Delete_ExistingCategory_Seed");
        created.Should().NotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Category}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingCategory_Delete");

        deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Category}/{created.Id}");
        getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingCategory_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Category}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingCategory");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateCategoryWithEmptyName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateCategoryBuilder().WithName("").Build();
        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithEmptyName");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateCategoryWithNullCode_ReturnsOk()
    {
        var dto = _dataHelper.CreateCategoryBuilder().WithCode(null).Build();
        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithNullCode");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Code.Should().BeNull();
    }

    [Fact]
    public async Task Post_CreateCategoryWithEmptyCode_ReturnsOk()
    {
        var dto = _dataHelper.CreateCategoryBuilder().WithCode("").Build();
        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithEmptyCode");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Code.Should().Be("");
    }

    [Fact]
    public async Task Put_UpdateCategoryName_ReturnsUpdatedName()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().WithName("Original Name").Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Put_UpdateCategoryName_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateCategoryBuilder().WithName("Updated Name").Build();
        var updateResponse = await UpdateCategoryResponseAsync(created!.Id, updateDto, "Put_UpdateCategoryName_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CategoryDto>();
        updated.Should().NotBeNull();
        updated!.Name.Should().Be("Updated Name");
    }

    [Fact]
    public async Task Put_UpdateCategoryToInactive_ReturnsInactiveCategory()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Put_UpdateCategoryToInactive_Seed");
        created.Should().NotBeNull();
        created!.IsActive.Should().BeTrue();

        var updateDto = _dataHelper.CreateCategoryBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateCategoryResponseAsync(created.Id, updateDto, "Put_UpdateCategoryToInactive_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CategoryDto>();
        updated.Should().NotBeNull();
        updated!.IsActive.Should().BeFalse();
    }

    [Fact]
    public async Task Get_ListCategories_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Category}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListCategories_InvalidPageSize");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleCategories_AllSucceed()
    {
        var categories = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateCategoryBuilder().Build())
            .ToList();

        foreach (var category in categories)
        {
            var response = await CreateCategoryResponseAsync(category, $"Post_CreateMultipleCategories_{category.Name}");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateCategoryCode_ReturnsUpdatedCode()
    {
        var createDto = _dataHelper.CreateCategoryBuilder().WithCode("OLD-CODE").Build();
        var created = await PostAndGetAsync<CategoryDto>(ApiEndpoints.Category, createDto, "Put_UpdateCategoryCode_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateCategoryBuilder().WithCode("NEW-CODE").Build();
        var updateResponse = await UpdateCategoryResponseAsync(created!.Id, updateDto, "Put_UpdateCategoryCode_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CategoryDto>();
        updated.Should().NotBeNull();
        updated!.Code.Should().Be("NEW-CODE");
    }

    [Fact]
    public async Task Post_NormalCreate_IgnoresClientAttemptsToSetTrustedAuditAndId()
    {
        var forgedId = Guid.NewGuid().ToString("D");
        var forgedDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var requestStartedUtc = DateTime.UtcNow;
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Category, new
        {
            id = forgedId,
            name = $"Trusted Audit {Guid.NewGuid():N}",
            code = "AUDIT",
            isActive = true,
            createdDate = forgedDate,
            createdBy = "forged-user",
            updatedDate = forgedDate,
            updatedBy = "forged-user",
            lastModifiedUtc = forgedDate
        });

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Id.Should().NotBe(forgedId);
        created.CreatedDate.Should().BeOnOrAfter(requestStartedUtc);
        created.CreatedBy.Should().NotBe("forged-user");
        created.UpdatedDate.Should().BeNull();
        created.ClientCreatedDate.Should().BeNull();
        created.LastModifiedUtc.Should().BeOnOrAfter(requestStartedUtc);
    }

    [Fact]
    public async Task Post_SyncCreate_PreservesClientMetadataButServerOwnsAudit()
    {
        var id = Guid.NewGuid().ToString("D");
        var clientCreated = DateTime.UtcNow.AddHours(-2);
        var clientModified = clientCreated.AddMinutes(30);
        var requestStartedUtc = DateTime.UtcNow;
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Category}/sync", new CategorySyncCreateDto
        {
            Id = id,
            Name = $"Offline {Guid.NewGuid():N}",
            Code = "OFFLINE",
            IsActive = true,
            ClientCreatedDate = clientCreated,
            ClientModifiedDate = clientModified
        });

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
        created.Should().NotBeNull();
        created!.Id.Should().Be(id);
        created.CreatedDate.Should().BeOnOrAfter(requestStartedUtc);
        created.LastModifiedUtc.Should().BeOnOrAfter(requestStartedUtc);
        created.ClientCreatedDate.Should().BeCloseTo(clientCreated, TimeSpan.FromMilliseconds(1));
        created.ClientModifiedDate.Should().BeCloseTo(clientModified, TimeSpan.FromMilliseconds(1));
        created.ConflictModifiedUtc.Should().BeCloseTo(clientModified, TimeSpan.FromMilliseconds(1));
    }

    [Fact]
    public async Task Put_SyncUpdate_UsesLastWriteWinsAndServerWinsTies()
    {
        var id = Guid.NewGuid().ToString("D");
        var createdAt = DateTime.UtcNow.AddHours(-3);
        var createResponse = await Client.PostAsJsonAsync($"{ApiEndpoints.Category}/sync", new CategorySyncCreateDto
        {
            Id = id,
            Name = "Initial",
            IsActive = true,
            ClientCreatedDate = createdAt,
            ClientModifiedDate = createdAt
        });
        createResponse.EnsureSuccessStatusCode();

        var winningTime = createdAt.AddHours(2);
        var winningResponse = await Client.PutAsJsonAsync($"{ApiEndpoints.Category}/{id}/sync", new CategorySyncUpdateDto
        {
            Name = "Winning update",
            IsActive = true,
            ClientModifiedDate = winningTime
        });
        winningResponse.EnsureSuccessStatusCode();
        var winner = await winningResponse.Content.ReadFromJsonAsync<CategoryDto>();

        var tieResponse = await Client.PutAsJsonAsync($"{ApiEndpoints.Category}/{id}/sync", new CategorySyncUpdateDto
        {
            Name = "Must not overwrite",
            IsActive = true,
            ClientModifiedDate = winningTime
        });
        tieResponse.EnsureSuccessStatusCode();
        var afterTie = await tieResponse.Content.ReadFromJsonAsync<CategoryDto>();

        afterTie!.Name.Should().Be("Winning update");
        afterTie.ConflictModifiedUtc.Should().BeCloseTo(winningTime, TimeSpan.FromMilliseconds(1));
        afterTie.LastModifiedUtc.Should().BeCloseTo(
            winner!.LastModifiedUtc,
            TimeSpan.FromMicroseconds(1));
    }

    [Fact]
    public async Task Post_SyncCreate_WithInvalidGuid_ReturnsBadRequest()
    {
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Category}/sync", new CategorySyncCreateDto
        {
            Id = "not-a-guid",
            Name = "Invalid",
            IsActive = true,
            ClientCreatedDate = DateTime.UtcNow.AddMinutes(-2),
            ClientModifiedDate = DateTime.UtcNow.AddMinutes(-1)
        });

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_SyncCreate_WithDifferentClientUser_ReturnsBadRequest()
    {
        var timestamp = DateTime.UtcNow.AddMinutes(-1);
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Category}/sync", new CategorySyncCreateDto
        {
            Id = Guid.NewGuid().ToString("D"),
            Name = "Forged client user",
            IsActive = true,
            ClientCreatedDate = timestamp,
            ClientModifiedDate = timestamp,
            ClientCreatedBy = "different-user",
            ClientModifiedBy = "different-user"
        });

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Delete_SoftDelete_PreservesCreateAuditAndStampsServerUpdateAudit()
    {
        var created = await CreateCategoryAsync(
            _dataHelper.CreateCategoryBuilder().WithName($"Delete audit {Guid.NewGuid():N}").Build(),
            "Delete_SoftDelete_Audit_Seed");
        var beforeDeleteUtc = DateTime.UtcNow.AddSeconds(-1);

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Category}/{created.Id}");
        deleteResponse.EnsureSuccessStatusCode();

        var cursor = Uri.EscapeDataString(beforeDeleteUtc.ToString("O"));
        var pullResponse = await Client.GetAsync($"{ApiEndpoints.Category}/pull?changedSince={cursor}");
        pullResponse.EnsureSuccessStatusCode();
        var changes = await pullResponse.Content.ReadFromJsonAsync<List<CategoryDto>>();
        var tombstone = changes!.Single(category => category.Id == created.Id);

        tombstone.IsDeleted.Should().BeTrue();
        tombstone.CreatedDate.Should().Be(created.CreatedDate);
        tombstone.CreatedBy.Should().Be(created.CreatedBy);
        tombstone.UpdatedDate.Should().NotBeNull();
        tombstone.UpdatedBy.Should().NotBeNullOrWhiteSpace();
        tombstone.LastModifiedUtc.Should().BeOnOrAfter(beforeDeleteUtc);
    }

    //[Fact]
    //public async Task Post_CreateCategoryWithEmptyShopId_ReturnsBadRequest()
    //{
    //    var dto = _dataHelper.CreateCategoryBuilder().WithShopId("").Build();
    //    var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithEmptyShopId");

    //    response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    //}
}
