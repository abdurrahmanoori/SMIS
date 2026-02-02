using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ProductUnitIntegrationTests : BaseIntegrationTest
{
    private readonly ProductUnitTestDataHelper _dataHelper;

    public ProductUnitIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ProductUnitTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<ProductUnitDto> CreateProductUnitAsync(ProductUnitCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ProductUnit, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ProductUnitDto>())!;
    }

    private async Task<HttpResponseMessage> CreateProductUnitResponseAsync(ProductUnitCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ProductUnit, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateProductUnitResponseAsync(string productUnitId, ProductUnitCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.ProductUnit}/{productUnitId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertProductUnitMatches(ProductUnitDto actual, ProductUnitCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.ShopId.ShouldBe(expected.ShopId);
        actual.ProductId.ShouldBe(expected.ProductId);
        actual.UnitOfMeasureId.ShouldBe(expected.UnitOfMeasureId);
        actual.ConversionFactor.ShouldBe(expected.ConversionFactor);
    }

    [Fact]
    public async Task Post_CreateValidProductUnit_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().Build();
        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateValidProductUnit");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductUnitDto>();
        AssertProductUnitMatches(created!, dto);
    }

    [Fact]
    public async Task Get_ListProductUnits_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductUnit}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListProductUnits");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductUnitDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListProductUnits_WithPagination_ReturnsCorrectPage()
    {
        var productUnits = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateProductUnitBuilder().Build())
            .ToArray();

        foreach (var pu in productUnits)
        {
            await CreateProductUnitAsync(pu, $"CreateTestProductUnit_{pu.ConversionFactor}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.ProductUnit}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListProductUnits_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ProductUnitDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ProductUnitById_Existing_ReturnsProductUnit()
    {
        var createDto = _dataHelper.CreateProductUnitBuilder().Build();
        var created = await PostAndGetAsync<ProductUnitDto>(ApiEndpoints.ProductUnit, createDto, "Get_ProductUnitById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ProductUnit}/{created!.Id}");
        await LogIfError(getResponse, "Get_ProductUnitById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductUnitDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertProductUnitMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ProductUnitById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductUnit}/non-existing-id");
        await LogIfError(response, "Get_ProductUnitById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingProductUnit_ReturnsUpdatedProductUnit()
    {
        var createDto = _dataHelper.CreateProductUnitBuilder().Build();
        var created = await PostAndGetAsync<ProductUnitDto>(ApiEndpoints.ProductUnit, createDto, "Put_UpdateProductUnit_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductUnitBuilder().WithConversionFactor(50).Build();
        var updateResponse = await UpdateProductUnitResponseAsync(created!.Id, updateDto, "Put_UpdateProductUnit_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductUnitDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertProductUnitMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingProductUnit_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateProductUnitBuilder().Build();
        var response = await UpdateProductUnitResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingProductUnit");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingProductUnit_ReturnsOk()
    {
        var createDto = _dataHelper.CreateProductUnitBuilder().Build();
        var created = await PostAndGetAsync<ProductUnitDto>(ApiEndpoints.ProductUnit, createDto, "Delete_ExistingProductUnit_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.ProductUnit}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingProductUnit_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ProductUnit}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingProductUnit_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.ProductUnit}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingProductUnit");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateProductUnitWithInvalidProductId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().Build();
        dto.ProductId = "invalid-product-id";

        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithInvalidProductId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateProductUnitWithInvalidUnitId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().Build();
        dto.UnitOfMeasureId = "invalid-unit-id";

        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithInvalidUnitId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateProductUnitWithNegativeConversionFactor_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().Build();
        dto.ConversionFactor = -10;

        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithNegativeConversionFactor");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateProductUnitWithZeroConversionFactor_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().Build();
        dto.ConversionFactor = 0;

        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithZeroConversionFactor");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Put_UpdateProductUnitConversionFactor_ReturnsUpdatedConversionFactor()
    {
        var createDto = _dataHelper.CreateProductUnitBuilder().WithConversionFactor(10).Build();
        var created = await PostAndGetAsync<ProductUnitDto>(ApiEndpoints.ProductUnit, createDto, "Put_UpdateConversionFactor_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductUnitBuilder().WithConversionFactor(20).Build();
        var updateResponse = await UpdateProductUnitResponseAsync(created!.Id, updateDto, "Put_UpdateConversionFactor_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductUnitDto>();
        updated.ShouldNotBeNull();
        updated!.ConversionFactor.ShouldBe(20);
    }

    [Fact]
    public async Task Get_ListProductUnits_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductUnit}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListProductUnits_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleProductUnits_AllSucceed()
    {
        var productUnits = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateProductUnitBuilder().Build())
            .ToList();

        foreach (var pu in productUnits)
        {
            var response = await CreateProductUnitResponseAsync(pu, $"Post_CreateMultipleProductUnits_{pu.ConversionFactor}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Post_CreateProductUnitWithDecimalConversionFactor_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().WithConversionFactor(12.5m).Build();
        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithDecimalConversionFactor");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductUnitDto>();
        created.ShouldNotBeNull();
        created!.ConversionFactor.ShouldBe(12.5m);
    }

    [Fact]
    public async Task Post_CreateProductUnitWithLargeConversionFactor_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductUnitBuilder().WithConversionFactor(1000).Build();
        var response = await CreateProductUnitResponseAsync(dto, "Post_CreateProductUnitWithLargeConversionFactor");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductUnitDto>();
        created.ShouldNotBeNull();
        created!.ConversionFactor.ShouldBe(1000);
    }
}
