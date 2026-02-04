using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockBatches;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class StockBatchIntegrationTests : BaseIntegrationTest
{
    private readonly StockBatchTestDataHelper _dataHelper;

    public StockBatchIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new StockBatchTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<StockBatchDto> CreateStockBatchAsync(StockBatchCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockBatchDto>())!;
    }

    private async Task<HttpResponseMessage> CreateStockBatchResponseAsync(StockBatchCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateStockBatchResponseAsync(string stockBatchId, StockBatchCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.StockBatch}/{stockBatchId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertStockBatchMatches(StockBatchDto actual, StockBatchCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.ProductId.ShouldBe(expected.ProductId);
        actual.UnitId.ShouldBe(expected.UnitId);
        actual.Quantity.ShouldBe(expected.Quantity);
        actual.PurchasePrice.ShouldBe(expected.PurchasePrice);
        actual.BatchNumber.ShouldBe(expected.BatchNumber);
        actual.Status.ShouldBe(expected.Status);
    }

    [Fact]
    public async Task Post_CreateValidStockBatch_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateValidStockBatch");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        AssertStockBatchMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateStockBatchWithNullBatchNumber_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.BatchNumber = null;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithNullBatchNumber");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.BatchNumber.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateStockBatchWithNullExpirationDate_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.ExpirationDate = null;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithNullExpirationDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.ExpirationDate.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListStockBatches_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockBatch}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListStockBatches");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<StockBatchDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListStockBatches_WithPagination_ReturnsCorrectPage()
    {
        var stockBatches = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateStockBatchBuilder().Build())
            .ToArray();

        foreach (var sb in stockBatches)
        {
            await CreateStockBatchAsync(sb, $"CreateTestStockBatch_{sb.BatchNumber}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListStockBatches_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<StockBatchDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_StockBatchById_Existing_ReturnsStockBatch()
    {
        var createDto = _dataHelper.CreateStockBatchBuilder().Build();
        var created = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, createDto, "Get_StockBatchById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{created!.Id}");
        await LogIfError(getResponse, "Get_StockBatchById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertStockBatchMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_StockBatchById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockBatch}/non-existing-id");
        await LogIfError(response, "Get_StockBatchById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingStockBatch_ReturnsUpdatedStockBatch()
    {
        var createDto = _dataHelper.CreateStockBatchBuilder().Build();
        var created = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, createDto, "Put_UpdateStockBatch_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockBatchBuilder().WithQuantity(200).Build();
        var updateResponse = await UpdateStockBatchResponseAsync(created!.Id, updateDto, "Put_UpdateStockBatch_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertStockBatchMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingStockBatch_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateStockBatchBuilder().Build();
        var response = await UpdateStockBatchResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingStockBatch");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingStockBatch_ReturnsOk()
    {
        var createDto = _dataHelper.CreateStockBatchBuilder().Build();
        var created = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, createDto, "Delete_ExistingStockBatch_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.StockBatch}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingStockBatch_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.StockBatch}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingStockBatch_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.StockBatch}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingStockBatch");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateStockBatchWithInvalidProductId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.ProductId = "invalid-product-id";

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithInvalidProductId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateStockBatchWithInvalidUnitId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.UnitId = "invalid-unit-id";

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithInvalidUnitId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateStockBatchWithNegativeQuantity_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.Quantity = -10;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithNegativeQuantity");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockBatchWithZeroQuantity_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.Quantity = 0;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithZeroQuantity");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.Quantity.ShouldBe(0);
    }

    [Fact]
    public async Task Post_CreateStockBatchWithNegativePrice_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.PurchasePrice = -100;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithNegativePrice");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockBatchWithZeroPrice_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().Build();
        dto.PurchasePrice = 0;

        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithZeroPrice");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.PurchasePrice.ShouldBe(0);
    }

    [Fact]
    public async Task Put_UpdateStockBatchQuantity_ReturnsUpdatedQuantity()
    {
        var createDto = _dataHelper.CreateStockBatchBuilder().WithQuantity(100).Build();
        var created = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, createDto, "Put_UpdateQuantity_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockBatchBuilder().WithQuantity(150).Build();
        var updateResponse = await UpdateStockBatchResponseAsync(created!.Id, updateDto, "Put_UpdateQuantity_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        updated.ShouldNotBeNull();
        updated!.Quantity.ShouldBe(150);
    }

    [Fact]
    public async Task Get_ListStockBatches_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockBatch}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListStockBatches_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleStockBatches_AllSucceed()
    {
        var stockBatches = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateStockBatchBuilder().Build())
            .ToList();

        foreach (var sb in stockBatches)
        {
            var response = await CreateStockBatchResponseAsync(sb, $"Post_CreateMultipleStockBatches_{sb.BatchNumber}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Post_CreateStockBatchWithExpirationDate_ReturnsOk()
    {
        var expiryDate = DateTime.UtcNow.AddMonths(6);
        var dto = _dataHelper.CreateStockBatchBuilder().WithExpirationDate(expiryDate).Build();
        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithExpirationDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.ExpirationDate.ShouldNotBeNull();
    }

    [Fact]
    public async Task Post_CreateStockBatchWithStatus_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockBatchBuilder().WithStatus(StatusEnum.Active).Build();
        var response = await CreateStockBatchResponseAsync(dto, "Post_CreateStockBatchWithStatus");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockBatchDto>();
        created.ShouldNotBeNull();
        created!.Status.ShouldBe(StatusEnum.Active);
    }

    [Fact]
    public async Task Put_UpdateStockBatchPrice_ReturnsUpdatedPrice()
    {
        var createDto = _dataHelper.CreateStockBatchBuilder().WithPurchasePrice(1000).Build();
        var created = await PostAndGetAsync<StockBatchDto>(ApiEndpoints.StockBatch, createDto, "Put_UpdatePrice_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockBatchBuilder().WithPurchasePrice(1500).Build();
        var updateResponse = await UpdateStockBatchResponseAsync(created!.Id, updateDto, "Put_UpdatePrice_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<StockBatchDto>();
        updated.ShouldNotBeNull();
        updated!.PurchasePrice.ShouldBe(1500);
    }
}
