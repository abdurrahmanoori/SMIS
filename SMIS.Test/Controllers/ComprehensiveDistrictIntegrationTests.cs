using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Districts;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers
{
    public class ComprehensiveDistrictIntegrationTests : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;

        public ComprehensiveDistrictIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
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
        public async Task Post_CreateValidDistrict_ReturnsOk()
        {
            var dto = new DistrictCreateDto { Name = "Kabul District" };
            var response = await _client.PostAsJsonAsync("/api/district", dto);
            await LogIfError(response, "Post_CreateValidDistrict");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
        }

        [Fact]
        public async Task Post_CreateDistrictWithSpecialCharacters_ReturnsOk()
        {
            var dto = new DistrictCreateDto { Name = "Kabul & Charikar District" };
            var response = await _client.PostAsJsonAsync("/api/district", dto);
            await LogIfError(response, "Post_CreateDistrictWithSpecialCharacters");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var created = await response.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();
            created!.Name.Should().Be(dto.Name);
        }

        [Fact]
        public async Task Get_ListDistricts_ReturnsPagedList()
        {
            var response = await _client.GetAsync("/api/district?pageNumber=1&pageSize=10");
            await LogIfError(response, "Get_ListDistricts");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await response.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Should().NotBeNull();
            paged.Items.Count.Should().BeGreaterOrEqualTo(0); // Could be empty initially
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(10);
        }

        [Fact]
        public async Task Get_ListDistricts_WithPagination_ReturnsCorrectPage()
        {
            // Create multiple districts to test pagination
            var districts = new[]
            {
                new DistrictCreateDto { Name = "Test District 1" },
                new DistrictCreateDto { Name = "Test District 2" },
                new DistrictCreateDto { Name = "Test District 3" },
                new DistrictCreateDto { Name = "Test District 4" },
                new DistrictCreateDto { Name = "Test District 5" }
            };

            foreach (var dist in districts)
            {
                var response = await _client.PostAsJsonAsync("/api/district", dist);
                await LogIfError(response, $"CreateTestDistrict_{dist.Name}");
                response.EnsureSuccessStatusCode();
            }

            // Test pagination - get page 1 with size 2
            var paginatedResponse = await _client.GetAsync("/api/district?pageNumber=1&pageSize=2");
            await LogIfError(paginatedResponse, "Get_ListDistricts_Pagination");

            paginatedResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
            paged.Should().NotBeNull();
            paged!.Items.Count.Should().BeLessOrEqualTo(2);
            paged.PageNumber.Should().Be(1);
            paged.PageSize.Should().Be(2);
            paged.TotalCount.Should().BeGreaterOrEqualTo(5);
        }

        [Fact]
        public async Task Get_DistrictById_Existing_ReturnsDistrict()
        {
            // Create a district first
            var createDto = new DistrictCreateDto { Name = "Herat District" };
            var createResponse = await _client.PostAsJsonAsync("/api/district", createDto);
            await LogIfError(createResponse, "Get_DistrictById_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            // Get the created district by ID
            var getResponse = await _client.GetAsync($"/api/district/{created!.Id}");
            await LogIfError(getResponse, "Get_DistrictById_Get");

            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var retrieved = await getResponse.Content.ReadFromJsonAsync<DistrictDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Id.Should().Be(created.Id);
            retrieved.Name.Should().Be(createDto.Name);
        }

        [Fact]
        public async Task Get_DistrictById_NonExisting_ReturnsNotFound()
        {
            var fakeId = "non-existing-id";
            var response = await _client.GetAsync($"/api/district/{fakeId}");
            await LogIfError(response, "Get_DistrictById_NonExisting");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Put_UpdateExistingDistrict_ReturnsUpdatedDistrict()
        {
            // Create a district first
            var createDto = new DistrictCreateDto { Name = "Nangarhar District" };
            var createResponse = await _client.PostAsJsonAsync("/api/district", createDto);
            await LogIfError(createResponse, "Put_UpdateDistrict_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            // Update the district
            var updateDto = new DistrictCreateDto { Name = "Nangarhar Province Updated" };
            var updateResponse = await _client.PutAsJsonAsync($"/api/district/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateDistrict_Update");

            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var updated = await updateResponse.Content.ReadFromJsonAsync<DistrictDto>();
            updated.Should().NotBeNull();
            updated!.Id.Should().Be(created.Id);
            updated.Name.Should().Be(updateDto.Name);
        }

        [Fact]
        public async Task Put_UpdateNonExistingDistrict_ReturnsNotFound()
        {
            var updateDto = new DistrictCreateDto { Name = "Fake District" };
            var response = await _client.PutAsJsonAsync("/api/district/non-existing-id", updateDto);
            await LogIfError(response, "Put_UpdateNonExistingDistrict");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_ExistingDistrict_ReturnsOk()
        {
            // Create a district first
            var createDto = new DistrictCreateDto { Name = "Balkh District" };
            var createResponse = await _client.PostAsJsonAsync("/api/district", createDto);
            await LogIfError(createResponse, "Delete_ExistingDistrict_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            // Delete the district
            var deleteResponse = await _client.DeleteAsync($"/api/district/{created!.Id}");
            await LogIfError(deleteResponse, "Delete_ExistingDistrict_Delete");

            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify it's gone
            var getResponse = await _client.GetAsync($"/api/district/{created.Id}");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Delete_NonExistingDistrict_ReturnsNotFound()
        {
            var response = await _client.DeleteAsync("/api/district/non-existing-id");
            await LogIfError(response, "Delete_NonExistingDistrict");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Post_CreateDistrictThenGetList_VerifyInList()
        {
            var newDistrict = new DistrictCreateDto { Name = "Logar District" };
            var createResponse = await _client.PostAsJsonAsync("/api/district", newDistrict);
            await LogIfError(createResponse, "Post_CreateDistrictThenGetList_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            // Get the list and verify the new district is there
            var listResponse = await _client.GetAsync("/api/district");
            await LogIfError(listResponse, "Post_CreateDistrictThenGetList_GetList");
            listResponse.EnsureSuccessStatusCode();

            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
            pagedList.Should().NotBeNull();
            var foundDistrict = pagedList!.Items.FirstOrDefault(c => c.Id == created!.Id);
            foundDistrict.Should().NotBeNull();
            foundDistrict!.Name.Should().Be(newDistrict.Name);
        }

        [Fact]
        public async Task Put_UpdateDistrictThenGetById_VerifyUpdated()
        {
            // Create a district
            var createDto = new DistrictCreateDto { Name = "Ghazni District" };
            var createResponse = await _client.PostAsJsonAsync("/api/district", createDto);
            await LogIfError(createResponse, "Put_UpdateDistrictThenGetById_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            // Update the district
            var updateDto = new DistrictCreateDto { Name = "Ghazni Province Updated" };
            var updateResponse = await _client.PutAsJsonAsync($"/api/district/{created!.Id}", updateDto);
            await LogIfError(updateResponse, "Put_UpdateDistrictThenGetById_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Get by ID and verify it's updated
            var getResponse = await _client.GetAsync($"/api/district/{created.Id}");
            await LogIfError(getResponse, "Put_UpdateDistrictThenGetById_Get");
            getResponse.EnsureSuccessStatusCode();

            var retrieved = await getResponse.Content.ReadFromJsonAsync<DistrictDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(updateDto.Name);
        }

        [Fact]
        public async Task MultipleOperations_Sequence_Test()
        {
            // Test a sequence of operations to ensure data consistency
            var dist1 = new DistrictCreateDto { Name = "Sequence Test 1" };
            var dist2 = new DistrictCreateDto { Name = "Sequence Test 2" };

            // Create first district
            var create1Response = await _client.PostAsJsonAsync("/api/district", dist1);
            await LogIfError(create1Response, "MultipleOperations_Sequence_Create1");
            create1Response.EnsureSuccessStatusCode();
            var created1 = await create1Response.Content.ReadFromJsonAsync<DistrictDto>();
            created1.Should().NotBeNull();

            // Create second district
            var create2Response = await _client.PostAsJsonAsync("/api/district", dist2);
            await LogIfError(create2Response, "MultipleOperations_Sequence_Create2");
            create2Response.EnsureSuccessStatusCode();
            var created2 = await create2Response.Content.ReadFromJsonAsync<DistrictDto>();
            created2.Should().NotBeNull();

            // Get list - both should be there
            var listResponse = await _client.GetAsync("/api/district");
            await LogIfError(listResponse, "MultipleOperations_Sequence_GetList");
            listResponse.EnsureSuccessStatusCode();
            var pagedList = await listResponse.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
            pagedList.Should().NotBeNull();
            var listItems = pagedList!.Items.ToList();
            listItems.Exists(c => c.Id == created1!.Id).Should().BeTrue();
            listItems.Exists(c => c.Id == created2!.Id).Should().BeTrue();

            // Update first district
            var updateDto = new DistrictCreateDto { Name = "Updated Sequence Test 1" };
            var updateResponse = await _client.PutAsJsonAsync($"/api/district/{created1!.Id}", updateDto);
            await LogIfError(updateResponse, "MultipleOperations_Sequence_Update");
            updateResponse.EnsureSuccessStatusCode();

            // Verify update worked
            var getUpdatedResponse = await _client.GetAsync($"/api/district/{created1.Id}");
            await LogIfError(getUpdatedResponse, "MultipleOperations_Sequence_GetUpdated");
            getUpdatedResponse.EnsureSuccessStatusCode();
            var updated = await getUpdatedResponse.Content.ReadFromJsonAsync<DistrictDto>();
            updated.Should().NotBeNull();
            updated!.Name.Should().Be(updateDto.Name);

            // Delete second district
            var deleteResponse = await _client.DeleteAsync($"/api/district/{created2!.Id}");
            await LogIfError(deleteResponse, "MultipleOperations_Sequence_Delete");
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verify deletion worked
            var getDeletedResponse = await _client.GetAsync($"/api/district/{created2.Id}");
            getDeletedResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);

            // Get list again - only first should remain
            var finalListResponse = await _client.GetAsync("/api/district");
            await LogIfError(finalListResponse, "MultipleOperations_Sequence_FinalList");
            finalListResponse.EnsureSuccessStatusCode();
            var finalPagedList = await finalListResponse.Content.ReadFromJsonAsync<PagedList<DistrictDto>>();
            finalPagedList.Should().NotBeNull();
            var finalListItems = finalPagedList!.Items.ToList();
            finalListItems.Exists(c => c.Id == created1.Id).Should().BeTrue();
            finalListItems.Exists(c => c.Id == created2.Id).Should().BeFalse();
        }

        [Fact]
        public async Task Get_DistrictById_WithSpecialCharactersInName_ReturnsCorrectly()
        {
            var specialName = "Kunar & Laghman District";
            var createDto = new DistrictCreateDto { Name = specialName };
            var createResponse = await _client.PostAsJsonAsync("/api/district", createDto);
            await LogIfError(createResponse, "Get_DistrictById_WithSpecialCharacters_Seed");
            createResponse.EnsureSuccessStatusCode();

            var created = await createResponse.Content.ReadFromJsonAsync<DistrictDto>();
            created.Should().NotBeNull();

            var getResponse = await _client.GetAsync($"/api/district/{created!.Id}");
            await LogIfError(getResponse, "Get_DistrictById_WithSpecialCharacters_Get");
            getResponse.EnsureSuccessStatusCode();

            var retrieved = await getResponse.Content.ReadFromJsonAsync<DistrictDto>();
            retrieved.Should().NotBeNull();
            retrieved!.Name.Should().Be(specialName);
        }
    }
}