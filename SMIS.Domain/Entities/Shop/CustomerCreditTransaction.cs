using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Shopp
{
    public class CustomerCreditTransaction : BaseAuditableEntityWithoutName
    {
        public int CustomerCreditAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public decimal BalanceAfter { get; set; }
        public string Description { get; set; }
        public string ReferenceNumber { get; set; }

        // Navigation Properties
        public virtual CustomerCreditAccount CustomerCreditAccount { get; set; }
    }
}
