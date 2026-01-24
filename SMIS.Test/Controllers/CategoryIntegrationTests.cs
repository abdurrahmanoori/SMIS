using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
    public class CategoryIntegrationTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;

        public CategoryIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _output = output;
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

        public Task InitializeAsync() => Task.CompletedTask;
        public Task DisposeAsync() => Task.CompletedTask;

        [Fact]
        public async Task Post_CreateValidCategory_ReturnsOk()
        {
            var dto = new CategoryCreateDto { Name = "Electronics", Code = "ELEC", Description = "Electronic devices", IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/category", dto);
            await LogIfError(response, "Post_CreateValidCategory");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().Be(dto.Code);
            created.Description.Should().Be(dto.Description);
            created.IsActive.Should().Be(dto.IsActive);
        }

        [Fact]
        public async Task Post_CreateCategoryWithEmptyCode_ReturnsOk()
        {
            var dto = new CategoryCreateDto { Name = "Books", Code = "", Description = "Various books", IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/category", dto);
            await LogIfError(response, "Post_CreateCategoryWithEmptyCode");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().Be(dto.Code);
        }

        [Fact]
        public async Task Post_CreateCategoryWithNullCode_ReturnsOk()
        {
            var dto = new CategoryCreateDto { Name = "Clothing", Code = null, Description = "Clothing items", IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/category", dto);
            await LogIfError(response, "Post_CreateCategoryWithNullCode");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().BeNull();
        }

        [Fact]
        public async Task Get_ListCategories_ReturnsPagedList()
        {
            var response = await _client.GetAsync("/api/category?pageNumber=1&pageSize=10");
            await LogIfError(response, "Get_ListCategories");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0); // Could be empty initially
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);
        }

        [Fact]
        public async Task Get_ListCategories_WithPagination_ReturnsCorrectPage()
        {
            // Create multiple categories to test pagination
            var categories = new[]
            {
                new CategoryCreateDto { Name = "Test Cat 1", Code = "TC1", Description = "Test category 1", IsActive = true },
                new CategoryCreateDto { Name = "Test Cat 2", Code = "TC2", Description = "Test category 2", IsActive = true },
                new CategoryCreateDto { Name = "Test Cat 3", Code = "TC3", Description = "Test category 3", IsActive = true },
                new CategoryCreateDto { Name = "Test Cat 4", Code = "TC4", Description = "Test category 4", IsActive = true },
                new CategoryCreateDto { Name = "Test Cat 5", Code = "TC5", Description = "Test category 5", IsActive = true }
            };

            foreach (var cat in categories)
            {
                var response = await _client.PostAsJsonAsync("/api/category", cat);
                await LogIfError(response, $"CreateTestCategory_{cat.Name}");
                response.EnsureSuccessStatusCode();
            }

            // Test pagination - get page 1 with size 2
            var paginatedResponse = await _client.GetAsync("/api/category?pageNumber=1&pageSize=2");
            await LogIfError(paginatedResponse, "Get_ListCategories_Pagination");
            
            paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Count.Should().BeLessOrEqualTo(2);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(2);
            paged.TotalCount.Should().BeGreaterOrEqualTo(5);
        }

        [Fact]
        public async Task Get_CategoryById_Existing_ReturnsCategory()
        {
            // Create a category first
            var createDto = new CategoryCreateDto { Name = "Furniture", Code = "FUR", Description = "Furniture items", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", createDto);
            await LogIfError(createResponse, "Get_CategoryById_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            // Get the created category by ID
            var getResponse = await _client.GetAsync($"/api/category/{created!.Id}");
            await LogIfError(getResponse, "Get_CategoryById_Get");
            
            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var retrieved = await getResponse.Content.ReadFromJsonAsync<CategoryDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(created.Id);
            retrieved.Name.Should().Be(createDto.Name);
            retrieved.Code.Should().Be(createDto.Code);
            retrieved.Description.Should().Be(createDto.Description);
            retrieved.IsActive.Should().Be(createDto.IsActive);
        }

        [Fact]
        public async Task Get_CategoryById_NonExisting_ReturnsNotFound()
        {
            var fakeId = "non-existing-id";
            var response = await _client.GetAsync($"/api/category/{fakeId}");
            await LogIfError(response, "Get_CategoryById_NonExisting");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingCategory_ReturnsUpdatedCategory()
        {
            // Create a category first
            var createDto = new CategoryCreateDto { Name = "Sports", Code = "SPRT", Description = "Sports equipment", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", createDto);
            await LogIfError(createResponse, "Put_UpdateCategory_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            // Update the category
            var updateDto = new CategoryCreateDto { Name = "Sports Equipment Updated", Code = "SPRT-U", Description = "Updated sports equipment", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/category/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateCategory_Update");
            
            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var updated = await updateResponse.Content.ReadFromJsonAsync<CategoryDto>();
            updated.Should().NotBeNull();
            updated!.Id.Should().Be(created.Id);
            updated.Name.Should().Be(updateDto.Name);
            updated.Code.Should().Be(updateDto.Code);
            updated.Description.Should().Be(updateDto.Description);
            updated.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task Put_UpdateNonExistingCategory_ReturnsNotFound()
        {
            var updateDto = new CategoryCreateDto { Name = "Fake Category", Code = "FC", Description = "Fake category", IsActive = true };
            var response = await _client.PutAsJsonAsync("/api/category/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingCategory");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingCategory_ReturnsOk()
        {
            // Create a category first
            var createDto = new CategoryCreateDto { Name = "Toys", Code = "TOY", Description = "Toy items", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", createDto);
            await LogIfError(createResponse, "Delete_ExistingCategory_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            // Delete the category
            var deleteResponse = await _client.DeleteAsync($"/api/category/{created!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingCategory_Delete");
            
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify it's gone
            var getResponse = await _client.GetAsync($"/api/category/{created.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingCategory_ReturnsNotFound()
        {
            var response = await _client.DeleteAsync("/api/category/non-existing-id");
            await LogIfError(response, "Delete_NonExistingCategory");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateCategoryThenGetList_VerifyInList()
        {
            var newCategory = new CategoryCreateDto { Name = "Automotive", Code = "AUTO", Description = "Automotive parts", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", newCategory);
            await LogIfError(createResponse, "Post_CreateCategoryThenGetList_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            // Get the list and verify the new category is there
            var listResponse = await _client.GetAsync("/api/category");
            await LogIfError(listResponse, "Post_CreateCategoryThenGetList_GetList");
            listResponse.EnsureSuccessStatusCode();
            
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
            pagedList.Should().NotBeNull();
            var foundCategory = pagedList!.Items.FirstOrDefault(c => c.Id == created!.Id);
            foundCategory.Should().NotBeNull();
            foundCategory!.Name.Should().Be(newCategory.Name);
        }

        [Fact]
        public async Task Put_UpdateCategoryThenGetById_VerifyUpdated()
        {
            // Create a category
            var createDto = new CategoryCreateDto { Name = "Garden", Code = "GDN", Description = "Garden supplies", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", createDto);
            await LogIfError(createResponse, "Put_UpdateCategoryThenGetById_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            // Update the category
            var updateDto = new CategoryCreateDto { Name = "Garden Supplies Updated", Code = "GDN-U", Description = "Updated garden supplies", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/category/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateCategoryThenGetById_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Get by ID and verify it's updated
            var getResponse = await _client.GetAsync($"/api/category/{created.Id}");
            await LogIfError(getResponse, "Put_UpdateCategoryThenGetById_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<CategoryDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(updateDto.Name);
            retrieved.Code.Should().Be(updateDto.Code);
            retrieved.Description.Should().Be(updateDto.Description);
            retrieved.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task MultipleOperations_Sequence_Test()
        {
            // Test a sequence of operations to ensure data consistency
            var cat1 = new CategoryCreateDto { Name = "Sequence Test 1", Code = "ST1", Description = "First sequence test", IsActive = true };
            var cat2 = new CategoryCreateDto { Name = "Sequence Test 2", Code = "ST2", Description = "Second sequence test", IsActive = false };

            // Create first category
            var create1Response = await _client.PostAsJsonAsync("/api/category", cat1);
            await LogIfError(create1Response, "MultipleOperations_Sequence_Create1");
            create1Response.EnsureSuccessStatusCode();
            var created1 = await create1Response.Content.ReadFromJsonAsync<CategoryDto>();
            created1.Should().NotBeNull();

            // Create second category
            var create2Response = await _client.PostAsJsonAsync("/api/category", cat2);
            await LogIfError(create2Response, "MultipleOperations_Sequence_Create2");
            create2Response.EnsureSuccessStatusCode();
            var created2 = await create2Response.Content.ReadFromJsonAsync<CategoryDto>();
            created2.Should().NotBeNull();

            // Get list - both should be there
            var listResponse = await _client.GetAsync("/api/category");
            await LogIfError(listResponse, "MultipleOperations_Sequence_GetList");
            listResponse.EnsureSuccessStatusCode();
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
            pagedList.Should().NotBeNull();
            var listItems = pagedList!.Items.ToList();
            listItems.Exists(c => c.Id == created1!.Id).Should().BeTrue();
            listItems.Exists(c => c.Id == created2!.Id).Should().BeTrue();

            // Update first category
            var updateDto = new CategoryCreateDto { Name = "Updated Sequence Test 1", Code = "UST1", Description = "Updated first sequence test", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/category/{created1!.Id}", updateDto);
            await LogIfError(updateResponse, "MultipleOperations_Sequence_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Verify update worked
            var getUpdatedResponse = await _client.GetAsync($"/api/category/{created1.Id}");
            await LogIfError(getUpdatedResponse, "MultipleOperations_Sequence_GetUpdated");
            getUpdatedResponse.EnsureSuccessStatusCode();
            var updated = await getUpdatedResponse.Content.ReadFromJsonAsync<CategoryDto>();
            updated.Should().NotBeNull();
            updated!.Name.Should().Be(updateDto.Name);

            // Delete second category
            var deleteResponse = await _client.DeleteAsync($"/api/category/{created2!.Id}");
            await LogIfError(deleteResponse, "MultipleOperations_Sequence_Delete");
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify deletion worked
            var getDeletedResponse = await _client.GetAsync($"/api/category/{created2.Id}");
            getDeletedResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);

            // Get list again - only first should remain
            var finalListResponse = await _client.GetAsync("/api/category");
            await LogIfError(finalListResponse, "MultipleOperations_Sequence_FinalList");
            finalListResponse.EnsureSuccessStatusCode();
            var finalPagedList = await finalListResponse.Content.ReadFromJsonAsync<PagedList<CategoryDto>>();
            finalPagedList.Should().NotBeNull();
            var finalListItems = finalPagedList!.Items.ToList();
            finalListItems.Exists(c => c.Id == created1.Id).Should().BeTrue();
            finalListItems.Exists(c => c.Id == created2.Id).Should().BeFalse();
        }

        [Fact]
        public async Task Get_CategoryById_WithSpecialCharactersInName_ReturnsCorrectly()
        {
            var specialName = "Fruits & Vegetables";
            var createDto = new CategoryCreateDto { Name = specialName, Code = "FV", Description = "Fruits and vegetables", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/category", createDto);
            await LogIfError(createResponse, "Get_CategoryById_WithSpecialCharacters_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<CategoryDto>();
            created.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/category/{created!.Id}");
            await LogIfError(getResponse, "Get_CategoryById_WithSpecialCharacters_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<CategoryDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(specialName);
        }
    }
}