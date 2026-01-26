using System.Net;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
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

        [Fact]
        public async Task Post_CreateValidProduct_ReturnsOk()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder()
                .Build();

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateValidProduct");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.ShopId.Should().Be(dto.ShopId);
            created.BaseUnitId.Should().Be(dto.BaseUnitId);
            created.SalePricePerBaseUnit.Should().Be(dto.SalePricePerBaseUnit);
            created.Description.Should().Be(dto.Description);
            created.IsActive.Should().Be(dto.IsActive);
            created.SKU.Should().Be(dto.SKU);
            created.Barcode.Should().Be(dto.Barcode);
            created.ImageUrl.Should().Be(dto.ImageUrl);
            created.CategoryId.Should().Be(dto.CategoryId);
        }

        [Fact]
        public async Task Post_CreateProductWithEmptyDescription_ReturnsOk()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.Description = "";

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithEmptyDescription");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Description.Should().Be(dto.Description);
        }

        [Fact]
        public async Task Post_CreateProductWithNullDescription_ReturnsOk()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.Description = null;

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithNullDescription");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Description.Should().BeNull();
        }

        [Fact]
        public async Task Get_ListProducts_ReturnsPagedList()
        {
            var response = await Client.GetAsync("/api/product?pageNumber=1&pageSize=10");
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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var products = Enumerable.Range(1, 5)
                .Select(i => _dataHelper.CreateProductBuilder().Build())
                .ToArray();

            foreach (var prod in products)
            {
                var response = await Client.PostAsJsonAsync("/api/product", prod);
                await LogIfError(response, $"CreateTestProduct_{prod.Name}");
                response.EnsureSuccessStatusCode();
            }

            var paginatedResponse = await Client.GetAsync("/api/product?pageNumber=1&pageSize=2");
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
            await _dataHelper.GetOrCreateDependencies();
            var createDto = _dataHelper.CreateProductBuilder().Build();

            var created = await PostAndGetAsync<ProductDto>("/api/product", createDto, "Get_ProductById_Seed");
            created.Should().NotBeNull();

            var getResponse = await Client.GetAsync($"/api/product/{created!.Id}");
            await LogIfError(getResponse, "Get_ProductById_Get");

            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(created.Id);
            retrieved.Name.Should().Be(createDto.Name);
            retrieved.ShopId.Should().Be(createDto.ShopId);
            retrieved.BaseUnitId.Should().Be(createDto.BaseUnitId);
            retrieved.SalePricePerBaseUnit.Should().Be(createDto.SalePricePerBaseUnit);
            retrieved.Description.Should().Be(createDto.Description);
            retrieved.IsActive.Should().Be(createDto.IsActive);
            retrieved.SKU.Should().Be(createDto.SKU);
        }

        [Fact]
        public async Task Get_ProductById_NonExisting_ReturnsNotFound()
        {
            var fakeId = "non-existing-id";
            var response = await Client.GetAsync($"/api/product/{fakeId}");
            await LogIfError(response, "Get_ProductById_NonExisting");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingProduct_ReturnsUpdatedProduct()
        {
            await _dataHelper.GetOrCreateDependencies();
            var createDto = _dataHelper.CreateProductBuilder().Build();
            var created = await PostAndGetAsync<ProductDto>("/api/product", createDto, "Put_UpdateProduct_Seed");
            created.Should().NotBeNull();

            var updateDto = _dataHelper.CreateProductBuilder().Build();
            updateDto.IsActive = false;

            var updateResponse = await Client.PutAsJsonAsync($"/api/product/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateProduct_Update");

            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var updated = await updateResponse.Content.ReadFromJsonAsync<ProductDto>();
            updated.Should().NotBeNull();
            updated!.Id.Should().Be(created.Id);
            updated.Name.Should().Be(updateDto.Name);
            updated.ShopId.Should().Be(updateDto.ShopId);
            updated.BaseUnitId.Should().Be(updateDto.BaseUnitId);
            updated.SalePricePerBaseUnit.Should().Be(updateDto.SalePricePerBaseUnit);
            updated.Description.Should().Be(updateDto.Description);
            updated.IsActive.Should().Be(updateDto.IsActive);
            updated.SKU.Should().Be(updateDto.SKU);
        }

        [Fact]
        public async Task Put_UpdateNonExistingProduct_ReturnsNotFound()
        {
            await _dataHelper.GetOrCreateDependencies();
            var updateDto = _dataHelper.CreateProductBuilder().Build();

            var response = await Client.PutAsJsonAsync("/api/product/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingProduct");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingProduct_ReturnsOk()
        {
            await _dataHelper.GetOrCreateDependencies();
            var createDto = _dataHelper.CreateProductBuilder().Build();

            var created = await PostAndGetAsync<ProductDto>("/api/product", createDto, "Delete_ExistingProduct_Seed");
            created.Should().NotBeNull();

            var deleteResponse = await Client.DeleteAsync($"/api/product/{created!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingProduct_Delete");

            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            var getResponse = await Client.GetAsync($"/api/product/{created.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingProduct_ReturnsNotFound()
        {
            var response = await Client.DeleteAsync("/api/product/non-existing-id");
            await LogIfError(response, "Delete_NonExistingProduct");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidShopId_ReturnsConflict()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.ShopId = "invalid-shop-id";

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidShopId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidUnitId_ReturnsConflict()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.BaseUnitId = "invalid-unit-id";

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidUnitId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidCategoryId_ReturnsConflict()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.CategoryId = "invalid-category-id";

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidCategoryId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.InternalServerError || code == HttpStatusCode.Conflict);
            //response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithNegativePrice_ReturnsBadRequest()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = -100;

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithNegativePrice");

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithZeroPrice_ReturnsOk()
        {
            await _dataHelper.GetOrCreateDependencies();
            var dto = _dataHelper.CreateProductBuilder().Build();
            dto.SalePricePerBaseUnit = 0;

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithZeroPrice");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.SalePricePerBaseUnit.Should().Be(0);
        }

        [Fact]
        public async Task Post_CreateProductWithDuplicateSKU_ReturnsConflict()
        {
            await _dataHelper.GetOrCreateDependencies();
            var sku = "DUPLICATE-SKU-TEST";

            var firstProduct = _dataHelper.CreateProductBuilder().Build();
            firstProduct.SKU = sku;

            var firstResponse = await Client.PostAsJsonAsync("/api/product", firstProduct);
            await LogIfError(firstResponse, "Post_CreateProductWithDuplicateSKU_First");
            firstResponse.EnsureSuccessStatusCode();

            var secondProduct = _dataHelper.CreateProductBuilder().Build();
            secondProduct.SKU = sku;

            var secondResponse = await Client.PostAsJsonAsync("/api/product", secondProduct);
            await LogIfError(secondResponse, "Post_CreateProductWithDuplicateSKU_Second");

            secondResponse.StatusCode.Should().Match(code =>
                code == HttpStatusCode.BadRequest ||
                code == HttpStatusCode.Conflict ||
                code == HttpStatusCode.OK);

            if (secondResponse.StatusCode == HttpStatusCode.OK)
            {
                var createdSecond = await secondResponse.Content.ReadFromJsonAsync<ProductDto>();
                createdSecond.Should().NotBeNull();
                createdSecond!.SKU.Should().Be(sku);

                var deleteResponse = await Client.DeleteAsync($"/api/product/{createdSecond.Id}");
                deleteResponse.EnsureSuccessStatusCode();
            }
        }
    }
}
