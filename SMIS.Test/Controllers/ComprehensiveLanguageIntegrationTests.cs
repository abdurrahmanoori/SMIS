using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Localization;
using SMIS.Test.TestInfrastructure;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
    public class ComprehensiveLanguageIntegrationTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;

        public ComprehensiveLanguageIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
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
                _output.WriteLine($"[{context}] Error: {errorContent}");
            }
        }

        public Task InitializeAsync() => Task.CompletedTask;
        public Task DisposeAsync() => Task.CompletedTask;

        [Fact]
        public async Task Post_CreateValidLanguage_ReturnsOk()
        {
            var dto = new LanguageCreateDto { Name = "French", Code = "fr", IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/language", dto);
            await LogIfError(response, "Post_CreateValidLanguage");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().Be(dto.Code);
            created.IsActive.Should().Be(dto.IsActive);
        }

        [Fact]
        public async Task Post_CreateLanguageWithEmptyCode_ReturnsOk()
        {
            var dto = new LanguageCreateDto { Name = "English", Code = "", IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/language", dto);
            await LogIfError(response, "Post_CreateLanguageWithEmptyCode");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().Be(dto.Code);
        }

        [Fact]
        public async Task Post_CreateLanguageWithNullCode_ReturnsOk()
        {
            var dto = new LanguageCreateDto { Name = "Chinese", Code = null, IsActive = true };
            var response = await _client.PostAsJsonAsync("/api/language", dto);
            await LogIfError(response, "Post_CreateLanguageWithNullCode");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Code.Should().BeNull();
        }

        [Fact]
        public async Task Get_ListLanguages_ReturnsPagedList()
        {
            var response = await _client.GetAsync("/api/language?pageNumber=1&pageSize=10");
            await LogIfError(response, "Get_ListLanguages");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0); // Could be empty initially
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);
        }

        [Fact]
        public async Task Get_ListLanguages_WithPagination_ReturnsCorrectPage()
        {
            // Create multiple languages to test pagination
            var languages = new[]
            {
                new LanguageCreateDto { Name = "Test Lang 1", Code = "tl1", IsActive = true },
                new LanguageCreateDto { Name = "Test Lang 2", Code = "tl2", IsActive = true },
                new LanguageCreateDto { Name = "Test Lang 3", Code = "tl3", IsActive = true },
                new LanguageCreateDto { Name = "Test Lang 4", Code = "tl4", IsActive = true },
                new LanguageCreateDto { Name = "Test Lang 5", Code = "tl5", IsActive = true }
            };

            foreach (var lang in languages)
            {
                var response = await _client.PostAsJsonAsync("/api/language", lang);
                await LogIfError(response, $"CreateTestLanguage_{lang.Name}");
                response.EnsureSuccessStatusCode();
            }

            // Test pagination - get page 1 with size 2
            var paginatedResponse = await _client.GetAsync("/api/language?pageNumber=1&pageSize=2");
            await LogIfError(paginatedResponse, "Get_ListLanguages_Pagination");
            
            paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Count.Should().BeLessOrEqualTo(2);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(2);
            paged.TotalCount.Should().BeGreaterOrEqualTo(5);
        }

        [Fact]
        public async Task Get_LanguageById_Existing_ReturnsLanguage()
        {
            // Create a language first
            var createDto = new LanguageCreateDto { Name = "Japanese", Code = "ja", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Get_LanguageById_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            // Get the created language by ID
            var getResponse = await _client.GetAsync($"/api/language/{created!.Id}");
            await LogIfError(getResponse, "Get_LanguageById_Get");
            
            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var retrieved = await getResponse.Content.ReadFromJsonAsync<LanguageDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(created.Id);
            retrieved.Name.Should().Be(createDto.Name);
            retrieved.Code.Should().Be(createDto.Code);
            retrieved.IsActive.Should().Be(createDto.IsActive);
        }

        [Fact]
        public async Task Get_LanguageById_NonExisting_ReturnsNotFound()
        {
            var fakeId = "non-existing-id";
            var response = await _client.GetAsync($"/api/language/{fakeId}");
            await LogIfError(response, "Get_LanguageById_NonExisting");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingLanguage_ReturnsUpdatedLanguage()
        {
            // Create a language first
            var createDto = new LanguageCreateDto { Name = "Russian", Code = "ru", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Put_UpdateLanguage_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            // Update the language
            var updateDto = new LanguageCreateDto { Name = "Russian Updated", Code = "ru-RU", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/language/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateLanguage_Update");
            
            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
            updated.Should().NotBeNull();
            updated!.Id.Should().Be(created.Id);
            updated.Name.Should().Be(updateDto.Name);
            updated.Code.Should().Be(updateDto.Code);
            updated.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task Put_UpdateNonExistingLanguage_ReturnsNotFound()
        {
            var updateDto = new LanguageCreateDto { Name = "Fake Language", Code = "fl", IsActive = true };
            var response = await _client.PutAsJsonAsync("/api/language/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingLanguage");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingLanguage_ReturnsOk()
        {
            // Create a language first
            var createDto = new LanguageCreateDto { Name = "Korean", Code = "ko", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Delete_ExistingLanguage_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            // Delete the language
            var deleteResponse = await _client.DeleteAsync($"/api/language/{created!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingLanguage_Delete");
            
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify it's gone
            var getResponse = await _client.GetAsync($"/api/language/{created.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingLanguage_ReturnsNotFound()
        {
            var response = await _client.DeleteAsync("/api/language/non-existing-id");
            await LogIfError(response, "Delete_NonExistingLanguage");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateLanguageThenGetList_VerifyInList()
        {
            var newLanguage = new LanguageCreateDto { Name = "Arabic", Code = "ar", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", newLanguage);
            await LogIfError(createResponse, "Post_CreateLanguageThenGetList_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            // Get the list and verify the new language is there
            var listResponse = await _client.GetAsync("/api/language");
            await LogIfError(listResponse, "Post_CreateLanguageThenGetList_GetList");
            listResponse.EnsureSuccessStatusCode();
            
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
            pagedList.Should().NotBeNull();
            var foundLanguage = pagedList!.Items.FirstOrDefault(l => l.Id == created!.Id);
            foundLanguage.Should().NotBeNull();
            foundLanguage!.Name.Should().Be(newLanguage.Name);
        }

        [Fact]
        public async Task Put_UpdateLanguageThenGetById_VerifyUpdated()
        {
            // Create a language
            var createDto = new LanguageCreateDto { Name = "Portuguese", Code = "pt", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Put_UpdateLanguageThenGetById_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            // Update the language
            var updateDto = new LanguageCreateDto { Name = "Portuguese Brazilian", Code = "pt-BR", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/language/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateLanguageThenGetById_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Get by ID and verify it's updated
            var getResponse = await _client.GetAsync($"/api/language/{created.Id}");
            await LogIfError(getResponse, "Put_UpdateLanguageThenGetById_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<LanguageDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(updateDto.Name);
            retrieved.Code.Should().Be(updateDto.Code);
            retrieved.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task MultipleOperations_Sequence_Test()
        {
            // Test a sequence of operations to ensure data consistency
            var lang1 = new LanguageCreateDto { Name = "Sequence Test 1", Code = "st1", IsActive = true };
            var lang2 = new LanguageCreateDto { Name = "Sequence Test 2", Code = "st2", IsActive = false };

            // Create first language
            var create1Response = await _client.PostAsJsonAsync("/api/language", lang1);
            await LogIfError(create1Response, "MultipleOperations_Sequence_Create1");
            create1Response.EnsureSuccessStatusCode();
            var created1 = await create1Response.Content.ReadFromJsonAsync<LanguageDto>();
            created1.Should().NotBeNull();

            // Create second language
            var create2Response = await _client.PostAsJsonAsync("/api/language", lang2);
            await LogIfError(create2Response, "MultipleOperations_Sequence_Create2");
            create2Response.EnsureSuccessStatusCode();
            var created2 = await create2Response.Content.ReadFromJsonAsync<LanguageDto>();
            created2.Should().NotBeNull();

            // Get list - both should be there
            var listResponse = await _client.GetAsync("/api/language");
            await LogIfError(listResponse, "MultipleOperations_Sequence_GetList");
            listResponse.EnsureSuccessStatusCode();
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
            pagedList.Should().NotBeNull();
            var listItems = pagedList!.Items.ToList();
            listItems.Exists(l => l.Id == created1!.Id).Should().BeTrue();
            listItems.Exists(l => l.Id == created2!.Id).Should().BeTrue();

            // Update first language
            var updateDto = new LanguageCreateDto { Name = "Updated Sequence Test 1", Code = "ust1", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/language/{created1!.Id}", updateDto);
            await LogIfError(updateResponse, "MultipleOperations_Sequence_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Verify update worked
            var getUpdatedResponse = await _client.GetAsync($"/api/language/{created1.Id}");
            await LogIfError(getUpdatedResponse, "MultipleOperations_Sequence_GetUpdated");
            getUpdatedResponse.EnsureSuccessStatusCode();
            var updated = await getUpdatedResponse.Content.ReadFromJsonAsync<LanguageDto>();
            updated.Should().NotBeNull();
            updated!.Name.Should().Be(updateDto.Name);

            // Delete second language
            var deleteResponse = await _client.DeleteAsync($"/api/language/{created2!.Id}");
            await LogIfError(deleteResponse, "MultipleOperations_Sequence_Delete");
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify deletion worked
            var getDeletedResponse = await _client.GetAsync($"/api/language/{created2.Id}");
            getDeletedResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);

            // Get list again - only first should remain
            var finalListResponse = await _client.GetAsync("/api/language");
            await LogIfError(finalListResponse, "MultipleOperations_Sequence_FinalList");
            finalListResponse.EnsureSuccessStatusCode();
            var finalPagedList = await finalListResponse.Content.ReadFromJsonAsync<PagedList<LanguageDto>>();
            finalPagedList.Should().NotBeNull();
            var finalListItems = finalPagedList!.Items.ToList();
            finalListItems.Exists(l => l.Id == created1.Id).Should().BeTrue();
            finalListItems.Exists(l => l.Id == created2.Id).Should().BeFalse();
        }

        [Fact]
        public async Task Get_LanguageById_WithSpecialCharactersInName_ReturnsCorrectly()
        {
            var specialName = "Français & Español";
            var createDto = new LanguageCreateDto { Name = specialName, Code = "fes", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Get_LanguageById_WithSpecialCharacters_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/language/{created!.Id}");
            await LogIfError(getResponse, "Get_LanguageById_WithSpecialCharacters_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<LanguageDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(specialName);
        }

        [Fact]
        public async Task Put_UpdateLanguageWithLongName_ReturnsUpdated()
        {
            var longName = new string('A', 250); // Assuming max length is handled by validation
            var createDto = new LanguageCreateDto { Name = "Long Name Test", Code = "lnt", IsActive = true };
            var createResponse = await _client.PostAsJsonAsync("/api/language", createDto);
            await LogIfError(createResponse, "Put_UpdateLanguageWithLongName_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<LanguageDto>();
            created.Should().NotBeNull();

            var updateDto = new LanguageCreateDto { Name = longName, Code = "lnt-updated", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/language/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateLanguageWithLongName_Update");
            
            // Depending on validation, this might succeed or fail
            // If validation allows it, it should succeed
            var updated = await updateResponse.Content.ReadFromJsonAsync<LanguageDto>();
            if (updated != null)
            {
                updated.Name.Should().Be(longName);
            }
            // If validation rejects it, status should be 400 Bad Request
            else
            {
                updateResponse.StatusCode.Should().NotBe(HttpStatusCode.OK);
            }
        }
    }
}