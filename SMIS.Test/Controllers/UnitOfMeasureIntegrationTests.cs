using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class UnitOfMeasureIntegrationTests : BaseIntegrationTest
{
    private readonly UnitOfMeasureTestDataHelper _dataHelper;

    public UnitOfMeasureIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new UnitOfMeasureTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<UnitOfMeasureDto> CreateUnitOfMeasureAsync(UnitOfMeasureCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.UnitOfMeasure, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>())!;
    }

    private async Task<HttpResponseMessage> CreateUnitOfMeasureResponseAsync(UnitOfMeasureCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.UnitOfMeasure, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateUnitOfMeasureResponseAsync(string unitId, UnitOfMeasureCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.UnitOfMeasure}/{unitId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertUnitOfMeasureMatches(UnitOfMeasureDto actual, UnitOfMeasureCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.Name.ShouldBe(expected.Name);
        actual.Symbol.ShouldBe(expected.Symbol);
        actual.Description.ShouldBe(expected.Description);
    }

    [Fact]
    public async Task Post_CreateValidUnitOfMeasure_ReturnsOk()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateValidUnitOfMeasure");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        AssertUnitOfMeasureMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateUnitOfMeasureWithEmptyDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        dto.Description = "";

        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateUnitOfMeasureWithEmptyDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBe("");
    }

    [Fact]
    public async Task Post_CreateUnitOfMeasureWithNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        dto.Description = null;

        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateUnitOfMeasureWithNullDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListUnitOfMeasures_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListUnitOfMeasures");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<UnitOfMeasureDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListUnitOfMeasures_WithPagination_ReturnsCorrectPage()
    {
        var units = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateUnitOfMeasureBuilder().Build())
            .ToArray();

        foreach (var unit in units)
        {
            await CreateUnitOfMeasureAsync(unit, $"CreateTestUnit_{unit.Name}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListUnitOfMeasures_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<UnitOfMeasureDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_UnitOfMeasureById_Existing_ReturnsUnitOfMeasure()
    {
        var createDto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        var created = await PostAndGetAsync<UnitOfMeasureDto>(ApiEndpoints.UnitOfMeasure, createDto, "Get_UnitOfMeasureById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}/{created!.Id}");
        await LogIfError(getResponse, "Get_UnitOfMeasureById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertUnitOfMeasureMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_UnitOfMeasureById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}/non-existing-id");
        await LogIfError(response, "Get_UnitOfMeasureById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingUnitOfMeasure_ReturnsUpdatedUnitOfMeasure()
    {
        var createDto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        var created = await PostAndGetAsync<UnitOfMeasureDto>(ApiEndpoints.UnitOfMeasure, createDto, "Put_UpdateUnitOfMeasure_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateUnitOfMeasureBuilder().WithDescription("Updated Description").Build();
        var updateResponse = await UpdateUnitOfMeasureResponseAsync(created!.Id, updateDto, "Put_UpdateUnitOfMeasure_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertUnitOfMeasureMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingUnitOfMeasure_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        var response = await UpdateUnitOfMeasureResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingUnitOfMeasure");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingUnitOfMeasure_ReturnsOk()
    {
        var createDto = _dataHelper.CreateUnitOfMeasureBuilder().Build();
        var created = await PostAndGetAsync<UnitOfMeasureDto>(ApiEndpoints.UnitOfMeasure, createDto, "Delete_ExistingUnitOfMeasure_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.UnitOfMeasure}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingUnitOfMeasure_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingUnitOfMeasure_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.UnitOfMeasure}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingUnitOfMeasure");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateUnitOfMeasureWithEmptyName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().WithName("").Build();
        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateUnitOfMeasureWithEmptyName");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateUnitOfMeasureWithEmptySymbol_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().WithSymbol("").Build();
        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateUnitOfMeasureWithEmptySymbol");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateUnitOfMeasureWithExplicitNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateUnitOfMeasureBuilder().WithDescription(null).Build();
        var response = await CreateUnitOfMeasureResponseAsync(dto, "Post_CreateUnitOfMeasureWithExplicitNullDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBeNull();
    }

    [Fact]
    public async Task Put_UpdateUnitOfMeasureName_ReturnsUpdatedName()
    {
        var createDto = _dataHelper.CreateUnitOfMeasureBuilder().WithName("OldName").Build();
        var created = await PostAndGetAsync<UnitOfMeasureDto>(ApiEndpoints.UnitOfMeasure, createDto, "Put_UpdateUnitOfMeasureName_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateUnitOfMeasureBuilder().WithName("NewName").Build();
        var updateResponse = await UpdateUnitOfMeasureResponseAsync(created!.Id, updateDto, "Put_UpdateUnitOfMeasureName_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        updated.ShouldNotBeNull();
        updated!.Name.ShouldBe("NewName");
    }

    [Fact]
    public async Task Put_UpdateUnitOfMeasureSymbol_ReturnsUpdatedSymbol()
    {
        var createDto = _dataHelper.CreateUnitOfMeasureBuilder().WithSymbol("old").Build();
        var created = await PostAndGetAsync<UnitOfMeasureDto>(ApiEndpoints.UnitOfMeasure, createDto, "Put_UpdateUnitOfMeasureSymbol_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateUnitOfMeasureBuilder().WithSymbol("new").Build();
        var updateResponse = await UpdateUnitOfMeasureResponseAsync(created!.Id, updateDto, "Put_UpdateUnitOfMeasureSymbol_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<UnitOfMeasureDto>();
        updated.ShouldNotBeNull();
        updated!.Symbol.ShouldBe("new");
    }

    [Fact]
    public async Task Get_ListUnitOfMeasures_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.UnitOfMeasure}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListUnitOfMeasures_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleUnitOfMeasures_AllSucceed()
    {
        var units = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateUnitOfMeasureBuilder().Build())
            .ToList();

        foreach (var unit in units)
        {
            var response = await CreateUnitOfMeasureResponseAsync(unit, $"Post_CreateMultipleUnitOfMeasures_{unit.Symbol}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
