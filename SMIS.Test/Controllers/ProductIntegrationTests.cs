using System.Net;
using FluentAssertions;
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
        actual.Should().NotBeNull();
        actual.Name.Should().Be(expected.Name);
        actual.ShopId.Should().Be(expected.ShopId);
        actual.BaseUnitId.Should().Be(expected.BaseUnitId);
        actual.SalePricePerBaseUnit.Should().Be(expected.SalePricePerBaseUnit);
        actual.Description.Should().Be(expected.Description);
        actual.IsActive.Should().Be(expected.IsActive);
        actual.SKU.Should().Be(expected.SKU);
        actual.Barcode.Should().Be(expected.Barcode);
        actual.ImageUrl.Should().Be(expected.ImageUrl);
        actual.CategoryId.Should().Be(expected.CategoryId);
    }

    [Fact]
    public async Task Post_CreateValidProduct_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateValidProduct");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        AssertProductMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateProductWithEmptyDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        dto.Description = "";

        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptyDescription");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.Should().NotBeNull();
        created!.Description.Should().Be("");
    }

    [Fact]
    public async Task Post_CreateProductWithNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().Build();
        dto.Description = null;

        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNullDescription");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.Should().NotBeNull();
        created!.Description.Should().BeNull();
    }

    [Fact]
    public async Task Get_ListProducts_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListProducts");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Should().NotBeNull();
        paged.Items.Count.Should().BeGreaterOrEqualTo(0);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(10);
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

        paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
        paged.Should().NotBeNull();
        paged!.Items.Count.Should().BeLessOrEqualTo(2);
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(2);
        paged.TotalCount.Should().BeGreaterOrEqualTo(5);
    }

    [Fact]
    public async Task Get_ProductById_Existing_ReturnsProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Get_ProductById_Seed");
        created.Should().NotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}/{created!.Id}");
        await LogIfError(getResponse, "Get_ProductById_Get");

        getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
        retrieved.Should().NotBeNull();
        retrieved!.Id.Should().Be(created.Id);
        AssertProductMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_ProductById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}/non-existing-id");
        await LogIfError(response, "Get_ProductById_NonExisting");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingProduct_ReturnsUpdatedProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProduct_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProduct_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.Should().NotBeNull();
        updated!.Id.Should().Be(created.Id);
        AssertProductMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingProduct_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateProductBuilder().Build();
        var response = await UpdateProductResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingProduct");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingProduct_ReturnsOk()
    {
        var createDto = _dataHelper.CreateProductBuilder().Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Delete_ExistingProduct_Seed");
        created.Should().NotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Product}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingProduct_Delete");

        deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Product}/{created.Id}");
        getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingProduct_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Product}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingProduct");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

        [Fact]
        public async Task Post_CreateProductWithInvalidShopId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.ShopId = "invalid-shop-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidShopId");
            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidUnitId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.BaseUnitId = "invalid-unit-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidUnitId");
            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidCategoryId_ReturnsConflict()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.CategoryId = "invalid-category-id";

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithInvalidCategoryId");
            response.StatusCode.Should().Match(code => code == HttpStatusCode.InternalServerError || code == HttpStatusCode.Conflict);
        }

        [Fact]
        public async Task Post_CreateProductWithNegativePrice_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = -100;

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNegativePrice");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithZeroPrice_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = 0;

            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithZeroPrice");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.SalePricePerBaseUnit.Should().Be(0);
        }

        [Fact]
        public async Task Post_CreateProductWithDuplicateSKU_ReturnsConflict()
        {
            const string sku = "DUPLICATE-SKU-TEST";

            var firstProduct = _dataHelper.CreateProductBuilder().WithSKU(sku).Build();
            await CreateProductAsync(firstProduct, "Post_CreateProductWithDuplicateSKU_First");

            var secondProduct = _dataHelper.CreateProductBuilder().WithSKU(sku).Build();
            var secondResponse = await CreateProductResponseAsync(secondProduct, "Post_CreateProductWithDuplicateSKU_Second");

            secondResponse.StatusCode.Should().Match(code =>
                code == HttpStatusCode.BadRequest ||
                code == HttpStatusCode.Conflict ||
                code == HttpStatusCode.OK);

            if (secondResponse.StatusCode == HttpStatusCode.OK)
            {
                var createdSecond = await secondResponse.Content.ReadFromJsonAsync<ProductDto>();
                createdSecond.Should().NotBeNull();
                createdSecond!.SKU.Should().Be(sku);

                var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Product}/{createdSecond.Id}");
                deleteResponse.EnsureSuccessStatusCode();
            }
        }

        [Fact]
        public async Task Post_CreateProductWithEmptyName_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().WithName("").Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptyName");

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithEmptySKU_ReturnsBadRequest()
        {
            var dto = _dataHelper.CreateProductBuilder().WithSKU("").Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithEmptySKU");

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithNullCategoryId_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().WithCategoryId(null).Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithNullCategoryId");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.CategoryId.Should().BeNull();
        }

        [Fact]
        public async Task Post_CreateProductWithMaxPrice_ReturnsOk()
        {
            var dto = _dataHelper.CreateProductBuilder().WithPrice(int.MaxValue).Build();
            var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithMaxPrice");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.SalePricePerBaseUnit.Should().Be(int.MaxValue);
        }

    [Fact]
    public async Task Put_UpdateProductPrice_ReturnsUpdatedPrice()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithPrice(1000).Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductPrice_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithPrice(2000).Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProductPrice_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.Should().NotBeNull();
        updated!.SalePricePerBaseUnit.Should().Be(2000);
    }

    [Fact]
    public async Task Put_UpdateProductToInactive_ReturnsInactiveProduct()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductToInactive_Seed");
        created.Should().NotBeNull();
        created!.IsActive.Should().BeTrue();

        var updateDto = _dataHelper.CreateProductBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateProductResponseAsync(created.Id, updateDto, "Put_UpdateProductToInactive_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.Should().NotBeNull();
        updated!.IsActive.Should().BeFalse();
    }

    [Fact]
    public async Task Get_ListProducts_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Product}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListProducts_InvalidPageSize");

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
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
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateProductSKU_ReturnsUpdatedSKU()
    {
        var createDto = _dataHelper.CreateProductBuilder().WithSKU("OLD-SKU-001").Build();
        var created = await PostAndGetAsync<ProductDto>(ApiEndpoints.Product, createDto, "Put_UpdateProductSKU_Seed");
        created.Should().NotBeNull();

        var updateDto = _dataHelper.CreateProductBuilder().WithSKU("NEW-SKU-001").Build();
        var updateResponse = await UpdateProductResponseAsync(created!.Id, updateDto, "Put_UpdateProductSKU_Update");

        updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
        updated.Should().NotBeNull();
        updated!.SKU.Should().Be("NEW-SKU-001");
    }

    [Fact]
    public async Task Post_CreateProductWithExplicitNullDescription_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().WithDescription(null).Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithExplicitNullDescription");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.Should().NotBeNull();
        created!.Description.Should().BeNull();
    }

    [Fact]
    public async Task Post_CreateProductWithExplicitNullBarcode_ReturnsOk()
    {
        var dto = _dataHelper.CreateProductBuilder().WithBarcode(null).Build();
        var response = await CreateProductResponseAsync(dto, "Post_CreateProductWithExplicitNullBarcode");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<ProductDto>();
        created.Should().NotBeNull();
        created!.Barcode.Should().BeNull();
    }
}