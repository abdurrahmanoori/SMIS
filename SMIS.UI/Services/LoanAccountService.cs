using SMIS.UI.Models;
using SMIS.UI.Services.Base;
using SMIS.UI.Services.Http;

namespace SMIS.UI.Services;

public interface ILoanAccountService
{
    Task<ApiResponse<PaymentAllocationResultDto>> ProcessPaymentAsync(ProcessPaymentRequest request);
}

public class LoanAccountService : BaseService, ILoanAccountService
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

public class ProcessPaymentRequest
{
    public string CustomerId { get; set; } = string.Empty;
    public long PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } = "Cash";
    public string? Notes { get; set; }
}

public class PaymentAllocationResultDto
{
    public long TotalPaid { get; set; }
    public List<LoanPaymentAllocationDto> Allocations { get; set; } = new();
    public long RemainingUnallocated { get; set; }
}

public class LoanPaymentAllocationDto
{
    public string LoanAccountId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public long AllocatedAmount { get; set; }
    public long RemainingAfterPayment { get; set; }
    public string Status { get; set; } = string.Empty;
}
