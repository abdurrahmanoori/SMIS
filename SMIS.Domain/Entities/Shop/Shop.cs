using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Shop
{
    public class Shop : BaseAuditableEntity
    {
        public ShopType ShopType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Invoice> IssuedInvoices { get; set; } = new List<Invoice>();
        public virtual ICollection<Invoice> PurchasedInvoices { get; set; } = new List<Invoice>();
        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public virtual ICollection<ShopCreditAccount> CreditAccountsAsCreditor { get; set; } = new List<ShopCreditAccount>();
        public virtual ICollection<ShopCreditAccount> CreditAccountsAsDebtor { get; set; } = new List<ShopCreditAccount>();
    }
}
