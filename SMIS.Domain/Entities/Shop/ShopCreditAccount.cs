
//using SMIS.Domain.Common.BaseAbstract;
//using SMIS.Domain.Enums;

//namespace SMIS.Domain.Entities.Shopp
//{
//    public class ShopCreditAccount : BaseAuditableEntityWithoutName
//    {
//        public int CreditorShopId { get; set; } // Wholesale shop giving credit
//        public int DebtorShopId { get; set; } // Retail shop receiving credit
//        public DateTime AccountOpenDate { get; set; }
//        public decimal CreditLimit { get; set; }
//        public decimal InterestRate { get; set; }
        
//        // Removed derived fields - calculate from Transactions/Payments
//        // public decimal TotalCreditAmount { get; set; }
//        // public decimal PaidAmount { get; set; }
//        // public decimal BalanceAmount { get; set; }
//        // public CreditStatus Status { get; set; }
//        // public DateTime? LastPaymentDate { get; set; }
//        // public int DaysOverdue { get; set; }
//        public string Terms { get; set; }
//        public string Notes { get; set; }

//        // Navigation Properties
//        public virtual Shop CreditorShop { get; set; }
//        public virtual Shop DebtorShop { get; set; }
//        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
//        public virtual ICollection<ShopCreditTransaction> Transactions { get; set; } = new List<ShopCreditTransaction>();
//    }
//}
