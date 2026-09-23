namespace SMIS.Application.DTO.LoanAccounts;

/// <summary>
/// Fallback command contract for creating a receivable for an existing credit sale.
/// Normal credit-sale creation already creates the receivable atomically with the sale.
/// </summary>
public class LoanAccountCreateDto
{
    public string SaleId { get; set; } = string.Empty;
    public DateTime? DueDate { get; set; }
    public string? Notes { get; set; }
}

public class LoanAccountUpdateDto
{
    public DateTime? DueDate { get; set; }
    public string? Notes { get; set; }
    public bool IsActive { get; set; } = true;
}