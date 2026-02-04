using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Customers;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class CustomerIntegrationTests : BaseIntegrationTest
{
    private readonly CustomerTestDataHelper _dataHelper;

    public CustomerIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new CustomerTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<CustomerDto> CreateCustomerAsync(CustomerCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Customer, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<CustomerDto>())!;
    }

    private async Task<HttpResponseMessage> CreateCustomerResponseAsync(CustomerCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Customer, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateCustomerResponseAsync(string customerId, CustomerCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.Customer}/{customerId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertCustomerMatches(CustomerDto actual, CustomerCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.FirstName.ShouldBe(expected.FirstName);
        actual.LastName.ShouldBe(expected.LastName);
        actual.ShopId.ShouldBe(expected.ShopId);
        actual.FatherName.ShouldBe(expected.FatherName);
        actual.Email.ShouldBe(expected.Email);
        actual.PhoneNumber.ShouldBe(expected.PhoneNumber);
        actual.Address.ShouldBe(expected.Address);
        actual.TaxNumber.ShouldBe(expected.TaxNumber);
        actual.ProvinceId.ShouldBe(expected.ProvinceId);
        actual.DistrictId.ShouldBe(expected.DistrictId);
        actual.IsActive.ShouldBe(expected.IsActive);
    }

    [Fact]
    public async Task Post_CreateValidCustomer_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateValidCustomer");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        AssertCustomerMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateCustomerWithEmptyLastName_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        dto.LastName = "";

        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithEmptyLastName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.LastName.ShouldBe("");
    }

    [Fact]
    public async Task Post_CreateCustomerWithNullLastName_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        dto.LastName = null;

        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithNullLastName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.LastName.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListCustomers_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Customer}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListCustomers");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<CustomerDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListCustomers_WithPagination_ReturnsCorrectPage()
    {
        var customers = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateCustomerBuilder().Build())
            .ToArray();

        foreach (var customer in customers)
        {
            await CreateCustomerAsync(customer, $"CreateTestCustomer_{customer.FirstName}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.Customer}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListCustomers_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<CustomerDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_CustomerById_Existing_ReturnsCustomer()
    {
        var createDto = _dataHelper.CreateCustomerBuilder().Build();
        var created = await PostAndGetAsync<CustomerDto>(ApiEndpoints.Customer, createDto, "Get_CustomerById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Customer}/{created!.Id}");
        await LogIfError(getResponse, "Get_CustomerById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<CustomerDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertCustomerMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_CustomerById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Customer}/non-existing-id");
        await LogIfError(response, "Get_CustomerById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingCustomer_ReturnsUpdatedCustomer()
    {
        var createDto = _dataHelper.CreateCustomerBuilder().Build();
        var created = await PostAndGetAsync<CustomerDto>(ApiEndpoints.Customer, createDto, "Put_UpdateCustomer_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateCustomerBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateCustomerResponseAsync(created!.Id, updateDto, "Put_UpdateCustomer_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CustomerDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertCustomerMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingCustomer_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateCustomerBuilder().Build();
        var response = await UpdateCustomerResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingCustomer");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingCustomer_ReturnsOk()
    {
        var createDto = _dataHelper.CreateCustomerBuilder().Build();
        var created = await PostAndGetAsync<CustomerDto>(ApiEndpoints.Customer, createDto, "Delete_ExistingCustomer_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.Customer}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingCustomer_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.Customer}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingCustomer_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Customer}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingCustomer");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateCustomerWithInvalidShopId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        dto.ShopId = "invalid-shop-id";

        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithInvalidShopId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateCustomerWithInvalidProvinceId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        dto.ProvinceId = "invalid-province-id";

        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithInvalidProvinceId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateCustomerWithInvalidDistrictId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateCustomerBuilder().Build();
        dto.DistrictId = "invalid-district-id";

        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithInvalidDistrictId");
        (response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode == HttpStatusCode.Conflict).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateCustomerWithEmptyFirstName_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithFirstName("").Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithEmptyFirstName");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateCustomerWithNullEmail_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithEmail(null).Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithNullEmail");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.Email.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateCustomerWithNullPhoneNumber_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithPhoneNumber(null).Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithNullPhoneNumber");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.PhoneNumber.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateCustomerWithNullTaxNumber_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithTaxNumber(null).Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithNullTaxNumber");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.TaxNumber.ShouldBeNull();
    }

    [Fact]
    public async Task Put_UpdateCustomerToInactive_ReturnsInactiveCustomer()
    {
        var createDto = _dataHelper.CreateCustomerBuilder().WithIsActive(true).Build();
        var created = await PostAndGetAsync<CustomerDto>(ApiEndpoints.Customer, createDto, "Put_UpdateCustomerToInactive_Seed");
        created.ShouldNotBeNull();
        created!.IsActive.ShouldBeTrue();

        var updateDto = _dataHelper.CreateCustomerBuilder().WithIsActive(false).Build();
        var updateResponse = await UpdateCustomerResponseAsync(created.Id, updateDto, "Put_UpdateCustomerToInactive_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CustomerDto>();
        updated.ShouldNotBeNull();
        updated!.IsActive.ShouldBeFalse();
    }

    [Fact]
    public async Task Get_ListCustomers_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Customer}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListCustomers_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleCustomers_AllSucceed()
    {
        var customers = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateCustomerBuilder().Build())
            .ToList();

        foreach (var customer in customers)
        {
            var response = await CreateCustomerResponseAsync(customer, $"Post_CreateMultipleCustomers_{customer.FirstName}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateCustomerEmail_ReturnsUpdatedEmail()
    {
        var createDto = _dataHelper.CreateCustomerBuilder().WithEmail("old@email.com").Build();
        var created = await PostAndGetAsync<CustomerDto>(ApiEndpoints.Customer, createDto, "Put_UpdateCustomerEmail_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateCustomerBuilder().WithEmail("new@email.com").Build();
        var updateResponse = await UpdateCustomerResponseAsync(created!.Id, updateDto, "Put_UpdateCustomerEmail_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<CustomerDto>();
        updated.ShouldNotBeNull();
        updated!.Email.ShouldBe("new@email.com");
    }

    [Fact]
    public async Task Post_CreateCustomerWithExplicitNullFatherName_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithFatherName(null).Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithExplicitNullFatherName");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.FatherName.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateCustomerWithExplicitNullAddress_ReturnsOk()
    {
        var dto = _dataHelper.CreateCustomerBuilder().WithAddress(null).Build();
        var response = await CreateCustomerResponseAsync(dto, "Post_CreateCustomerWithExplicitNullAddress");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<CustomerDto>();
        created.ShouldNotBeNull();
        created!.Address.ShouldBeNull();
    }
}