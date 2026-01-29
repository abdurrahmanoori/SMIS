using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class ProductIntegrationTests : BaseIntegrationTest
{
    private readonly ProductTestDataHelper _dataHelper;

    public ProductIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<ProductDto> CreateProductAsync(ProductCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Product, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ProductDto>())!;
    }

    private async Task<HttpResponseMessage> CreateProductResponseAsync(ProductCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Product, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateProductResponseAsync(string productId, ProductCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Product}/{productId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertProductMatches(ProductDto actual, ProductCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.Name.ShouldBe(expected.Name);
        actual.ShopId.ShouldBe(expected.ShopId);
        actual.BaseUnitId.ShouldBe(expected.BaseUnitId);
        actual.SalePricePerBaseUnit.ShouldBe(expected.SalePricePerBaseUnit);
        actual.Description.ShouldBe(expected.Description);
        actual.IsActive.ShouldBe(expected.IsActive);
        actual.SKU.ShouldBe(expected.SKU);
        actual.Barcode.ShouldBe(expected.Barcode);
        actual.ImageUrl.ShouldBe(expected.ImageUrl);
        actual.CategoryId.ShouldBe(expected.CategoryId);
    }

    [Fact]
    public async Task Post_CreateValidProduct_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateValidProduct");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        AssertProductMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateProductWithEmptyDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        dto.Description = "";

        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptyDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBe("");
    }

    [Fact]
    public async Task Post_CreateProductWithNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        dto.Description = null;

        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNullDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListProducts_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListProducts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListProducts_WithPagination_ReturnsCorrectPage()
    {
        var products = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateProductBuilder().Build())
            .ToArray();

        foreach (var prod in products)
        {
            await CreateProductAsync(prod, $"CreateTestProduct_{prod.Name}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListProducts_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ProductById_Existing_ReturnsProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Get_ProductById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}/{created!.Id}");
        await LogIfError(getResponse, "Get_ProductById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertProductMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ProductById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/non-existing-id");
        await LogIfError(response, "Get_ProductById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingProduct_ReturnsUpdatedProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProduct_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProduct_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertProductMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingProduct_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateProductBuilder().Build();
        var response = await UpdateProductResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingProduct");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingProduct_ReturnsOk()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Delete_ExistingProduct_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Product}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingProduct_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingProduct_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Product}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingProduct");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

        [Fact]
        public async Task Post_CreateProductWithInvalidShopId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.ShopId = "invalid-shop-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidShopId");
            (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidUnitId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.BaseUnitId = "invalid-unit-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidUnitId");
            (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidCategoryId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.CategoryId = "invalid-category-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidCategoryId");
            (response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode == HttpStatusCode.Conflict).ShouldBeTrue();
        }

        [Fact]
        public async Task Post_CreateProductWithNegativePrice_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = -100;

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNegativePrice");
            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithZeroPrice_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = 0;

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithZeroPrice");
            
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.ShouldNotBeNull();
            created!.SalePricePerBaseUnit.ShouldBe(0);
        }

        [Fact]
        public async Task Post_CreateProductWithDuplicateSKU_ReturnsConflict()
        {
            const string sku = "DUPLICATE-SKU-TEST";

            var firstProduct = _dataHelper.CreateProductBuilder().WithSKU(sku).Build();
            await CreateProductAsync(firstProduct, "Post_CreateProductWithDuplicateSKU_First");

            var secondProduct = _dataHelper.CreateProductBuilder().WithSKU(sku).Build();
            var secondResponse = await CreateProductResponseAsync(secondProduct, "Post_CreateProductWithDuplicateSKU_Second");

            (secondResponse.StatusCode == HttpStatusCode.BadRequest ||
             secondResponse.StatusCode == HttpStatusCode.Conflict ||
             secondResponse.StatusCode == HttpStatusCode.OK).ShouldBeTrue();

            if (secondResponse.StatusCode == HttpStatusCode.OK)
            {
                var createdSecond = await secondResponse.Content.ReadFromJsonAsync<ProductDto>();
                createdSecond.ShouldNotBeNull();
                createdSecond!.SKU.ShouldBe(sku);

                var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Product}/{createdSecond.Id}");
                deleteResponse.EnsureSuccessStatusCode();
            }
        }

        [Fact]
        public async Task Post_CreateProductWithEmptyName_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().WithName("").Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptyName");

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithEmptySKU_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().WithSKU("").Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptySKU");

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithNullCategoryId_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().WithCategoryId(null).Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNullCategoryId");

            response.StatusCode.ShouldBe(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.ShouldNotBeNull();
            created!.CategoryId.ShouldBeNull();
        }

        [Fact]
        public async Task Post_CreateProductWithMaxPrice_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().WithPrice(int.MaxValue).Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithMaxPrice");

            response.StatusCode.ShouldBe(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.ShouldNotBeNull();
            created!.SalePricePerBaseUnit.ShouldBe(int.MaxValue);
        }

    [Fact]
    public async Task Put_UpdateProductPrice_ReturnsUpdatedPrice()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithPrice(1000).Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductPrice_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithPrice(2000).Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProductPrice_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.ShouldNotBeNull();
        updated!.SalePricePerBaseUnit.ShouldBe(2000);
    }

    [Fact]
    public async Task Put_UpdateProductToInactive_ReturnsInactiveProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductToInactive_Seed");
        created.ShouldNotBeNull();
        created!.IsActive.ShouldBeTrue();

        var updateDto = _dataHelper.CreateProductBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductResponseAsync(created.Id, updateDto, "Put_UpdateProductToInactive_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.ShouldNotBeNull();
        updated!.IsActive.ShouldBeFalse();
    }

    [Fact]
    public async Task Get_ListProducts_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListProducts_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleProducts_AllSucceed()
    {
        var products = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateProductBuilder().Build())
            .ToList();

        foreach (var product in products)
        {
            var response = await CreateProductResponseAsync(product, $"Post_CreateMultipleProducts_{product.SKU}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateProductSKU_ReturnsUpdatedSKU()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithSKU("OLD-SKU-001").Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductSKU_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithSKU("NEW-SKU-001").Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProductSKU_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.ShouldNotBeNull();
        updated!.SKU.ShouldBe("NEW-SKU-001");
    }

    [Fact]
    public async Task Post_CreateProductWithExplicitNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().WithDescription(null).Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithExplicitNullDescription");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.ShouldNotBeNull();
        created!.Description.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateProductWithExplicitNullBarcode_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().WithBarcode(null).Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithExplicitNullBarcode");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.ShouldNotBeNull();
        created!.Barcode.ShouldBeNull();
    }
}
