using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Shop
{
    public class CustomerCreditAccount : BaseAuditableEntityWithoutName
    {
        public int CustomerId { get; set; }
        public int ShopId { get; set; }
        public DateTime AccountOpenDate { get; set; }
        public decimal CreditLimit { get; set; }
        
        // Removed derived fields - calculate from Transactions/Payments
        // public decimal TotalCreditAmount { get; set; }
        // public decimal PaidAmount { get; set; }
        // public decimal BalanceAmount { get; set; }
        // public CreditStatus Status { get; set; }
        // public DateTime? LastPaymentDate { get; set; }
        // public int DaysOverdue { get; set; }
        public string Notes { get; set; }

        // Navigation Properties
        public virtual Customer Customer { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual ICollection<CustomerCreditTransaction> Transactions { get; set; } = new List<CustomerCreditTransaction>();
    }
}
