using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.UI.Models;

namespace SMIS.UI.Services;

public interface ILoanAccountService
{
    Task<ApiResponse<PaymentAllocationResultDto>> ProcessPaymentAsync(ProcessPaymentRequest request);
}

public class LoanAccountService : ILoanAccountService
{
    private readonly IApiClient _apiClient;

    public LoanAccountService(IApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    public async Task<ApiResponse<PaymentAllocationResultDto>> ProcessPaymentAsync(ProcessPaymentRequest request)
    {
        return await _apiClient.PostAsync<ProcessPaymentRequest, PaymentAllocationResultDto>(
            "/api/loanaccounts/process-payment",
            request
        );
    }
}
