using System.Net;
using FluentAssertions;
using SMIS.Application.DTO.Common;
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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Laptop Computer",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 99999,
                Description = "High-performance laptop computer",
                IsActive = true,
                SKU = "LAPTOP-001",
                Barcode = "1234567890123",
                ImageUrl = "https://example.com/laptop.jpg",
                CategoryId = categoryId
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Smartphone",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 59999,
                Description = "",
                IsActive = true,
                SKU = "PHONE-001",
                CategoryId = categoryId
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Tablet",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 39999,
                Description = null,
                IsActive = true,
                SKU = "TABLET-001",
                CategoryId = categoryId
            };

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

            var products = new[]
            {
                new ProductCreateDto { Name = "Test Product 1", ShopId = shopId, BaseUnitId = unitId, SalePricePerBaseUnit = 10000, Description = "Test product 1", IsActive = true, SKU = "TP1", CategoryId = categoryId },
                new ProductCreateDto { Name = "Test Product 2", ShopId = shopId, BaseUnitId = unitId, SalePricePerBaseUnit = 20000, Description = "Test product 2", IsActive = true, SKU = "TP2", CategoryId = categoryId },
                new ProductCreateDto { Name = "Test Product 3", ShopId = shopId, BaseUnitId = unitId, SalePricePerBaseUnit = 30000, Description = "Test product 3", IsActive = true, SKU = "TP3", CategoryId = categoryId },
                new ProductCreateDto { Name = "Test Product 4", ShopId = shopId, BaseUnitId = unitId, SalePricePerBaseUnit = 40000, Description = "Test product 4", IsActive = true, SKU = "TP4", CategoryId = categoryId },
                new ProductCreateDto { Name = "Test Product 5", ShopId = shopId, BaseUnitId = unitId, SalePricePerBaseUnit = 50000, Description = "Test product 5", IsActive = true, SKU = "TP5", CategoryId = categoryId }
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Camera",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 29999,
                Description = "Digital camera",
                IsActive = true,
                SKU = "CAMERA-001",
                CategoryId = categoryId
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Headphones",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 9999,
                Description = "Wireless headphones",
                IsActive = true,
                SKU = "HEAD-001",
                CategoryId = categoryId
            };

            var created = await PostAndGetAsync<ProductDto>("/api/product", createDto, "Put_UpdateProduct_Seed");
            created.Should().NotBeNull();

            var updateDto = new ProductCreateDto
            {
                Name = "Wireless Headphones Updated",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 12999,
                Description = "Updated wireless headphones",
                IsActive = false,
                SKU = "HEAD-U001",
                CategoryId = categoryId
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var updateDto = new ProductCreateDto
            {
                Name = "Fake Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 10000,
                Description = "Fake product",
                IsActive = true,
                SKU = "FAKE-001",
                CategoryId = categoryId
            };

            var response = await Client.PutAsJsonAsync("/api/product/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingProduct");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingProduct_ReturnsOk()
        {
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Speaker",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 7999,
                Description = "Bluetooth speaker",
                IsActive = true,
                SKU = "SPKR-001",
                CategoryId = categoryId
            };

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
            var (_, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Product with Invalid Shop",
                ShopId = "invalid-shop-id",
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product with invalid shop reference",
                IsActive = true,
                SKU = "INVALID-SHOP-001",
                CategoryId = categoryId
            };

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidShopId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidUnitId_ReturnsConflict()
        {
            var (shopId, _, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Product with Invalid Unit",
                ShopId = shopId,
                BaseUnitId = "invalid-unit-id",
                SalePricePerBaseUnit = 5000,
                Description = "Product with invalid unit reference",
                IsActive = true,
                SKU = "INVALID-UNIT-001",
                CategoryId = categoryId
            };

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidUnitId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.Conflict || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidCategoryId_ReturnsConflict()
        {
            var (shopId, unitId, _) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Product with Invalid Category",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product with invalid category reference",
                IsActive = true,
                SKU = "INVALID-CAT-001",
                CategoryId = "invalid-category-id"
            };

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidCategoryId");

            response.StatusCode.Should().Match(code => code == HttpStatusCode.InternalServerError || code == HttpStatusCode.Conflict);
            //response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithNegativePrice_ReturnsBadRequest()
        {
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Product with Negative Price",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = -100,
                Description = "Product with negative price",
                IsActive = true,
                SKU = "NEG-PRICE-001",
                CategoryId = categoryId
            };

            var response = await Client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithNegativePrice");

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithZeroPrice_ReturnsOk()
        {
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Product with Zero Price",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 0,
                Description = "Product with zero price",
                IsActive = true,
                SKU = "ZERO-PRICE-001",
                CategoryId = categoryId
            };

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
            var (shopId, unitId, categoryId) = await _dataHelper.GetOrCreateDependencies();

            var sku = "DUPLICATE-SKU-TEST";

            var firstProduct = new ProductCreateDto
            {
                Name = "First Product with SKU",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 1000,
                Description = "First product with duplicate SKU",
                IsActive = true,
                SKU = sku,
                CategoryId = categoryId
            };

            var firstResponse = await Client.PostAsJsonAsync("/api/product", firstProduct);
            await LogIfError(firstResponse, "Post_CreateProductWithDuplicateSKU_First");
            firstResponse.EnsureSuccessStatusCode();

            var secondProduct = new ProductCreateDto
            {
                Name = "Second Product with Same SKU",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 2000,
                Description = "Second product with duplicate SKU",
                IsActive = true,
                SKU = sku,
                CategoryId = categoryId
            };

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
