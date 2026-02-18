using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class LoanAccountIntegrationTests : BaseIntegrationTest
{
    private readonly LoanAccountTestDataHelper _dataHelper;

    public LoanAccountIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new LoanAccountTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    private async Task<LoanAccountDto> CreateLoanAccountAsync(LoanAccountCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.LoanAccount, dto);
        await LogIfError(response, testName);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<LoanAccountDto>())!;
    }

    private async Task<HttpResponseMessage> CreateLoanAccountResponseAsync(LoanAccountCreateDto dto, string testName)
    {
        var response = await Client.PostAsJsonAsync(ApiEndpoints.LoanAccount, dto);
        await LogIfError(response, testName);
        return response;
    }

    private async Task<HttpResponseMessage> UpdateLoanAccountResponseAsync(string loanAccountId, LoanAccountCreateDto dto, string testName)
    {
        var response = await Client.PutAsJsonAsync($"{ApiEndpoints.LoanAccount}/{loanAccountId}", dto);
        await LogIfError(response, testName);
        return response;
    }

    private static void AssertLoanAccountMatches(LoanAccountDto actual, LoanAccountCreateDto expected)
    {
        actual.ShouldNotBeNull();
        actual.CustomerId.ShouldBe(expected.CustomerId);
        actual.ShopId.ShouldBe(expected.ShopId);
        actual.ProductId.ShouldBe(expected.ProductId);
        actual.Quantity.ShouldBe(expected.Quantity);
        actual.UnitId.ShouldBe(expected.UnitId);
        actual.PriceAtLoanTime.ShouldBe(expected.PriceAtLoanTime);
        actual.TotalAmount.ShouldBe(expected.TotalAmount);
        actual.DueDate.ShouldBe(expected.DueDate);
        actual.Notes.ShouldBe(expected.Notes);
    }

    [Fact]
    public async Task Post_CreateValidLoanAccount_ReturnsOk()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateValidLoanAccount");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LoanAccountDto>();
        AssertLoanAccountMatches(created!, dto);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithNullDueDate_ReturnsOk()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        dto.DueDate = null;

        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithNullDueDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LoanAccountDto>();
        created.ShouldNotBeNull();
        created!.DueDate.ShouldBeNull();
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithNullNotes_ReturnsOk()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        dto.Notes = null;

        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithNullNotes");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LoanAccountDto>();
        created.ShouldNotBeNull();
        created!.Notes.ShouldBeNull();
    }

    [Fact]
    public async Task Get_ListLoanAccounts_ReturnsPagedList()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.LoanAccount}?pageNumber=1&pageSize=10");
        await LogIfError(response, "Get_ListLoanAccounts");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await response.Content.ReadFromJsonAsync<PagedList<LoanAccountDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.ShouldNotBeNull();
        paged.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(10);
    }

    [Fact]
    public async Task Get_ListLoanAccounts_WithPagination_ReturnsCorrectPage()
    {
        var loanAccounts = Enumerable.Range(1, 5)
            .Select(i => _dataHelper.CreateLoanAccountBuilder().Build())
            .ToArray();

        foreach (var loanAccount in loanAccounts)
        {
            await CreateLoanAccountAsync(loanAccount, $"CreateTestLoanAccount_{loanAccount.CustomerId}");
        }

        var paginatedResponse = await Client.GetAsync($"{ApiEndpoints.LoanAccount}?pageNumber=1&pageSize=2");
        await LogIfError(paginatedResponse, "Get_ListLoanAccounts_Pagination");

        paginatedResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var paged = await paginatedResponse.Content.ReadFromJsonAsync<PagedList<LoanAccountDto>>();
        paged.ShouldNotBeNull();
        paged!.Items.Count.ShouldBeLessThanOrEqualTo(2);
        paged.PageNumber.ShouldBe(1);
        paged.PageSize.ShouldBe(2);
        paged.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }

    [Fact]
    public async Task Get_LoanAccountById_Existing_ReturnsLoanAccount()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Get_LoanAccountById_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.LoanAccount}/{created!.Id}");
        await LogIfError(getResponse, "Get_LoanAccountById_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<LoanAccountDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Id.ShouldBe(created.Id);
        AssertLoanAccountMatches(retrieved, createDto);
    }

    [Fact]
    public async Task Get_LoanAccountById_NonExisting_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.LoanAccount}/non-existing-id");
        await LogIfError(response, "Get_LoanAccountById_NonExisting");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Put_UpdateExistingLoanAccount_ReturnsUpdatedLoanAccount()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Put_UpdateLoanAccount_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateLoanAccountBuilder().WithQuantity(20).Build();
        var updateResponse = await UpdateLoanAccountResponseAsync(created!.Id, updateDto, "Put_UpdateLoanAccount_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LoanAccountDto>();
        updated.ShouldNotBeNull();
        updated!.Id.ShouldBe(created.Id);
        AssertLoanAccountMatches(updated, updateDto);
    }

    [Fact]
    public async Task Put_UpdateNonExistingLoanAccount_ReturnsNotFound()
    {
        var updateDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var response = await UpdateLoanAccountResponseAsync("non-existing-id", updateDto, "Put_UpdateNonExistingLoanAccount");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_ExistingLoanAccount_ReturnsOk()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Delete_ExistingLoanAccount_Seed");
        created.ShouldNotBeNull();

        var deleteResponse = await Client.DeleteAsync($"{ApiEndpoints.LoanAccount}/{created!.Id}");
        await LogIfError(deleteResponse, "Delete_ExistingLoanAccount_Delete");

        deleteResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        var getResponse = await Client.GetAsync($"{ApiEndpoints.LoanAccount}/{created.Id}");
        getResponse.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_NonExistingLoanAccount_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.LoanAccount}/non-existing-id");
        await LogIfError(response, "Delete_NonExistingLoanAccount");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithInvalidCustomerId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        dto.CustomerId = "invalid-customer-id";

        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithInvalidCustomerId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithInvalidShopId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        dto.ShopId = "invalid-shop-id";

        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithInvalidShopId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithInvalidProductId_ReturnsConflict()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().Build();
        dto.ProductId = "invalid-product-id";

        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithInvalidProductId");
        (response.StatusCode == HttpStatusCode.Conflict || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithZeroQuantity_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithQuantity(0).Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithZeroQuantity");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithNegativeQuantity_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithQuantity(-5).Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithNegativeQuantity");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithZeroTotalAmount_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(0).Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithZeroTotalAmount");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithNegativeTotalAmount_ReturnsBadRequest()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(-1000).Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithNegativeTotalAmount");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Get_ListLoanAccounts_WithInvalidPageSize_ReturnsBadRequest()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.LoanAccount}?pageNumber=1&pageSize=0");
        await LogIfError(response, "Get_ListLoanAccounts_InvalidPageSize");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_CreateMultipleLoanAccounts_AllSucceed()
    {
        var loanAccounts = Enumerable.Range(1, 3)
            .Select(i => _dataHelper.CreateLoanAccountBuilder().Build())
            .ToList();

        foreach (var loanAccount in loanAccounts)
        {
            var response = await CreateLoanAccountResponseAsync(loanAccount, $"Post_CreateMultipleLoanAccounts_{loanAccount.CustomerId}");
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }

    [Fact]
    public async Task Put_UpdateLoanAccountQuantity_ReturnsUpdatedQuantity()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().WithQuantity(10).Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Put_UpdateLoanAccountQuantity_Seed");
        created.ShouldNotBeNull();

        var updateDto = _dataHelper.CreateLoanAccountBuilder().WithQuantity(25).Build();
        var updateResponse = await UpdateLoanAccountResponseAsync(created!.Id, updateDto, "Put_UpdateLoanAccountQuantity_Update");

        updateResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var updated = await updateResponse.Content.ReadFromJsonAsync<LoanAccountDto>();
        updated.ShouldNotBeNull();
        updated!.Quantity.ShouldBe(25);
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithFutureDueDate_ReturnsOk()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithDueDate(DateTime.UtcNow.AddDays(30)).Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithFutureDueDate");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LoanAccountDto>();
        created.ShouldNotBeNull();
        created!.DueDate.ShouldNotBeNull();
    }

    [Fact]
    public async Task Post_CreateLoanAccountWithLongNotes_ReturnsOk()
    {
        var dto = _dataHelper.CreateLoanAccountBuilder().WithNotes("This is a test note for loan account").Build();
        var response = await CreateLoanAccountResponseAsync(dto, "Post_CreateLoanAccountWithLongNotes");
        
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<LoanAccountDto>();
        created.ShouldNotBeNull();
        created!.Notes.ShouldBe("This is a test note for loan account");
    }

    [Fact]
    public async Task Get_LoanAccountById_WithIncludeCustomer_ReturnsWithCustomer()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Get_LoanAccountById_WithIncludeCustomer_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.LoanAccount}/{created!.Id}?includeCustomer=true");
        await LogIfError(getResponse, "Get_LoanAccountById_WithIncludeCustomer_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<LoanAccountDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Customer.ShouldNotBeNull();
    }

    [Fact]
    public async Task Get_LoanAccountById_WithIncludeProduct_ReturnsWithProduct()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await PostAndGetAsync<LoanAccountDto>(ApiEndpoints.LoanAccount, createDto, "Get_LoanAccountById_WithIncludeProduct_Seed");
        created.ShouldNotBeNull();

        var getResponse = await Client.GetAsync($"{ApiEndpoints.LoanAccount}/{created!.Id}?includeProduct=true");
        await LogIfError(getResponse, "Get_LoanAccountById_WithIncludeProduct_Get");

        getResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var retrieved = await getResponse.Content.ReadFromJsonAsync<LoanAccountDto>();
        retrieved.ShouldNotBeNull();
        retrieved!.Product.ShouldNotBeNull();
    }

    [Fact]
    public async Task Post_ProcessPayment_ValidPayment_ReturnsOk()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(10000).Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_Seed");
        created.ShouldNotBeNull();

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash",
            Notes = "Partial payment"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.TotalPaid.ShouldBe(5000);
    }

    [Fact]
    public async Task Post_ProcessPayment_FullPayment_ReturnsOk()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(10000).Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_FullPayment_Seed");
        created.ShouldNotBeNull();

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 10000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash",
            Notes = "Full payment"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_FullPayment");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.TotalPaid.ShouldBe(10000);
        result.RemainingUnallocated.ShouldBe(0);
    }

    [Fact]
    public async Task Post_ProcessPayment_ZeroAmount_ReturnsBadRequest()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_ZeroAmount_Seed");
        created.ShouldNotBeNull();

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 0,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_ZeroAmount");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_ProcessPayment_NegativeAmount_ReturnsBadRequest()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_NegativeAmount_Seed");
        created.ShouldNotBeNull();

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = -1000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_NegativeAmount");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_ProcessPayment_InvalidCustomerId_ReturnsNotFound()
    {
        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = "invalid-customer-id",
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_InvalidCustomerId");

        (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.BadRequest).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_ProcessPayment_MultiplePayments_AccumulatesCorrectly()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(15000).Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_MultiplePayments_Seed");
        created.ShouldNotBeNull();

        var payment1 = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response1 = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment1);
        response1.StatusCode.ShouldBe(HttpStatusCode.OK);

        var payment2 = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response2 = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment2);
        await LogIfError(response2, "Post_ProcessPayment_MultiplePayments_Second");
        response2.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Post_ProcessPayment_WithBankTransfer_ReturnsOk()
    {
        var createDto = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(10000).Build();
        var created = await CreateLoanAccountAsync(createDto, "Post_ProcessPayment_BankTransfer_Seed");
        created.ShouldNotBeNull();

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created.CustomerId,
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "BankTransfer",
            Notes = "Bank transfer payment"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_BankTransfer");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Post_ProcessPayment_MultipleLoans_AllocatesFIFO()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(5000).Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_MultipleLoans_Loan1");

        await Task.Delay(100);

        var loan2 = _dataHelper.CreateLoanAccountBuilder()
            .WithCustomerId(created1.CustomerId)
            .WithTotalAmount(8000).Build();
        var created2 = await CreateLoanAccountAsync(loan2, "Post_ProcessPayment_MultipleLoans_Loan2");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 10000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_MultipleLoans");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.TotalPaid.ShouldBe(10000);
        result.Allocations.Count.ShouldBe(2);
        result.Allocations[0].AllocatedAmount.ShouldBe(5000);
        result.Allocations[1].AllocatedAmount.ShouldBe(5000);
    }

    [Fact]
    public async Task Post_ProcessPayment_ThreeLoans_PartialAllocation()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(3000).Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_ThreeLoans_Loan1");

        await Task.Delay(100);

        var loan2 = _dataHelper.CreateLoanAccountBuilder()
            .WithCustomerId(created1.CustomerId)
            .WithTotalAmount(4000).Build();
        await CreateLoanAccountAsync(loan2, "Post_ProcessPayment_ThreeLoans_Loan2");

        await Task.Delay(100);

        var loan3 = _dataHelper.CreateLoanAccountBuilder()
            .WithCustomerId(created1.CustomerId)
            .WithTotalAmount(5000).Build();
        await CreateLoanAccountAsync(loan3, "Post_ProcessPayment_ThreeLoans_Loan3");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 8000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_ThreeLoans");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.Allocations.Count.ShouldBe(3);
        result.Allocations[0].AllocatedAmount.ShouldBe(3000);
        result.Allocations[0].Status.ShouldBe("Paid");
        result.Allocations[1].AllocatedAmount.ShouldBe(4000);
        result.Allocations[1].Status.ShouldBe("Paid");
        result.Allocations[2].AllocatedAmount.ShouldBe(1000);
        result.Allocations[2].Status.ShouldBe("PartiallyPaid");
    }

    [Fact]
    public async Task Post_ProcessPayment_ExactTotalDebt_PaysAllLoans()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(2000).Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_ExactTotal_Loan1");

        await Task.Delay(100);

        var loan2 = _dataHelper.CreateLoanAccountBuilder()
            .WithCustomerId(created1.CustomerId)
            .WithTotalAmount(3000).Build();
        await CreateLoanAccountAsync(loan2, "Post_ProcessPayment_ExactTotal_Loan2");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 5000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_ExactTotal");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.RemainingUnallocated.ShouldBe(0);
        result.Allocations.All(a => a.Status == "Paid").ShouldBeTrue();
    }

    [Fact]
    public async Task Post_ProcessPayment_ExceedsTotalDebt_ReturnsBadRequest()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(5000).Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_ExceedsDebt_Loan1");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 10000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_ExceedsDebt");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    //[Fact]
    //public async Task Post_ProcessPayment_SequentialPayments_UpdatesCorrectly()
    //{
    //    var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(10000).Build();
    //    var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_Sequential_Loan1");

    //    var payment1 = new CustomerPaymentDto
    //    {
    //        CustomerId = created1.CustomerId,
    //        PaymentAmount = 3000,
    //        PaymentDate = DateTime.UtcNow,
    //        PaymentMethod = "Cash"
    //    };

    //    var response1 = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment1);
    //    response1.StatusCode.ShouldBe(HttpStatusCode.OK);

    //    var payment2 = new CustomerPaymentDto
    //    {
    //        CustomerId = created1.CustomerId,
    //        PaymentAmount = 4000,
    //        PaymentDate = DateTime.UtcNow,
    //        PaymentMethod = "BankTransfer"
    //    };

    //    var response2 = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment2);
    //    await LogIfError(response2, "Post_ProcessPayment_Sequential_Second");
    //    response2.StatusCode.ShouldBe(HttpStatusCode.OK);

    //    var result2 = await response2.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
    //    result2.ShouldNotBeNull();
    //    result2!.Allocations[0].RemainingAfterPayment.ShouldBe(3000);
    //    result2.Allocations[0].Status.ShouldBe("PartiallyPaid");
    //}

    [Fact]
    public async Task Post_ProcessPayment_WithDifferentDates_ProcessesCorrectly()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder()
            .WithTotalAmount(5000)
            .WithDueDate(DateTime.UtcNow.AddDays(30))
            .Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_DifferentDates_Loan1");

        await Task.Delay(100);

        var loan2 = _dataHelper.CreateLoanAccountBuilder()
            .WithCustomerId(created1.CustomerId)
            .WithTotalAmount(7000)
            .WithDueDate(DateTime.UtcNow.AddDays(60))
            .Build();
        await CreateLoanAccountAsync(loan2, "Post_ProcessPayment_DifferentDates_Loan2");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 6000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_DifferentDates");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.Allocations.Count.ShouldBe(2);
    }

    //[Fact]
    //public async Task Post_ProcessPayment_CompletePayoffSequence_AllLoansPaid()
    //{
    //    var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(2000).Build();
    //    var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_CompletePayoff_Loan1");

    //    await Task.Delay(100);

    //    var loan2 = _dataHelper.CreateLoanAccountBuilder()
    //        .WithCustomerId(created1.CustomerId)
    //        .WithTotalAmount(3000).Build();
    //    await CreateLoanAccountAsync(loan2, "Post_ProcessPayment_CompletePayoff_Loan2");

    //    var payment1 = new CustomerPaymentDto
    //    {
    //        CustomerId = created1.CustomerId,
    //        PaymentAmount = 2500,
    //        PaymentDate = DateTime.UtcNow,
    //        PaymentMethod = "Cash"
    //    };
    //    await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment1);

    //    var payment2 = new CustomerPaymentDto
    //    {
    //        CustomerId = created1.CustomerId,
    //        PaymentAmount = 2500,
    //        PaymentDate = DateTime.UtcNow,
    //        PaymentMethod = "Cash"
    //    };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", payment2);
        await LogIfError(response, "Post_ProcessPayment_CompletePayoff");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.Allocations.All(a => a.RemainingAfterPayment == 0).ShouldBeTrue();
    }

    [Fact]
    public async Task Post_ProcessPayment_SmallPaymentOnLargeLoan_PartiallyPaid()
    {
        var loan1 = _dataHelper.CreateLoanAccountBuilder().WithTotalAmount(50000).Build();
        var created1 = await CreateLoanAccountAsync(loan1, "Post_ProcessPayment_SmallPayment_Loan1");

        var paymentDto = new CustomerPaymentDto
        {
            CustomerId = created1.CustomerId,
            PaymentAmount = 1000,
            PaymentDate = DateTime.UtcNow,
            PaymentMethod = "Cash"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.LoanAccount}/process-payment", paymentDto);
        await LogIfError(response, "Post_ProcessPayment_SmallPayment");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var result = await response.Content.ReadFromJsonAsync<PaymentAllocationResultDto>();
        result.ShouldNotBeNull();
        result!.Allocations[0].RemainingAfterPayment.ShouldBe(49000);
        result.Allocations[0].Status.ShouldBe("PartiallyPaid");
    }
}
