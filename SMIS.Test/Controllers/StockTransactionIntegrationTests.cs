using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestDataBuilders;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;
/*
 dsfsdffwewesdfsdf
 sdfsd*/
public class StockTransactionIntegrationTests : BaseIntegrationTest
{
    private readonly StockTransactionTestDataHelper _dataHelper;

    public StockTransactionIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new StockTransactionTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<StockTransactionDto> CreateStockTransactionAsync(StockTransactionCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockTransaction, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockTransactionDto>())!;
    }

    private async Task<HttpResponseMessage> CreateStockTransactionResponseAsync(StockTransactionCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockTransaction, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateStockTransactionResponseAsync(string id, StockTransactionCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.StockTransaction}/{id}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertStockTransactionMatches(StockTransactionDto actual, StockTransactionCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.ProductId.ShouldBe(expected.ProductId);
        actual.StockBatchId.ShouldBe(expected.StockBatchId);
        actual.Quantity.ShouldBe(expected.Quantity);
        actual.UnitId.ShouldBe(expected.UnitId);
        actual.Type.ShouldBe(expected.Type);
        actual.TransactionDate.Date.ShouldBe(expected.TransactionDate.Date);
        actual.Reference.ShouldBe(expected.Reference);
    }

    [Fact]
    public async Task Post_CreateValidStockTransaction_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateValidStockTransaction");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockTransactionDto>();
        AssertStockTransactionMatches(created!, dto);
    }

    [Fact]
    public async Task Get_ListStockTransactions_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListStockTransactions");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_StockTransactionById_Existing_ReturnsStockTransaction()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Get_StockTransactionById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}/{created!.Id}");
        await LogIfError(getResponse, "Get_StockTransactionById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertStockTransactionMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_StockTransactionById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockTransaction}/non-existing-id");
        await LogIfError(response, "Get_StockTransactionById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingStockTransaction_ReturnsUpdatedStockTransaction()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Put_UpdateStockTransaction_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockTransactionBuilder()
            .WithQuantity(25m)
            .WithType(TransactionType.Out)
            .WithReference("Updated Transaction")
            .Build();
        var updateResponse = await UpdateStockTransactionResponseAsync(created!.Id, updateDto, "Put_UpdateStockTransaction_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertStockTransactionMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingStockTransaction_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var response = await UpdateStockTransactionResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingStockTransaction");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingStockTransaction_ReturnsOk()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Delete_ExistingStockTransaction_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.StockTransaction}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingStockTransaction_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingStockTransaction_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.StockTransaction}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingStockTransaction");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithZeroQuantity_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithQuantity(0m).Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithZeroQuantity");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithEmptyProductId_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithProductId("").Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithEmptyProductId");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithEmptyStockBatchId_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithStockBatchId("").Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithEmptyStockBatchId");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithNegativeQuantity_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithQuantity(-5m).Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithNegativeQuantity");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithEmptyUnitId_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithUnitId("").Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithEmptyUnitId");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithDefaultTransactionDate_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithTransactionDate(default).Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithDefaultTransactionDate");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithLongReference_ReturnsBadRequest()
    {
        var longReference = new string('A', 201); // 201 characters
        var dto = _dataHelper.CreateStockTransactionBuilder().WithReference(longReference).Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithLongReference");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithNullReference_ReturnsOk()
    {
        var dto = _dataHelper.CreateStockTransactionBuilder().WithReference(null).Build();
        var response = await CreateStockTransactionResponseAsync(dto, "Post_CreateStockTransactionWithNullReference");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<StockTransactionDto>();
        created!.Reference.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateStockTransactionWithDifferentTypes_ReturnsOk()
    {
        var inDto = _dataHelper.CreateStockTransactionBuilder().WithType(TransactionType.In).Build();
        var outDto = _dataHelper.CreateStockTransactionBuilder().WithType(TransactionType.Out).Build();
        var adjustmentDto = _dataHelper.CreateStockTransactionBuilder().WithType(TransactionType.Adujstment).Build();

        var inResponse = await CreateStockTransactionResponseAsync(inDto, "Post_CreateStockTransactionIn");
        var outResponse = await CreateStockTransactionResponseAsync(outDto, "Post_CreateStockTransactionOut");
        var adjustmentResponse = await CreateStockTransactionResponseAsync(adjustmentDto, "Post_CreateStockTransactionAdjustment");

        inResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        outResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        adjustmentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var inCreated = await inResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        var outCreated = await outResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        var adjustmentCreated = await adjustmentResponse.Content.ReadFromJsonAsync<StockTransactionDto>();

        inCreated!.Type.ShouldBe(TransactionType.In);
        outCreated!.Type.ShouldBe(TransactionType.Out);
        adjustmentCreated!.Type.ShouldBe(TransactionType.Adujstment);
    }

    [Fact]
    public async Task Get_ListStockTransactionsWithIncludeRelated_ReturnsRelatedData()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.StockTransaction}?pageNumber=1&pageSize=5&includeRelated=true");
        await LogIfError(response, "Get_ListStockTransactionsWithIncludeRelated");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<StockTransactionDto>>();
        paged.ShouldNotBeNull();
        
        if (paged!.Items.Any())
        {
            var firstItem = paged.Items.First();
            // Related data should be included when includeRelated=true
            firstItem.Product.ShouldNotBeNull();
        }
    }

    [Fact]
    public async Task Get_StockTransactionByIdWithIncludeRelated_ReturnsRelatedData()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Get_StockTransactionByIdWithIncludeRelated_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.StockTransaction}/{created!.Id}?includeRelated=true");
        await LogIfError(getResponse, "Get_StockTransactionByIdWithIncludeRelated_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Product.ShouldNotBeNull();
    }

    [Fact]
    public async Task Put_UpdateStockTransactionQuantity_ReturnsUpdatedQuantity()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().WithQuantity(10m).Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Put_UpdateStockTransactionQuantity_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockTransactionBuilder().WithQuantity(50m).Build();
        var updateResponse = await UpdateStockTransactionResponseAsync(created!.Id, updateDto, "Put_UpdateStockTransactionQuantity_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<StockTransactionDto>();
        updated.ShouldNotBeNull();
        updated!.Quantity.ShouldBe(50m);
    }

    [Fact]
    public async Task Put_UpdateStockTransactionWithInvalidQuantity_ReturnsBadRequest()
    {
        var createDto = _dataHelper.CreateStockTransactionBuilder().Build();
        var created = await PostAndGetAsync<StockTransactionDto>(ApiEndpoints.StockTransaction, createDto, "Put_UpdateStockTransactionWithInvalidQuantity_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateStockTransactionBuilder().WithQuantity(-10m).Build();
        var response = await UpdateStockTransactionResponseAsync(created!.Id, updateDto, "Put_UpdateStockTransactionWithInvalidQuantity");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }
}