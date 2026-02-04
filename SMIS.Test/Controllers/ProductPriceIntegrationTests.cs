using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ProductPriceIntegrationTests : BaseIntegrationTest
{
    private readonly ProductPriceTestDataHelper _dataHelper;

    public ProductPriceIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ProductPriceTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<ProductPriceDto> CreateProductPriceAsync(ProductPriceCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ProductPrice, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ProductPriceDto>())!;
    }

    private async Task<HttpResponseMessage> CreateProductPriceResponseAsync(ProductPriceCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.ProductPrice, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateProductPriceResponseAsync(string productPriceId, ProductPriceCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.ProductPrice}/{productPriceId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertProductPriceMatches(ProductPriceDto actual, ProductPriceCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.ProductId.ShouldBe(expected.ProductId);
        actual.Price.ShouldBe(expected.Price);
        actual.EffectiveDate.Date.ShouldBe(expected.EffectiveDate.Date);
        if (expected.EndDate.HasValue)
        {
            actual.EndDate.ShouldNotBeNull();
            actual.EndDate!.Value.Date.ShouldBe(expected.EndDate.Value.Date);
        }
        else
        {
            actual.EndDate.ShouldBeNull();
        }
        actual.IsActive.ShouldBe(expected.IsActive);
    }

    [Fact]
    public async Task Post_CreateValidProductPrice_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().Build();
        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateValidProductPrice");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        AssertProductPriceMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithNullEndDate_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().WithEndDate(null).Build();

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithNullEndDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.EndDate.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateProductPriceWithEndDate_ReturnsOk()
    {
        var effectiveDate = DateTime.Now.AddDays(-30);
        var endDate = DateTime.Now.AddDays(30);
        var dto = _dataHelper.CreateProductPriceBuilder()
            .WithEffectiveDate(effectiveDate)
            .WithEndDate(endDate)
            .Build();

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithEndDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.EndDate.ShouldNotBeNull();
    }

    [Fact]
    public async Task Get_ListProductPrices_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductPrice}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListProductPrices");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductPriceDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListProductPrices_WithPagination_ReturnsCorrectPage()
    {
        var productPrices = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateProductPriceBuilder().Build())
            .ToArray();

        foreach (var price in productPrices)
        {
            await CreateProductPriceAsync(price, $"CreateTestProductPrice_{price.Price}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.ProductPrice}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListProductPrices_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ProductPriceDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ProductPriceById_Existing_ReturnsProductPrice()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Get_ProductPriceById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ProductPrice}/{created!.Id}");
        await LogIfError(getResponse, "Get_ProductPriceById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertProductPriceMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ProductPriceById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductPrice}/non-existing-id");
        await LogIfError(response, "Get_ProductPriceById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingProductPrice_ReturnsUpdatedProductPrice()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Put_UpdateProductPrice_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductPriceBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductPriceResponseAsync(created!.Id, updateDto, "Put_UpdateProductPrice_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertProductPriceMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingProductPrice_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateProductPriceBuilder().Build();
        var response = await UpdateProductPriceResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingProductPrice");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingProductPrice_ReturnsOk()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Delete_ExistingProductPrice_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.ProductPrice}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingProductPrice_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ProductPrice}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingProductPrice_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.ProductPrice}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingProductPrice");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithInvalidProductId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().Build();
        dto.ProductId = "invalid-product-id";

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithInvalidProductId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateProductPriceWithNegativePrice_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().WithPrice(-100).Build();

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithNegativePrice");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithZeroPrice_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().WithPrice(0).Build();

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithZeroPrice");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.Price.ShouldBe(0);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithEndDateBeforeEffectiveDate_ReturnsBadRequest()
    {
        var effectiveDate = DateTime.Now;
        var endDate = DateTime.Now.AddDays(-10);
        var dto = _dataHelper.CreateProductPriceBuilder()
            .WithEffectiveDate(effectiveDate)
            .WithEndDate(endDate)
            .Build();

        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithEndDateBeforeEffectiveDate");
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithMaxPrice_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductPriceBuilder().WithPrice(int.MaxValue).Build();
        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithMaxPrice");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.Price.ShouldBe(int.MaxValue);
    }

    [Fact]
    public async Task Put_UpdateProductPricePrice_ReturnsUpdatedPrice()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().WithPrice(1000).Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Put_UpdateProductPricePrice_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductPriceBuilder().WithPrice(2000).Build();
        var updateResponse = await UpdateProductPriceResponseAsync(created!.Id, updateDto, "Put_UpdateProductPricePrice_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        updated.ShouldNotBeNull();
        updated!.Price.ShouldBe(2000);
    }

    [Fact]
    public async Task Put_UpdateProductPriceToInactive_ReturnsInactiveProductPrice()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Put_UpdateProductPriceToInactive_Seed");
        created.ShouldNotBeNull();
        created!.IsActive.ShouldBeTrue();

        var updateDto = _dataHelper.CreateProductPriceBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductPriceResponseAsync(created.Id, updateDto, "Put_UpdateProductPriceToInactive_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        updated.ShouldNotBeNull();
        updated!.IsActive.ShouldBeFalse();
    }

    [Fact]
    public async Task Get_ListProductPrices_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.ProductPrice}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListProductPrices_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleProductPrices_AllSucceed()
    {
        var productPrices = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateProductPriceBuilder().Build())
            .ToList();

        foreach (var productPrice in productPrices)
        {
            var response = await CreateProductPriceResponseAsync(productPrice, $"Post_CreateMultipleProductPrices_{productPrice.Price}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateProductPriceEffectiveDate_ReturnsUpdatedEffectiveDate()
    {
        var oldDate = DateTime.Now.AddDays(-30);
        var newDate = DateTime.Now.AddDays(-15);
        var createDto = _dataHelper.CreateProductPriceBuilder().WithEffectiveDate(oldDate).Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Put_UpdateProductPriceEffectiveDate_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductPriceBuilder().WithEffectiveDate(newDate).Build();
        var updateResponse = await UpdateProductPriceResponseAsync(created!.Id, updateDto, "Put_UpdateProductPriceEffectiveDate_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        updated.ShouldNotBeNull();
        updated!.EffectiveDate.Date.ShouldBe(newDate.Date);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithFutureEffectiveDate_ReturnsOk()
    {
        var futureDate = DateTime.Now.AddDays(30);
        var dto = _dataHelper.CreateProductPriceBuilder().WithEffectiveDate(futureDate).Build();
        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithFutureEffectiveDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.EffectiveDate.Date.ShouldBe(futureDate.Date);
    }

    [Fact]
    public async Task Post_CreateProductPriceWithPastEffectiveDate_ReturnsOk()
    {
        var pastDate = DateTime.Now.AddDays(-30);
        var dto = _dataHelper.CreateProductPriceBuilder().WithEffectiveDate(pastDate).Build();
        var response = await CreateProductPriceResponseAsync(dto, "Post_CreateProductPriceWithPastEffectiveDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductPriceDto>();
        created.ShouldNotBeNull();
        created!.EffectiveDate.Date.ShouldBe(pastDate.Date);
    }

    [Fact]
    public async Task Put_UpdateProductPriceEndDate_ReturnsUpdatedEndDate()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().WithEndDate(null).Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Put_UpdateProductPriceEndDate_Seed");
        created.ShouldNotBeNull();
        created!.EndDate.ShouldBeNull();

        var newEndDate = DateTime.Now.AddDays(60);
        var updateDto = _dataHelper.CreateProductPriceBuilder().WithEndDate(newEndDate).Build();
        var updateResponse = await UpdateProductPriceResponseAsync(created.Id, updateDto, "Put_UpdateProductPriceEndDate_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        updated.ShouldNotBeNull();
        updated!.EndDate.ShouldNotBeNull();
        updated.EndDate!.Value.Date.ShouldBe(newEndDate.Date);
    }

    [Fact]
    public async Task Get_ProductPriceById_WithIncludeProduct_ReturnsProductPriceWithProduct()
    {
        var createDto = _dataHelper.CreateProductPriceBuilder().Build();
        var created = await PostAndGetAsync<ProductPriceDto>(ApiEndpoints.ProductPrice, createDto, "Get_ProductPriceById_WithIncludeProduct_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.ProductPrice}/{created!.Id}?includeProduct=true");
        await LogIfError(getResponse, "Get_ProductPriceById_WithIncludeProduct_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductPriceDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Product.ShouldNotBeNull();
    }
}
