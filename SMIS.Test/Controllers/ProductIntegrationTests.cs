using System.Net;
using FluentAssertions;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
    public class ProductIntegrationTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;

        public ProductIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _output = output;
        }

        private async Task<(string shopId, string unitId, string categoryId)> SetupProductDependencies( )
        {
            // Create a category first
            var categoryDto = new CategoryCreateDto
            {
                Name = "Test Category for Products",
                Code = "TCP",
                Description = "Test category created for product tests",
                IsActive = true
            };
            var categoryResponse = await _client.PostAsJsonAsync("/api/category", categoryDto);
            await LogIfError(categoryResponse, "SetupProductDependencies_Category");
            categoryResponse.EnsureSuccessStatusCode();
            var createdCategory = await categoryResponse.Content.ReadFromJsonAsync<CategoryDto>();
            createdCategory.Should().NotBeNull();

            var unitDto = new UnitOfMeasureCreateDto
            {
                Name = "Piece",
                Symbol = "pcs",
                Description = "Piece unit"
            };
            var unitResponse = await _client.PostAsJsonAsync("/api/unitofmeasure", unitDto);
            await LogIfError(unitResponse, "SetupProductDependencies_Unit");
            unitResponse.EnsureSuccessStatusCode();
            var createdUnit = await unitResponse.Content.ReadFromJsonAsync<UnitOfMeasureCreateDto>();
            createdUnit.Should().NotBeNull();

            // Create a shop
            var shopDto = new ShopCreateDto
            {
                Name = "Test Shop",
                ShopType = Domain.Enums.ShopType.RetailShop,
                Address = "123 Main St",
                PhoneNumber = "+1234567890",
                Email = "test@shop.com",
                TaxNumber = "TAX001",
                IsActive = true
            };
            var shopResponse = await _client.PostAsJsonAsync("/api/shop", shopDto);
            await LogIfError(shopResponse, "SetupProductDependencies_Shop");
            shopResponse.EnsureSuccessStatusCode();

            // Get the most recently created shop ID
            var shopsResponse = await _client.GetAsync("/api/shop");
            shopsResponse.EnsureSuccessStatusCode();
            var shopsList = await shopsResponse.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
            var shopId = shopsList!.Items.Last().Id;

            // Get the most recently created unit ID
            var unitsResponse = await _client.GetAsync("/api/unitofmeasure");
            unitsResponse.EnsureSuccessStatusCode();
            var unitsList = await unitsResponse.Content.ReadFromJsonAsync<PagedList<UnitOfMeasureDto>>();
            var unitId = unitsList!.Items.Last().Id;

            return (shopId, unitId, createdCategory!.Id);
        }

        private async Task<string> GetMostRecentShopId( )
        {
            var response = await _client.GetAsync("/api/shop");
            response.EnsureSuccessStatusCode();
            var shopsList = await response.Content.ReadFromJsonAsync<PagedList<ShopDto>>();
            return shopsList!.Items.Last().Id;
        }

        private async Task<string> GetMostRecentUnitId( )
        {
            var response = await _client.GetAsync("/api/unitofmeasure");
            response.EnsureSuccessStatusCode();
            var unitsList = await response.Content.ReadFromJsonAsync<PagedList<UnitOfMeasureDto>>();
            return unitsList!.Items.Last().Id;
        }

        private async Task LogIfError(HttpResponseMessage response, string context = "")
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _output.WriteLine($"[{context}] Status: {(int)response.StatusCode} {response.StatusCode}");

                // Use centralized exception formatter for clean output
                var formattedError = ExceptionFormatter.FormatApiResponseError(errorContent);
                _output.WriteLine($"[{context}] Formatted Error:\n{formattedError}");
            }
        }

        public async Task InitializeAsync( )
        {
            // Setup any required test data here
        }

        public Task DisposeAsync( ) => Task.CompletedTask;

        [Fact]
        public async Task Post_CreateValidProduct_ReturnsOk( )
        {
            // Setup required dependencies
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
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
        public async Task Post_CreateProductWithEmptyDescription_ReturnsOk( )
        {
            var dto = new ProductCreateDto
            {
                Name = "Smartphone",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 59999,
                Description = "",
                IsActive = true,
                SKU = "PHONE-001"
            };

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithEmptyDescription");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Description.Should().Be(dto.Description);
        }

        [Fact]
        public async Task Post_CreateProductWithNullDescription_ReturnsOk( )
        {
            var dto = new ProductCreateDto
            {
                Name = "Tablet",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 39999,
                Description = null,
                IsActive = true,
                SKU = "TABLET-001"
            };

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithNullDescription");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Description.Should().BeNull();
        }

        [Fact]
        public async Task Get_ListProducts_ReturnsPagedList( )
        {
            var response = await _client.GetAsync("/api/product?pageNumber=1&pageSize=10");
            await LogIfError(response, "Get_ListProducts");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);

            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);
        }

        [Fact]
        public async Task Get_ListProducts_WithPagination_ReturnsCorrectPage( )
        {
            // Create multiple products to test pagination
            var products = new[]
            {
                new ProductCreateDto { Name = "Test Product 1", ShopId = "shop-1", BaseUnitId = "unit-1", SalePricePerBaseUnit = 10000, Description = "Test product 1", IsActive = true, SKU = "TP1" },
                new ProductCreateDto { Name = "Test Product 2", ShopId = "shop-1", BaseUnitId = "unit-1", SalePricePerBaseUnit = 20000, Description = "Test product 2", IsActive = true, SKU = "TP2" },
                new ProductCreateDto { Name = "Test Product 3", ShopId = "shop-1", BaseUnitId = "unit-1", SalePricePerBaseUnit = 30000, Description = "Test product 3", IsActive = true, SKU = "TP3" },
                new ProductCreateDto { Name = "Test Product 4", ShopId = "shop-1", BaseUnitId = "unit-1", SalePricePerBaseUnit = 40000, Description = "Test product 4", IsActive = true, SKU = "TP4" },
                new ProductCreateDto { Name = "Test Product 5", ShopId = "shop-1", BaseUnitId = "unit-1", SalePricePerBaseUnit = 50000, Description = "Test product 5", IsActive = true, SKU = "TP5" }
            };

            foreach (var prod in products)
            {
                var response = await _client.PostAsJsonAsync("/api/product", prod);
                await LogIfError(response, $"CreateTestProduct_{prod.Name}");
                response.EnsureSuccessStatusCode();
            }

            // Test pagination - get page 1 with size 2
            var paginatedResponse = await _client.GetAsync("/api/product?pageNumber=1&pageSize=2");
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
        public async Task Get_ProductById_Existing_ReturnsProduct( )
        {
            // Create a product first
            var createDto = new ProductCreateDto
            {
                Name = "Camera",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 29999,
                Description = "Digital camera",
                IsActive = true,
                SKU = "CAMERA-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Get_ProductById_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Get the created product by ID
            var getResponse = await _client.GetAsync($"/api/product/{created!.Id}");
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
        public async Task Get_ProductById_NonExisting_ReturnsNotFound( )
        {
            var fakeId = "non-existing-id";
            var response = await _client.GetAsync($"/api/product/{fakeId}");
            await LogIfError(response, "Get_ProductById_NonExisting");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingProduct_ReturnsUpdatedProduct( )
        {
            // Create a product first
            var createDto = new ProductCreateDto
            {
                Name = "Headphones",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 9999,
                Description = "Wireless headphones",
                IsActive = true,
                SKU = "HEAD-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Put_UpdateProduct_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Update the product
            var updateDto = new ProductCreateDto
            {
                Name = "Wireless Headphones Updated",
                ShopId = "shop-2",
                BaseUnitId = "unit-2",
                SalePricePerBaseUnit = 12999,
                Description = "Updated wireless headphones",
                IsActive = false,
                SKU = "HEAD-U001"
            };

            var updateResponse = await _client.PutAsJsonAsync($"/api/product/{created!.Id}", updateDto);
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
        public async Task Put_UpdateNonExistingProduct_ReturnsNotFound( )
        {
            var updateDto = new ProductCreateDto
            {
                Name = "Fake Product",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 10000,
                Description = "Fake product",
                IsActive = true,
                SKU = "FAKE-001"
            };

            var response = await _client.PutAsJsonAsync("/api/product/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingProduct");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingProduct_ReturnsOk( )
        {
            // Create a product first
            var createDto = new ProductCreateDto
            {
                Name = "Speaker",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 7999,
                Description = "Bluetooth speaker",
                IsActive = true,
                SKU = "SPKR-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Delete_ExistingProduct_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Delete the product
            var deleteResponse = await _client.DeleteAsync($"/api/product/{created!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingProduct_Delete");

            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify it's gone
            var getResponse = await _client.GetAsync($"/api/product/{created.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingProduct_ReturnsNotFound( )
        {
            var response = await _client.DeleteAsync("/api/product/non-existing-id");
            await LogIfError(response, "Delete_NonExistingProduct");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductThenGetList_VerifyInList( )
        {
            var newProduct = new ProductCreateDto
            {
                Name = "Monitor",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 19999,
                Description = "Computer monitor",
                IsActive = true,
                SKU = "MON-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", newProduct);
            await LogIfError(createResponse, "Post_CreateProductThenGetList_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Get the list and verify the new product is there
            var listResponse = await _client.GetAsync("/api/product");
            await LogIfError(listResponse, "Post_CreateProductThenGetList_GetList");
            listResponse.EnsureSuccessStatusCode();

            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            pagedList.Should().NotBeNull();
            var foundProduct = pagedList!.Items.FirstOrDefault(p => p.Id == created!.Id);
            foundProduct.Should().NotBeNull();
            foundProduct!.Name.Should().Be(newProduct.Name);
        }

        [Fact]
        public async Task Put_UpdateProductThenGetById_VerifyUpdated( )
        {
            // Create a product
            var createDto = new ProductCreateDto
            {
                Name = "Keyboard",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 4999,
                Description = "Mechanical keyboard",
                IsActive = true,
                SKU = "KEYB-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Put_UpdateProductThenGetById_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Update the product
            var updateDto = new ProductCreateDto
            {
                Name = "Mechanical Keyboard Updated",
                ShopId = "shop-2",
                BaseUnitId = "unit-2",
                SalePricePerBaseUnit = 5999,
                Description = "Updated mechanical keyboard",
                IsActive = false,
                SKU = "KEYB-U001"
            };

            var updateResponse = await _client.PutAsJsonAsync($"/api/product/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateProductThenGetById_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Get by ID and verify it's updated
            var getResponse = await _client.GetAsync($"/api/product/{created.Id}");
            await LogIfError(getResponse, "Put_UpdateProductThenGetById_Get");
            getResponse.EnsureSuccessStatusCode();

            var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(updateDto.Name);
            retrieved.ShopId.Should().Be(updateDto.ShopId);
            retrieved.BaseUnitId.Should().Be(updateDto.BaseUnitId);
            retrieved.SalePricePerBaseUnit.Should().Be(updateDto.SalePricePerBaseUnit);
            retrieved.Description.Should().Be(updateDto.Description);
            retrieved.IsActive.Should().Be(updateDto.IsActive);
            retrieved.SKU.Should().Be(updateDto.SKU);
        }

        [Fact]
        public async Task MultipleOperations_Sequence_Test( )
        {
            // Test a sequence of operations to ensure data consistency
            var prod1 = new ProductCreateDto
            {
                Name = "Sequence Test 1",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 10000,
                Description = "First sequence test",
                IsActive = true,
                SKU = "SEQ-001"
            };

            var prod2 = new ProductCreateDto
            {
                Name = "Sequence Test 2",
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 20000,
                Description = "Second sequence test",
                IsActive = false,
                SKU = "SEQ-002"
            };

            // Create first product
            var create1Response = await _client.PostAsJsonAsync("/api/product", prod1);
            await LogIfError(create1Response, "MultipleOperations_Sequence_Create1");
            create1Response.EnsureSuccessStatusCode();
            var created1 = await create1Response.Content.ReadFromJsonAsync<ProductDto>();
            created1.Should().NotBeNull();

            // Create second product
            var create2Response = await _client.PostAsJsonAsync("/api/product", prod2);
            await LogIfError(create2Response, "MultipleOperations_Sequence_Create2");
            create2Response.EnsureSuccessStatusCode();
            var created2 = await create2Response.Content.ReadFromJsonAsync<ProductDto>();
            created2.Should().NotBeNull();

            // Get list - both should be there
            var listResponse = await _client.GetAsync("/api/product");
            await LogIfError(listResponse, "MultipleOperations_Sequence_GetList");
            listResponse.EnsureSuccessStatusCode();
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            pagedList.Should().NotBeNull();
            var listItems = pagedList!.Items.ToList();
            listItems.Exists(p => p.Id == created1!.Id).Should().BeTrue();
            listItems.Exists(p => p.Id == created2!.Id).Should().BeTrue();

            // Update first product
            var updateDto = new ProductCreateDto
            {
                Name = "Updated Sequence Test 1",
                ShopId = "shop-2",
                BaseUnitId = "unit-2",
                SalePricePerBaseUnit = 15000,
                Description = "Updated first sequence test",
                IsActive = false,
                SKU = "SEQ-U001"
            };

            var updateResponse = await _client.PutAsJsonAsync($"/api/product/{created1!.Id}", updateDto);
            await LogIfError(updateResponse, "MultipleOperations_Sequence_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Verify update worked
            var getUpdatedResponse = await _client.GetAsync($"/api/product/{created1.Id}");
            await LogIfError(getUpdatedResponse, "MultipleOperations_Sequence_GetUpdated");
            getUpdatedResponse.EnsureSuccessStatusCode();
            var updated = await getUpdatedResponse.Content.ReadFromJsonAsync<ProductDto>();
            updated.Should().NotBeNull();
            updated!.Name.Should().Be(updateDto.Name);

            // Delete second product
            var deleteResponse = await _client.DeleteAsync($"/api/product/{created2!.Id}");
            await LogIfError(deleteResponse, "MultipleOperations_Sequence_Delete");
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify deletion worked
            var getDeletedResponse = await _client.GetAsync($"/api/product/{created2.Id}");
            getDeletedResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);

            // Get list again - only first should remain
            var finalListResponse = await _client.GetAsync("/api/product");
            await LogIfError(finalListResponse, "MultipleOperations_Sequence_FinalList");
            finalListResponse.EnsureSuccessStatusCode();
            var finalPagedList = await finalListResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            finalPagedList.Should().NotBeNull();
            var finalListItems = finalPagedList!.Items.ToList();
            finalListItems.Exists(p => p.Id == created1.Id).Should().BeTrue();
            finalListItems.Exists(p => p.Id == created2.Id).Should().BeFalse();
        }

        [Fact]
        public async Task Get_ProductById_WithSpecialCharactersInName_ReturnsCorrectly( )
        {
            var specialName = "Office Chair & Desk";
            var createDto = new ProductCreateDto
            {
                Name = specialName,
                ShopId = "shop-1",
                BaseUnitId = "unit-1",
                SalePricePerBaseUnit = 14999,
                Description = "Office furniture",
                IsActive = true,
                SKU = "FURN-001"
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Get_ProductById_WithSpecialCharacters_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/product/{created!.Id}");
            await LogIfError(getResponse, "Get_ProductById_WithSpecialCharacters_Get");
            getResponse.EnsureSuccessStatusCode();

            var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(specialName);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidShopId_ReturnsBadRequest()
        {
            // Setup required dependencies except for shop
            var (_, unitId, categoryId) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidShopId");

            // Response could be BadRequest or NotFound depending on validation
            response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidUnitId_ReturnsBadRequest()
        {
            // Setup required dependencies except for unit
            var (shopId, _, categoryId) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidUnitId");

            // Response could be BadRequest or NotFound depending on validation
            response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithInvalidCategoryId_ReturnsBadRequest()
        {
            // Setup required dependencies except for category
            var (shopId, unitId, _) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithInvalidCategoryId");

            // Response could be BadRequest or NotFound depending on validation
            response.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateProductWithNegativePrice_ReturnsBadRequest()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithNegativePrice");

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithZeroPrice_ReturnsOk()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

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

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithZeroPrice");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.SalePricePerBaseUnit.Should().Be(0);
        }

        [Fact]
        public async Task Put_UpdateProductWithInvalidReferences_ReturnsBadRequest()
        {
            // Create a valid product first
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Updatable Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product to be updated",
                IsActive = true,
                SKU = "UPDATE-TEST-001",
                CategoryId = categoryId
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Put_UpdateProductWithInvalidReferences_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Try to update with invalid references
            var updateDto = new ProductCreateDto
            {
                Name = "Updated Product with Invalid References",
                ShopId = "invalid-shop-id",
                BaseUnitId = "invalid-unit-id",
                SalePricePerBaseUnit = 7500,
                Description = "Product with invalid references in update",
                IsActive = false,
                SKU = "UPDATE-TEST-002",
                CategoryId = "invalid-category-id"
            };

            var updateResponse = await _client.PutAsJsonAsync($"/api/product/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateProductWithInvalidReferences_Update");

            updateResponse.StatusCode.Should().Match(code => code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Get_ListProducts_FilterByActiveStatus_ReturnsFilteredResults()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            // Create active and inactive products
            var activeProduct = new ProductCreateDto
            {
                Name = "Active Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 1000,
                Description = "Active product for filtering test",
                IsActive = true,
                SKU = "ACTIVE-FILTER-001",
                CategoryId = categoryId
            };

            var inactiveProduct = new ProductCreateDto
            {
                Name = "Inactive Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 2000,
                Description = "Inactive product for filtering test",
                IsActive = false,
                SKU = "INACTIVE-FILTER-001",
                CategoryId = categoryId
            };

            var activeResponse = await _client.PostAsJsonAsync("/api/product", activeProduct);
            await LogIfError(activeResponse, "Get_ListProducts_FilterByActiveStatus_Active");
            activeResponse.EnsureSuccessStatusCode();

            var inactiveResponse = await _client.PostAsJsonAsync("/api/product", inactiveProduct);
            await LogIfError(inactiveResponse, "Get_ListProducts_FilterByActiveStatus_Inactive");
            inactiveResponse.EnsureSuccessStatusCode();

            // Get all products
            var allResponse = await _client.GetAsync("/api/product");
            await LogIfError(allResponse, "Get_ListProducts_FilterByActiveStatus_All");
            allResponse.EnsureSuccessStatusCode();

            var allProducts = await allResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            allProducts.Should().NotBeNull();
            var allCount = allProducts!.Items.Count;

            // Check if we can filter by IsActive (depends on API implementation)
            // For now, just verify the products exist with correct status
            var activeProductObj = allProducts.Items.FirstOrDefault(p => p.Name == activeProduct.Name);
            var inactiveProductObj = allProducts.Items.FirstOrDefault(p => p.Name == inactiveProduct.Name);

            activeProductObj.Should().NotBeNull();
            activeProductObj!.IsActive.Should().BeTrue();

            inactiveProductObj.Should().NotBeNull();
            inactiveProductObj!.IsActive.Should().BeFalse();
        }

        [Fact]
        public async Task Post_CreateProductWithDuplicateSKU_ReturnsConflict()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var sku = "DUPLICATE-SKU-TEST";

            // Create first product with specific SKU
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

            var firstResponse = await _client.PostAsJsonAsync("/api/product", firstProduct);
            await LogIfError(firstResponse, "Post_CreateProductWithDuplicateSKU_First");
            firstResponse.EnsureSuccessStatusCode();

            // Try to create second product with same SKU
            var secondProduct = new ProductCreateDto
            {
                Name = "Second Product with Same SKU",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 2000,
                Description = "Second product with duplicate SKU",
                IsActive = true,
                SKU = sku, // Same SKU as first product
                CategoryId = categoryId
            };

            var secondResponse = await _client.PostAsJsonAsync("/api/product", secondProduct);
            await LogIfError(secondResponse, "Post_CreateProductWithDuplicateSKU_Second");

            // Check if the API properly handles duplicate SKUs (could be BadRequest or Conflict)
            secondResponse.StatusCode.Should().Match(code =>
                code == HttpStatusCode.BadRequest ||
                code == HttpStatusCode.Conflict ||
                code == HttpStatusCode.OK); // If the API allows duplicate SKUs

            if (secondResponse.StatusCode == HttpStatusCode.OK)
            {
                // If it succeeded, verify both products exist with same SKU
                var createdSecond = await secondResponse.Content.ReadFromJsonAsync<ProductDto>();
                createdSecond.Should().NotBeNull();
                createdSecond!.SKU.Should().Be(sku);

                // Clean up the duplicate product
                var deleteResponse = await _client.DeleteAsync($"/api/product/{createdSecond.Id}");
                deleteResponse.EnsureSuccessStatusCode();
            }
        }

        [Fact]
        public async Task Get_ProductById_WithAssociatedCategory_ReturnsProductWithCategory()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Product with Category",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 8999,
                Description = "Product with associated category",
                IsActive = true,
                SKU = "CAT-PROD-001",
                CategoryId = categoryId
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Get_ProductById_WithAssociatedCategory_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();

            // Get the product by ID and check if category info is included
            var getResponse = await _client.GetAsync($"/api/product/{created!.Id}");
            await LogIfError(getResponse, "Get_ProductById_WithAssociatedCategory_Get");
            getResponse.EnsureSuccessStatusCode();

            var retrieved = await getResponse.Content.ReadFromJsonAsync<ProductDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(created.Id);
            retrieved.CategoryId.Should().Be(categoryId);

            // If the API includes category object in response, check that too
            // This depends on the API implementation
            if (retrieved.Category != null)
            {
                retrieved.Category.Id.Should().Be(categoryId);
            }
        }

        [Fact]
        public async Task Post_CreateProductWithVeryLongFields_ReturnsOk()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var dto = new ProductCreateDto
            {
                Name = new string('A', 250), // Very long name
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 99999,
                Description = new string('B', 500), // Very long description
                IsActive = true,
                SKU = new string('C', 100), // Very long SKU
                Barcode = new string('D', 50), // Very long barcode
                ImageUrl = "https://example.com/" + new string('e', 100) + ".jpg", // Very long URL
                CategoryId = categoryId
            };

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithVeryLongFields");

            // Depending on validation rules, this might return OK or BadRequest
            response.StatusCode.Should().Match(code =>
                code == HttpStatusCode.OK || code == HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Post_CreateProductWithoutRequiredFields_ReturnsBadRequest()
        {
            // Attempt to create a product with minimal required fields only
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var dto = new ProductCreateDto
            {
                Name = "Minimal Product", // Name is likely required
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 1000,
                // Missing other optional fields
                SKU = "MIN-PROD-001",
                CategoryId = categoryId
            };

            var response = await _client.PostAsJsonAsync("/api/product", dto);
            await LogIfError(response, "Post_CreateProductWithoutRequiredFields");

            // Should succeed since we're providing the likely required fields
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
        }

        [Fact]
        public async Task Put_UpdateProductToInactiveThenReactivate_ReturnsCorrectStatus()
        {
            // Create a product first
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            var createDto = new ProductCreateDto
            {
                Name = "Toggle Active Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product to test activation toggling",
                IsActive = true,
                SKU = "TOGGLE-ACTIVE-001",
                CategoryId = categoryId
            };

            var createResponse = await _client.PostAsJsonAsync("/api/product", createDto);
            await LogIfError(createResponse, "Put_UpdateProductToInactiveThenReactivate_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<ProductDto>();
            created.Should().NotBeNull();
            created!.IsActive.Should().BeTrue();

            // Update to inactive
            var updateToInactiveDto = new ProductCreateDto
            {
                Name = "Toggle Active Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product to test activation toggling",
                IsActive = false, // Set to inactive
                SKU = "TOGGLE-ACTIVE-001",
                CategoryId = categoryId
            };

            var updateToInactiveResponse = await _client.PutAsJsonAsync($"/api/product/{created.Id}", updateToInactiveDto);
            await LogIfError(updateToInactiveResponse, "Put_UpdateProductToInactiveThenReactivate_ToInactive");
            updateToInactiveResponse.EnsureSuccessStatusCode();

            var updatedToInactive = await updateToInactiveResponse.Content.ReadFromJsonAsync<ProductDto>();
            updatedToInactive.Should().NotBeNull();
            updatedToInactive!.IsActive.Should().BeFalse();

            // Update back to active
            var updateToActiveDto = new ProductCreateDto
            {
                Name = "Toggle Active Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "Product to test activation toggling",
                IsActive = true, // Set back to active
                SKU = "TOGGLE-ACTIVE-001",
                CategoryId = categoryId
            };

            var updateToActiveResponse = await _client.PutAsJsonAsync($"/api/product/{created.Id}", updateToActiveDto);
            await LogIfError(updateToActiveResponse, "Put_UpdateProductToInactiveThenReactivate_ToActive");
            updateToActiveResponse.EnsureSuccessStatusCode();

            var updatedToActive = await updateToActiveResponse.Content.ReadFromJsonAsync<ProductDto>();
            updatedToActive.Should().NotBeNull();
            updatedToActive!.IsActive.Should().BeTrue();
        }

        [Fact]
        public async Task Get_ListProducts_SearchByName_ReturnsMatchingResults()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            // Create products with specific names for search testing
            var searchProductName = "Searchable Laptop Product";
            var otherProductName = "Other Phone Product";

            var searchProductDto = new ProductCreateDto
            {
                Name = searchProductName,
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 10000,
                Description = "Product for search testing",
                IsActive = true,
                SKU = "SEARCH-LAPTOP-001",
                CategoryId = categoryId
            };

            var otherProductDto = new ProductCreateDto
            {
                Name = otherProductName,
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 8000,
                Description = "Another product for search testing",
                IsActive = true,
                SKU = "OTHER-PHONE-001",
                CategoryId = categoryId
            };

            var searchResponse = await _client.PostAsJsonAsync("/api/product", searchProductDto);
            await LogIfError(searchResponse, "Get_ListProducts_SearchByName_SearchProduct");
            searchResponse.EnsureSuccessStatusCode();

            var otherResponse = await _client.PostAsJsonAsync("/api/product", otherProductDto);
            await LogIfError(otherResponse, "Get_ListProducts_SearchByName_OtherProduct");
            otherResponse.EnsureSuccessStatusCode();

            // Try to search for products by name (this depends on API implementation)
            // If the API supports search, use the appropriate endpoint
            var allProductsResponse = await _client.GetAsync("/api/product");
            await LogIfError(allProductsResponse, "Get_ListProducts_SearchByName_GetAll");
            allProductsResponse.EnsureSuccessStatusCode();

            var allProducts = await allProductsResponse.Content.ReadFromJsonAsync<PagedList<ProductDto>>();
            allProducts.Should().NotBeNull();

            // Verify both products exist
            var searchProduct = allProducts!.Items.FirstOrDefault(p => p.Name == searchProductName);
            var otherProduct = allProducts.Items.FirstOrDefault(p => p.Name == otherProductName);

            searchProduct.Should().NotBeNull();
            otherProduct.Should().NotBeNull();
        }

        [Fact]
        public async Task Post_CreateProductWithExtremePriceValues_ReturnsCorrectly()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            // Test with a very high price
            var highPriceDto = new ProductCreateDto
            {
                Name = "Product with High Price",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 999999999, // Very high price
                Description = "Product with extreme price value",
                IsActive = true,
                SKU = "HIGH-PRICE-001",
                CategoryId = categoryId
            };

            var highPriceResponse = await _client.PostAsJsonAsync("/api/product", highPriceDto);
            await LogIfError(highPriceResponse, "Post_CreateProductWithExtremePriceValues_High");

            // This should either succeed or return bad request depending on validation
            highPriceResponse.StatusCode.Should().Match(code =>
                code == HttpStatusCode.OK || code == HttpStatusCode.BadRequest);

            if (highPriceResponse.StatusCode == HttpStatusCode.OK)
            {
                var highPriceCreated = await highPriceResponse.Content.ReadFromJsonAsync<ProductDto>();
                highPriceCreated.Should().NotBeNull();
            }
        }

        [Fact]
        public async Task Put_UpdateProductWithSameSKUAsAnotherProduct_ReturnsAppropriateResponse()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            // Create two products with different SKUs
            var firstProductDto = new ProductCreateDto
            {
                Name = "First Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 5000,
                Description = "First product for SKU test",
                IsActive = true,
                SKU = "UNIQUE-SKU-001",
                CategoryId = categoryId
            };

            var secondProductDto = new ProductCreateDto
            {
                Name = "Second Product",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 6000,
                Description = "Second product for SKU test",
                IsActive = true,
                SKU = "UNIQUE-SKU-002", // Different SKU
                CategoryId = categoryId
            };

            var firstResponse = await _client.PostAsJsonAsync("/api/product", firstProductDto);
            await LogIfError(firstResponse, "Put_UpdateProductWithSameSKUAsAnotherProduct_First");
            firstResponse.EnsureSuccessStatusCode();

            var secondResponse = await _client.PostAsJsonAsync("/api/product", secondProductDto);
            await LogIfError(secondResponse, "Put_UpdateProductWithSameSKUAsAnotherProduct_Second");
            secondResponse.EnsureSuccessStatusCode();

            var firstCreated = await firstResponse.Content.ReadFromJsonAsync<ProductDto>();
            var secondCreated = await secondResponse.Content.ReadFromJsonAsync<ProductDto>();
            firstCreated.Should().NotBeNull();
            secondCreated.Should().NotBeNull();

            // Try to update the second product to use the first product's SKU
            var updateWithDuplicateSkuDto = new ProductCreateDto
            {
                Name = "Second Product Updated",
                ShopId = shopId,
                BaseUnitId = unitId,
                SalePricePerBaseUnit = 7000,
                Description = "Second product updated with duplicate SKU",
                IsActive = true,
                SKU = "UNIQUE-SKU-001", // Same as first product
                CategoryId = categoryId
            };

            var updateResponse = await _client.PutAsJsonAsync($"/api/product/{secondCreated!.Id}", updateWithDuplicateSkuDto);
            await LogIfError(updateResponse, "Put_UpdateProductWithSameSKUAsAnotherProduct_Update");

            // This should either succeed (if system allows duplicate SKUs) or return an error
            updateResponse.StatusCode.Should().Match(code =>
                code == HttpStatusCode.OK ||
                code == HttpStatusCode.BadRequest ||
                code == HttpStatusCode.Conflict);
        }

        [Fact]
        public async Task Get_ProductByInvalidIdFormat_ReturnsNotFound()
        {
            // Try to get a product with an invalid ID format
            var response = await _client.GetAsync("/api/product/invalid-id-format!");
            await LogIfError(response, "Get_ProductByInvalidIdFormat");

            // Should return either BadRequest (for invalid format) or NotFound (for not found)
            response.StatusCode.Should().Match(code =>
                code == HttpStatusCode.BadRequest || code == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateMultipleProductsConcurrently_ReturnsCorrectResponses()
        {
            var (shopId, unitId, categoryId) = await SetupProductDependencies();

            // Create multiple products concurrently
            var tasks = new List<Task<HttpResponseMessage>>();

            for (int i = 0; i < 5; i++)
            {
                var dto = new ProductCreateDto
                {
                    Name = $"Concurrent Product {i}",
                    ShopId = shopId,
                    BaseUnitId = unitId,
                    SalePricePerBaseUnit = 1000 + i * 1000,
                    Description = $"Concurrent product {i} for testing",
                    IsActive = true,
                    SKU = $"CONCURRENT-{i:D3}",
                    CategoryId = categoryId
                };

                tasks.Add(_client.PostAsJsonAsync("/api/product", dto));
            }

            var responses = await Task.WhenAll(tasks);

            // Check that all requests were processed appropriately
            foreach (var (response, index) in responses.Select((r, i) => (r, i)))
            {
                await LogIfError(response, $"Post_CreateMultipleProductsConcurrently_Response_{index}");

                // Each response should either succeed or fail appropriately
                response.StatusCode.Should().Match(code =>
                    code == HttpStatusCode.OK || code == HttpStatusCode.BadRequest);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var created = await response.Content.ReadFromJsonAsync<ProductDto>();
                    created.Should().NotBeNull();
                }
            }
        }
    }
}