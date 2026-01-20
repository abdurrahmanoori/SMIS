using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Shopp
{
    public class Payment : BaseAuditableEntityWithoutName
    {
        public string PaymentNumber { get; set; }
        public TransactionType PaymentType { get; set; }
        
        // Only ONE of these should be set - enforced by business logic
        public int? InvoiceId { get; set; }
        public int? CustomerCreditAccountId { get; set; }
        public int? ShopCreditAccountId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // Cash, Bank Transfer, Mobile Money, etc.
        public string ReferenceNumber { get; set; }
        public string Notes { get; set; }

        // Navigation Properties
        public virtual Invoice Invoice { get; set; }
        public virtual CustomerCreditAccount CustomerCreditAccount { get; set; }
        public virtual ShopCreditAccount ShopCreditAccount { get; set; }
    }
}
