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
        actual.ShopId.Should().Be(expected.ShopId);
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
    public async Task Post_CreateCategoryWithEmptyShopId_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateCategoryBuilder().WithShopId("").Build();
        var response = await CreateCategoryResponseAsync(dto, "Post_CreateCategoryWithEmptyShopId");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }
}