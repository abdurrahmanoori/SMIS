namespace SMIS.Application.DTO.LoanAccounts;

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
