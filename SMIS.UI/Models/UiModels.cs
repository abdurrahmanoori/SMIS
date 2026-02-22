namespace SMIS.UI.Models;

public class AppSettings
{
    public string ApiBaseUrl { get; set; } = "https://localhost:7216";
    public int TimeoutSeconds { get; set; } = 30;
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
