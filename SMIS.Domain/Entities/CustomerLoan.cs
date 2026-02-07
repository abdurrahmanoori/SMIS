using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class CustomerLoan : BaseAuditableEntity
{
    public string CustomerId { get; private set; } = string.Empty;
    public string ShopId { get; private set; } = string.Empty;
    public string ProductId { get; private set; } = string.Empty;
    public decimal Quantity { get; private set; }
    public string UnitId { get; private set; } = string.Empty;
    public long TotalAmount { get; private set; }
    public long PaidAmount { get; private set; }
    public long RemainingAmount { get; private set; }
    public DateTime LoanDate { get; private set; }
    public DateTime? DueDate { get; private set; }
    public string Status { get; private set; } = "Active";
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Customer? Customer { get; set; }
    public Shop? Shop { get; set; }
    public Product? Product { get; set; }
    public UnitOfMeasure? UnitOfMeasure { get; set; }
    public ICollection<CustomerLoanPayment> Payments { get; set; } = new List<CustomerLoanPayment>();

    internal CustomerLoan() { }

    public static CustomerLoan Create(string customerId, string shopId, string productId, decimal quantity, string unitId, long totalAmount, DateTime? dueDate = null, string? notes = null)
    {
        var loan = new CustomerLoan();
        loan.SetCustomerId(customerId);
        loan.SetShopId(shopId);
        loan.SetProductId(productId);
        loan.SetQuantity(quantity);
        loan.SetUnitId(unitId);
        loan.SetTotalAmount(totalAmount);
        loan.SetLoanDate(DateTime.UtcNow);
        loan.SetDueDate(dueDate);
        loan.SetNotes(notes);
        loan.CalculateRemainingAmount();
        return loan;
    }

    public void SetCustomerId(string customerId)
    {
        if (string.IsNullOrWhiteSpace(customerId))
            throw new DomainValidationException("Customer ID cannot be empty");
        CustomerId = customerId.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        ShopId = shopId.Trim();
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        ProductId = productId.Trim();
    }

    public void SetQuantity(decimal quantity)
    {
        if (quantity <= 0)
            throw new DomainValidationException("Quantity must be greater than zero");
        Quantity = quantity;
    }

    public void SetUnitId(string unitId)
    {
        if (string.IsNullOrWhiteSpace(unitId))
            throw new DomainValidationException("Unit ID cannot be empty");
        UnitId = unitId.Trim();
    }

    public void SetTotalAmount(long totalAmount)
    {
        if (totalAmount <= 0)
            throw new DomainValidationException("Total amount must be greater than zero");
        TotalAmount = totalAmount;
    }

    public void SetLoanDate(DateTime loanDate)
    {
        LoanDate = loanDate;
    }

    public void SetDueDate(DateTime? dueDate)
    {
        if (dueDate.HasValue && dueDate.Value <= LoanDate)
            throw new DomainValidationException("Due date must be after loan date");
        DueDate = dueDate;
    }

    public void SetNotes(string? notes)
    {
        if (!string.IsNullOrWhiteSpace(notes) && notes.Length > 500)
            throw new DomainValidationException("Notes cannot exceed 500 characters");
        Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim();
    }

    public void AddPayment(long amount, DateTime paymentDate, string? paymentNotes = null)
    {
        if (amount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");
        if (amount > RemainingAmount)
            throw new DomainValidationException("Payment amount cannot exceed remaining amount");

        PaidAmount += amount;
        CalculateRemainingAmount();
        
        if (RemainingAmount == 0)
            Status = "Paid";
    }

    private void CalculateRemainingAmount()
    {
        RemainingAmount = TotalAmount - PaidAmount;
    }

    public void MarkAsOverdue()
    {
        if (DueDate.HasValue && DateTime.UtcNow > DueDate.Value && RemainingAmount > 0)
            Status = "Overdue";
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}