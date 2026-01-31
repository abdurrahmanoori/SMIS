using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;

namespace SMIS.Domain.Entities;

public class Shop : BaseAuditableEntity
{
    public ShopType ShopType { get; private set; }
    public string? Address { get; private set; } = string.Empty;
    public string? PhoneNumber { get; private set; } = string.Empty;
    public string? Email { get; private set; } = string.Empty;
    public string? TaxNumber { get; private set; } = string.Empty;
    public bool IsActive { get; private set; } = true;

    // Navigation Properties
    //public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    //public virtual ICollection<Invoice> IssuedInvoices { get; set; } = new List<Invoice>();
    //public virtual ICollection<Invoice> PurchasedInvoices { get; set; } = new List<Invoice>();
    //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    //public virtual ICollection<ShopCreditAccount> CreditAccountsAsCreditor { get; set; } = new List<ShopCreditAccount>();
    //public virtual ICollection<ShopCreditAccount> CreditAccountsAsDebtor { get; set; } = new List<ShopCreditAccount>();

    internal Shop() { } // EF Core & Seeding

    public static Shop Create(string name, ShopType shopType, string address, string phoneNumber, string email, string taxNumber, bool isActive = true)
    {
        var shop = new Shop();
        shop.SetName(name);
        shop.SetShopType(shopType);
        shop.SetAddress(address);
        shop.SetPhoneNumber(phoneNumber);
        shop.SetEmail(email);
        shop.SetTaxNumber(taxNumber);
        if (!isActive) shop.Deactivate();
        return shop;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Shop name cannot be empty");

        if (name.Length > 200)
            throw new DomainValidationException("Shop name cannot exceed 200 characters");

        Name = name.Trim();
    }

    public void SetShopType(ShopType shopType)
    {
        if (!Enum.IsDefined(typeof(ShopType), shopType))
            throw new DomainValidationException("Invalid shop type");

        ShopType = shopType;
    }

    public void SetAddress(string address)
    {
        //if (string.IsNullOrWhiteSpace(address))
        //    throw new DomainValidationException("Address cannot be empty");

        if (address.Length > 500)
            throw new DomainValidationException("Address cannot exceed 500 characters");

        Address = address.Trim();
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        var phone = ValueObjects.PhoneNumber.Create(phoneNumber);
        PhoneNumber = phone;
    }

    public void SetEmail(string email)
    {
        var emailVO = ValueObjects.Email.Create(email);
        Email = emailVO;
    }

    public void SetTaxNumber(string taxNumber)
    {
        var tax = ValueObjects.TaxNumber.Create(taxNumber);
        TaxNumber = tax;
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}
