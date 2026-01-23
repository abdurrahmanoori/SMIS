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

            // Create a unit of measure
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
    }
}