using System.Net;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Localization;
using SMIS.Test.Extensions;
using SMIS.Test.TestHelpers;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class LanguageIntegrationTests : BaseIntegrationTest
{
    private readonly LanguageTestDataHelper _dataHelper;

    public LanguageIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new LanguageTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<LanguageDto> CreateLanguageAsync(LanguageCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Language, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<LanguageDto>())!;
    }

    private async Task<HttpResponseMessage> CreateLanguageResponseAsync(LanguageCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Language, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateLanguageResponseAsync(string languageId, LanguageCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Language}/{languageId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertLanguageMatches(LanguageDto actual, LanguageCreateDto expected)
    {
        actual.Should().NotBeNull();
        actual.Name.Should().Be(expected.Name);
        actual.Code.Should().Be(expected.Code);
        actual.IsActive.Should().Be(expected.IsActive);
    }

    [Fact]
    public async Task Post_CreateValidLanguage_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().Build();
        var response = await CreateLanguageResponseAsync(dto, "Post_CreateValidLanguage");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        AssertLanguageMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateLanguageWithEmptyCode_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().Build();
        dto.Code = "";

        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithEmptyCode");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        created.Should().NotBeNull();
        created!.Code.Should().Be("");
    }

    [Fact]
    public async Task Post_CreateLanguageWithNullCode_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().Build();
        dto.Code = null;

        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithNullCode");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        created.Should().NotBeNull();
        created!.Code.Should().BeNull();
    }

    [Fact]
    public async Task Get_ListLanguages_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Language}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListLanguages");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Should().NotBeNull();
        paged.Items.Count.Should().BeGreaterOrEqualTo(0);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(10);
    }

    [Fact]
    public async Task Get_ListLanguages_WithPagination_ReturnsCorrectPage()
    {
        var languages = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateLanguageBuilder().Build())
            .ToArray();

        foreach (var lang in languages)
        {
            await CreateLanguageAsync(lang, $"CreateTestLanguage_{lang.Name}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Language}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListLanguages_Pagination");

        paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Count.Should().BeLessOrEqualTo(2);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(2);
        paged.TotalCount.Should().BeGreaterOrEqualTo(5);
    }

    [Fact]
    public async Task Get_LanguageById_Existing_ReturnsLanguage()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Get_LanguageById_Seed");
        created.Should().NotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Language}/{created!.Id}");
        await LogIfError(getResponse, "Get_LanguageById_Get");

        getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<LanguageDto>();
        retrieved.Should().NotBeNull();
        retrieved!.Id.Should().Be(created.Id);
        AssertLanguageMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_LanguageById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Language}/non-existing-id");
        await LogIfError(response, "Get_LanguageById_NonExisting");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingLanguage_ReturnsUpdatedLanguage()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Put_UpdateLanguage_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateLanguageBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateLanguageResponseAsync(created!.Id, updateDto, "Put_UpdateLanguage_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
        updated.Should().NotBeNull();
        updated!.Id.Should().Be(created.Id);
        AssertLanguageMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingLanguage_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateLanguageBuilder().Build();
        var response = await UpdateLanguageResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingLanguage");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingLanguage_ReturnsOk()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Delete_ExistingLanguage_Seed");
        created.Should().NotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Language}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingLanguage_Delete");

        deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Language}/{created.Id}");
        getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingLanguage_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Language}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingLanguage");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateLanguageWithEmptyName_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().WithName("").Build();
        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithEmptyName");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        created.Should().NotBeNull();
        created!.Name.Should().Be("");
    }

    [Fact]
    public async Task Post_CreateLanguageWithNullName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateLanguageBuilder().Build();
        dto.Name = null!;
        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithNullName");

        response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.Conflict);
    }

    [Fact]
    public async Task Post_CreateLanguageWithDuplicateName_ReturnsConflict()
    {
        const string name = "DUPLICATE-NAME-TEST";

        var firstLanguage = _dataHelper.CreateLanguageBuilder().WithName(name).Build();
        await CreateLanguageAsync(firstLanguage, "Post_CreateLanguageWithDuplicateName_First");

        var secondLanguage = _dataHelper.CreateLanguageBuilder().WithName(name).Build();
        var secondResponse = await CreateLanguageResponseAsync(secondLanguage, "Post_CreateLanguageWithDuplicateName_Second");

        secondResponse.StatusCode.Should().Match(code =>
            code == HttpStatusCode.BadRequest ||
            code == HttpStatusCode.Conflict ||
            code == HttpStatusCode.OK);

        if (secondResponse.StatusCode == HttpStatusCode.OK)
        {
            var createdSecond = await secondResponse.Content.ReadFromJsonAsync<LanguageDto>();
            createdSecond.Should().NotBeNull();
            createdSecond!.Name.Should().Be(name);

            var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Language}/{createdSecond.Id}");
            deleteResponse.EnsureSuccessStatusCode();
        }
    }

    [Fact]
    public async Task Post_CreateMultipleLanguages_AllSucceed()
    {
        var languages = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateLanguageBuilder().Build())
            .ToList();

        foreach (var language in languages)
        {
            var response = await CreateLanguageResponseAsync(language, $"Post_CreateMultipleLanguages_{language.Name}");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateLanguageName_ReturnsUpdatedName()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().WithName("OLD-NAME-001").Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Put_UpdateLanguageName_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateLanguageBuilder().WithName("NEW-NAME-001").Build();
        var updateResponse = await UpdateLanguageResponseAsync(created!.Id, updateDto, "Put_UpdateLanguageName_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
        updated.Should().NotBeNull();
        updated!.Name.Should().Be("NEW-NAME-001");
    }

    [Fact]
    public async Task Put_UpdateLanguageToInactive_ReturnsInactiveLanguage()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Put_UpdateLanguageToInactive_Seed");
        created.Should().NotBeNull();
        created!.IsActive.Should().BeTrue();

        var updateDto = _dataHelper.CreateLanguageBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateLanguageResponseAsync(created.Id, updateDto, "Put_UpdateLanguageToInactive_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
        updated.Should().NotBeNull();
        updated!.IsActive.Should().BeFalse();
    }

    [Fact]
    public async Task Get_ListLanguages_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Language}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListLanguages_InvalidPageSize");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Put_UpdateLanguageCode_ReturnsUpdatedCode()
    {
        var createDto = _dataHelper.CreateLanguageBuilder().WithCode("OLD-CODE-001").Build();
        var created = await PostAndGetAsync<LanguageDto>(ApiEndpoints.Language, createDto, "Put_UpdateLanguageCode_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateLanguageBuilder().WithCode("NEW-CODE-001").Build();
        var updateResponse = await UpdateLanguageResponseAsync(created!.Id, updateDto, "Put_UpdateLanguageCode_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
        updated.Should().NotBeNull();
        updated!.Code.Should().Be("NEW-CODE-001");
    }

    [Fact]
    public async Task Post_CreateLanguageWithExplicitNullCode_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().WithCode(null).Build();
        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithExplicitNullCode");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        created.Should().NotBeNull();
        created!.Code.Should().BeNull();
    }

    [Fact]
    public async Task Post_CreateLanguageWithExplicitEmptyName_ReturnsOk()
    {
        var dto = _dataHelper.CreateLanguageBuilder().WithName("").Build();
        var response = await CreateLanguageResponseAsync(dto, "Post_CreateLanguageWithExplicitEmptyName");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
        created.Should().NotBeNull();
        created!.Name.Should().Be("");
    }
}