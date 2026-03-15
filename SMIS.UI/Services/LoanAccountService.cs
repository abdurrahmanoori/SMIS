using SMIS.Application.DTO.LoanAccounts;
using SMIS.Infrastructure.Mobile.Services.Http;

namespace SMIS.UI.Services;

public interface ILoanAccountService
{
    Task<ApiResponse<PaymentAllocationResultDto>> ProcessPaymentAsync(CustomerPaymentDto request);
}

public class LoanAccountService : ILoanAccountService
{
    private readonly IApiClient _apiClient;

    public LoanAccountService(IApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    public async Task<ApiResponse<PaymentAllocationResultDto>> ProcessPaymentAsync(CustomerPaymentDto request)
    {
        return await _apiClient.PostAsync<CustomerPaymentDto, PaymentAllocationResultDto>(
            "/api/loanaccounts/process-payment",
            request
        );
    }
}
