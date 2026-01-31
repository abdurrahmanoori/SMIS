//using SMIS.Domain.Common.BaseAbstract;

//namespace SMIS.Domain.Entities.Shopp
//{
//    public class Customer : BaseAuditableEntity
//    {
//        public int ShopId { get; set; }
//        public string PhoneNumber { get; set; }
//        public string Address { get; set; }
//        public string NationalId { get; set; }
//        public decimal CreditLimit { get; set; }
//        public bool IsActive { get; set; } = true;

//        // Navigation Properties
//        public virtual Shop Shop { get; set; }
//        public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
//        public virtual ICollection<CustomerCreditAccount> CreditAccounts { get; set; } = new List<CustomerCreditAccount>();
//    }
//}
