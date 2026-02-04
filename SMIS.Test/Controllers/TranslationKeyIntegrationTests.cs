using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.DTO.Translations;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
    public class TranslationKeyIntegrationTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        private readonly JwtTokenHelper _tokenHelper;

        public TranslationKeyIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _output = output;
            _tokenHelper = new JwtTokenHelper(_client);
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

        public async Task InitializeAsync()
        {
            await _tokenHelper.SetAuthorizationHeaderAsync();
        }
        public Task DisposeAsync() => Task.CompletedTask;

        [Fact]
        public async Task Post_CreateValidTranslationKey_ReturnsOk()
        {
            var dto = new TranslationKeyCreateDto 
            { 
                Name = "welcome_message", 
                MessageCode = "WM001", 
                IsActive = true 
            };
            
            var response = await _client.PostAsJsonAsync("/api/translationkey", dto);
            await LogIfError(response, "Post_CreateValidTranslationKey");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<TranslationKeyCreateDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.MessageCode.Should().Be(dto.MessageCode);
            created.IsActive.Should().Be(dto.IsActive);
        }

        [Fact]
        public async Task Post_CreateTranslationKeyWithNullMessageCode_ReturnsOk()
        {
            var dto = new TranslationKeyCreateDto 
            { 
                Name = "error_message", 
                MessageCode = null, 
                IsActive = true 
            };
            
            var response = await _client.PostAsJsonAsync("/api/translationkey", dto);
            await LogIfError(response, "Post_CreateTranslationKeyWithNullMessageCode");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<TranslationKeyCreateDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.MessageCode.Should().BeNull();
        }

        [Fact]
        public async Task Post_CreateTranslationKeyWithTranslations_ReturnsOk()
        {
            var dto = new TranslationKeyCreateDto 
            { 
                Name = "button_save", 
                MessageCode = "BTN001", 
                IsActive = true,
                Translations = new List<TranslationEntityCreateDto>
                {
                    new() { Name = "Save", LanguageNo = "1", TranslationKeyId = "" },
                    new() { Name = "Guardar", LanguageNo = "2", TranslationKeyId = "" }
                }
            };
            
            var response = await _client.PostAsJsonAsync("/api/translationkey", dto);
            await LogIfError(response, "Post_CreateTranslationKeyWithTranslations");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<TranslationKeyCreateDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
            created.Translations.Should().HaveCount(2);
        }

        [Fact]
        public async Task Get_ListTranslationKeys_ReturnsPagedList()
        {
            var response = await _client.GetAsync("/api/translationkey?pageNumber=1&pageSize=10");
            await LogIfError(response, "Get_ListTranslationKeys");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);
        }

        [Fact]
        public async Task Get_ListTranslationKeysWithTranslations_ReturnsPagedListWithTranslations()
        {
            // Create a translation key with translations first
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "menu_home", 
                MessageCode = "MNU001", 
                IsActive = true,
                Translations = new List<TranslationEntityCreateDto>
                {
                    new() { Name = "Home", LanguageNo = "1", TranslationKeyId = "" }
                }
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Get_ListTranslationKeysWithTranslations_Seed");
            createResponse.EnsureSuccessStatusCode();

            var response = await _client.GetAsync("/api/translationkey?pageNumber=1&pageSize=10&includeTranslations=true");
            await LogIfError(response, "Get_ListTranslationKeysWithTranslations");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
        }

        [Fact]
        public async Task Get_TranslationKeyById_Existing_ReturnsTranslationKey()
        {
            // Create a translation key first
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "validation_required", 
                MessageCode = "VAL001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Get_TranslationKeyById_Seed");
            createResponse.EnsureSuccessStatusCode();
            
            var created = await createResponse.Content.ReadFromJsonAsync<TranslationKeyCreateDto>();
            created.Should().NotBeNull();

            // Get the created translation key by ID - need to get the actual ID from list
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
            createdKey.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/translationkey/{createdKey!.Id}");
            await LogIfError(getResponse, "Get_TranslationKeyById_Get");
            
            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var retrieved = await getResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(createdKey.Id);
            retrieved.Name.Should().Be(createDto.Name);
            retrieved.MessageCode.Should().Be(createDto.MessageCode);
            retrieved.IsActive.Should().Be(createDto.IsActive);
        }

        [Fact]
        public async Task Get_TranslationKeyById_NonExisting_ReturnsNotFound()
        {
            var fakeId = "non-existing-id";
            var response = await _client.GetAsync($"/api/translationkey/{fakeId}");
            await LogIfError(response, "Get_TranslationKeyById_NonExisting");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingTranslationKey_ReturnsUpdatedTranslationKey()
        {
            // Create a translation key first
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "status_active", 
                MessageCode = "STA001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Put_UpdateTranslationKey_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the created ID
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
            createdKey.Should().NotBeNull();

            // Update the translation key
            var updateDto = new TranslationKeyCreateDto 
            { 
                Name = "status_active_updated", 
                MessageCode = "STA001-UPD", 
                IsActive = false 
            };
            
            var updateResponse = await _client.PutAsJsonAsync($"/api/translationkey/{createdKey!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateTranslationKey_Update");
            
            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var updated = await updateResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            updated.Should().NotBeNull();
            updated!.Id.Should().Be(createdKey.Id);
            updated.Name.Should().Be(updateDto.Name);
            updated.MessageCode.Should().Be(updateDto.MessageCode);
            updated.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task Put_UpdateNonExistingTranslationKey_ReturnsNotFound()
        {
            var updateDto = new TranslationKeyCreateDto 
            { 
                Name = "fake_key", 
                MessageCode = "FAKE001", 
                IsActive = true 
            };
            
            var response = await _client.PutAsJsonAsync("/api/translationkey/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingTranslationKey");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingTranslationKey_ReturnsOk()
        {
            // Create a translation key first
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "temp_key", 
                MessageCode = "TMP001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Delete_ExistingTranslationKey_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the created ID
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
            createdKey.Should().NotBeNull();

            // Delete the translation key
            var deleteResponse = await _client.DeleteAsync($"/api/translationkey/{createdKey!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingTranslationKey_Delete");
            
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify it's gone
            var getResponse = await _client.GetAsync($"/api/translationkey/{createdKey.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingTranslationKey_ReturnsNotFound()
        {
            var response = await _client.DeleteAsync("/api/translationkey/non-existing-id");
            await LogIfError(response, "Delete_NonExistingTranslationKey");
            
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Get_TranslationKeyWithPagination_ReturnsCorrectPage()
        {
            // Create multiple translation keys to test pagination
            var translationKeys = new[]
            {
                new TranslationKeyCreateDto { Name = "test_key_1", MessageCode = "TK001", IsActive = true },
                new TranslationKeyCreateDto { Name = "test_key_2", MessageCode = "TK002", IsActive = true },
                new TranslationKeyCreateDto { Name = "test_key_3", MessageCode = "TK003", IsActive = true },
                new TranslationKeyCreateDto { Name = "test_key_4", MessageCode = "TK004", IsActive = true },
                new TranslationKeyCreateDto { Name = "test_key_5", MessageCode = "TK005", IsActive = true }
            };

            foreach (var key in translationKeys)
            {
                var response = await _client.PostAsJsonAsync("/api/translationkey", key);
                await LogIfError(response, $"CreateTestTranslationKey_{key.Name}");
                response.EnsureSuccessStatusCode();
            }

            // Test pagination - get page 1 with size 2
            var paginatedResponse = await _client.GetAsync("/api/translationkey?pageNumber=1&pageSize=2");
            await LogIfError(paginatedResponse, "Get_TranslationKeyWithPagination");
            
            paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Count.Should().BeLessOrEqualTo(2);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(2);
            paged.TotalCount.Should().BeGreaterOrEqualTo(5);
        }

        [Fact]
        public async Task Post_CreateTranslationKeyThenGetList_VerifyInList()
        {
            var newKey = new TranslationKeyCreateDto 
            { 
                Name = "list_verification_key", 
                MessageCode = "LVK001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", newKey);
            await LogIfError(createResponse, "Post_CreateTranslationKeyThenGetList_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the list and verify the new key is there
            var listResponse = await _client.GetAsync("/api/translationkey");
            await LogIfError(listResponse, "Post_CreateTranslationKeyThenGetList_GetList");
            listResponse.EnsureSuccessStatusCode();
            
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            pagedList.Should().NotBeNull();
            var foundKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == newKey.Name);
            foundKey.Should().NotBeNull();
            foundKey!.Name.Should().Be(newKey.Name);
            foundKey.MessageCode.Should().Be(newKey.MessageCode);
        }

        [Fact]
        public async Task Put_UpdateTranslationKeyThenGetById_VerifyUpdated()
        {
            // Create a translation key
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "update_verification_key", 
                MessageCode = "UVK001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Put_UpdateTranslationKeyThenGetById_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the created ID
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
            createdKey.Should().NotBeNull();

            // Update the translation key
            var updateDto = new TranslationKeyCreateDto 
            { 
                Name = "update_verification_key_updated", 
                MessageCode = "UVK001-UPD", 
                IsActive = false 
            };
            
            var updateResponse = await _client.PutAsJsonAsync($"/api/translationkey/{createdKey!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateTranslationKeyThenGetById_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Get by ID and verify it's updated
            var getResponse = await _client.GetAsync($"/api/translationkey/{createdKey.Id}");
            await LogIfError(getResponse, "Put_UpdateTranslationKeyThenGetById_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(updateDto.Name);
            retrieved.MessageCode.Should().Be(updateDto.MessageCode);
            retrieved.IsActive.Should().Be(updateDto.IsActive);
        }

        [Fact]
        public async Task MultipleOperations_Sequence_Test()
        {
            // Test a sequence of operations to ensure data consistency
            var key1 = new TranslationKeyCreateDto { Name = "sequence_test_1", MessageCode = "ST001", IsActive = true };
            var key2 = new TranslationKeyCreateDto { Name = "sequence_test_2", MessageCode = "ST002", IsActive = false };

            // Create first translation key
            var create1Response = await _client.PostAsJsonAsync("/api/translationkey", key1);
            await LogIfError(create1Response, "MultipleOperations_Sequence_Create1");
            create1Response.EnsureSuccessStatusCode();

            // Create second translation key
            var create2Response = await _client.PostAsJsonAsync("/api/translationkey", key2);
            await LogIfError(create2Response, "MultipleOperations_Sequence_Create2");
            create2Response.EnsureSuccessStatusCode();

            // Get list - both should be there
            var listResponse = await _client.GetAsync("/api/translationkey");
            await LogIfError(listResponse, "MultipleOperations_Sequence_GetList");
            listResponse.EnsureSuccessStatusCode();
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            pagedList.Should().NotBeNull();
            var listItems = pagedList!.Items.ToList();
            listItems.Exists(tk => tk.Name == key1.Name).Should().BeTrue();
            listItems.Exists(tk => tk.Name == key2.Name).Should().BeTrue();

            var created1 = listItems.First(tk => tk.Name == key1.Name);
            var created2 = listItems.First(tk => tk.Name == key2.Name);

            // Update first translation key
            var updateDto = new TranslationKeyCreateDto { Name = "updated_sequence_test_1", MessageCode = "UST001", IsActive = false };
            var updateResponse = await _client.PutAsJsonAsync($"/api/translationkey/{created1.Id}", updateDto);
            await LogIfError(updateResponse, "MultipleOperations_Sequence_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Verify update worked
            var getUpdatedResponse = await _client.GetAsync($"/api/translationkey/{created1.Id}");
            await LogIfError(getUpdatedResponse, "MultipleOperations_Sequence_GetUpdated");
            getUpdatedResponse.EnsureSuccessStatusCode();
            var updated = await getUpdatedResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            updated.Should().NotBeNull();
            updated!.Name.Should().Be(updateDto.Name);

            // Delete second translation key
            var deleteResponse = await _client.DeleteAsync($"/api/translationkey/{created2.Id}");
            await LogIfError(deleteResponse, "MultipleOperations_Sequence_Delete");
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify deletion worked
            var getDeletedResponse = await _client.GetAsync($"/api/translationkey/{created2.Id}");
            getDeletedResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);

            // Get list again - only first should remain
            var finalListResponse = await _client.GetAsync("/api/translationkey");
            await LogIfError(finalListResponse, "MultipleOperations_Sequence_FinalList");
            finalListResponse.EnsureSuccessStatusCode();
            var finalPagedList = await finalListResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            finalPagedList.Should().NotBeNull();
            var finalListItems = finalPagedList!.Items.ToList();
            finalListItems.Exists(tk => tk.Id == created1.Id).Should().BeTrue();
            finalListItems.Exists(tk => tk.Id == created2.Id).Should().BeFalse();
        }

        [Fact]
        public async Task Get_TranslationKeyWithSpecialCharactersInName_ReturnsCorrectly()
        {
            var specialName = "special_chars_&_symbols";
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = specialName, 
                MessageCode = "SCS001", 
                IsActive = true 
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Get_TranslationKeyWithSpecialCharacters_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the created ID
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == specialName);
            createdKey.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/translationkey/{createdKey!.Id}");
            await LogIfError(getResponse, "Get_TranslationKeyWithSpecialCharacters_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(specialName);
        }

        //[Fact]
        //public async Task Put_UpdateTranslationKeyWithLongName_ReturnsUpdated()
        //{
        //    var longName = new string('A', 100); // Test with reasonably long name
        //    var createDto = new TranslationKeyCreateDto 
        //    { 
        //        Name = "long_name_test", 
        //        MessageCode = "LNT001", 
        //        IsActive = true 
        //    };
            
        //    var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
        //    await LogIfError(createResponse, "Put_UpdateTranslationKeyWithLongName_Seed");
        //    createResponse.EnsureSuccessStatusCode();

        //    // Get the created ID
        //    var listResponse = await _client.GetAsync("/api/translationkey");
        //    var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
        //    var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
        //    createdKey.Should().NotBeNull();

        //    var updateDto = new TranslationKeyCreateDto 
        //    { 
        //        Name = longName, 
        //        MessageCode = "LNT001-UPD", 
        //        IsActive = false 
        //    };
            
        //    var updateResponse = await _client.PutAsJsonAsync($"/api/translationkey/{createdKey!.Id}", updateDto);
        //    await LogIfError(updateResponse, "Put_UpdateTranslationKeyWithLongName_Update");
            
        //    // Depending on validation, this might succeed or fail
        //    if (updateResponse.IsSuccessStatusCode)
        //    {
        //        var updated = await updateResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
        //        updated.Should().NotBeNull();
        //        updated!.Name.Should().Be(longName);
        //    }
        //    else
        //    {
        //        updateResponse.StatusCode.Should().NotBe(HttpStatusCode.OK);
        //    }
        //}

        [Fact]
        public async Task Post_CreateInactiveTranslationKey_ReturnsOk()
        {
            var dto = new TranslationKeyCreateDto 
            { 
                Name = "inactive_key", 
                MessageCode = "IK001", 
                IsActive = false 
            };
            
            var response = await _client.PostAsJsonAsync("/api/translationkey", dto);
            await LogIfError(response, "Post_CreateInactiveTranslationKey");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<TranslationKeyCreateDto>();
            created.Should().NotBeNull();
            created!.IsActive.Should().BeFalse();
        }

        [Fact]
        public async Task Get_TranslationKeyById_WithTranslations_ReturnsWithTranslations()
        {
            // Create a translation key with translations
            var createDto = new TranslationKeyCreateDto 
            { 
                Name = "with_translations_key", 
                MessageCode = "WTK001", 
                IsActive = true,
                Translations = new List<TranslationEntityCreateDto>
                {
                    new() { Name = "English Text", LanguageNo = "1" },
                    new() { Name = "Texto Español", LanguageNo = "2"}
                }
            };
            
            var createResponse = await _client.PostAsJsonAsync("/api/translationkey", createDto);
            await LogIfError(createResponse, "Get_TranslationKeyById_WithTranslations_Seed");
            createResponse.EnsureSuccessStatusCode();

            // Get the created ID
            var listResponse = await _client.GetAsync("/api/translationkey");
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<TranslationKeyDto>>();
            var createdKey = pagedList!.Items.FirstOrDefault(tk => tk.Name == createDto.Name);
            createdKey.Should().NotBeNull();

            // Get by ID with translations
            var getResponse = await _client.GetAsync($"/api/translationkey/{createdKey!.Id}?includeTranslations=true");
            await LogIfError(getResponse, "Get_TranslationKeyById_WithTranslations_Get");
            getResponse.EnsureSuccessStatusCode();
            
            var retrieved = await getResponse.Content.ReadFromJsonAsync<TranslationKeyDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(createDto.Name);
            retrieved.Translations.Should().NotBeNull();
        }
    }
}