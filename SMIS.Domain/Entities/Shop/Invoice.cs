
//using SMIS.Domain.Common.BaseAbstract;
//using SMIS.Domain.Enums;

//namespace SMIS.Domain.Entities.Shopp
//{
//    public class Invoice : BaseAuditableEntityWithoutName
//    {
//        public string InvoiceNumber { get; set; }
//        public TransactionType TransactionType { get; set; } // Sale, Purchase, Return
//        public DateTime InvoiceDate { get; set; }
//        public DateTime DueDate { get; set; }
        
//        // Issuer (always required)
//        public int IssuerShopId { get; set; }
        
//        // Only ONE of these should be set - enforced by business logic
//        // BuyerShopId for B2B (wholesale to retail)
//        // CustomerId for B2C (retail to customer)
//        public int? BuyerShopId { get; set; }
//        public int? CustomerId { get; set; }
        
//        public decimal SubTotal { get; set; }
//        public decimal TaxAmount { get; set; }
//        public decimal DiscountAmount { get; set; }
//        public decimal TotalAmount { get; set; }
        
//        // Removed derived fields - calculate from Payments collection
//        // public decimal PaidAmount { get; set; }
//        // public decimal BalanceAmount { get; set; }
//        // public PaymentStatus PaymentStatus { get; set; }
//        public string Notes { get; set; }

//        // Navigation Properties
//        public virtual Shop IssuerShop { get; set; }
//        public virtual Shop BuyerShop { get; set; }
//        public virtual Customer Customer { get; set; }
//        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
//        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
//    }
//}
