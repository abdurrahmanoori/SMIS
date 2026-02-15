namespace SMIS.Application.DTO.LoanAccounts;

public class CustomerPaymentDto
{
    public string CustomerId { get; set; } = string.Empty;
    public long PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } = "Cash";
    public string? Notes { get; set; }
}
