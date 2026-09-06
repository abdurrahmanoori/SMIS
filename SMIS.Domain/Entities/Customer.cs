using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

public class Customer : BaseAuditableEntity, IShopEntity
{
    public string FirstName { get; private set; } = string.Empty;
    public string? LastName { get; private set; }
    public string ShopId { get; private set; } = string.Empty;
    public string? ShopName { get; private set; }
    public CustomerType CustomerType { get; private set; } 
    public string? FatherName { get; private set; }
    public string? Email { get; private set; }
    public string? PhoneNumber { get; private set; }
    public string? Address { get; private set; }
    public string? TaxNumber { get; private set; }
    public bool IsActive { get; private set; } = true;
    public string? DeletedBy { get; private set; }
    public string? ProvinceId { get; private set; }
    public string? DistrictId { get; private set; }

    // Client timestamps are separate from the trusted server audit fields.
    public DateTime? ClientCreatedDate { get; private set; }
    public DateTime? ClientModifiedDate { get; private set; }
    public string? ClientCreatedBy { get; private set; }
    public string? ClientModifiedBy { get; private set; }

    public Shop? Shop { get; set; }
    public Province? Province { get; set; }
    public District? District { get; set; }

    internal Customer() { } // EF Core & Seeding

    public static Customer Create(string firstName, string shopId, CustomerType customerType = CustomerType.Individual, string? lastName = null, string? fatherName = null, 
        string? email = null, string? phoneNumber = null, string? address = null, string? taxNumber = null, 
        string? provinceId = null, string? districtId = null, bool isActive = true)
    {
        var customer = new Customer();
        customer.SetFirstName(firstName);
        customer.SetShopId(shopId);
        customer.SetCustomerType(customerType);
        customer.SetLastName(lastName);
        customer.SetFatherName(fatherName);
        customer.SetEmail(email);
        customer.SetPhoneNumber(phoneNumber);
        customer.SetAddress(address);
        customer.SetTaxNumber(taxNumber);
        customer.SetProvinceId(provinceId);
        customer.SetDistrictId(districtId);
        if (!isActive) customer.Deactivate();
        return customer;
    }

    public void SetFirstName(string firstName)
    {
        FirstName = firstName.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId.Trim();
    }

    public void SetCustomerType(CustomerType customerType)
    {
        CustomerType = customerType;
    }

    public void SetLastName(string? lastName)
    {
        LastName = string.IsNullOrWhiteSpace(lastName) ? null : lastName.Trim();
    }

    public void SetFatherName(string? fatherName)
    {
        FatherName = string.IsNullOrWhiteSpace(fatherName) ? null : fatherName.Trim();
    }

    public void SetEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            Email = null;
            return;
        }

        var emailVO = ValueObjects.Email.Create(email);
        Email = emailVO;
    }

    public void SetPhoneNumber(string? phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            PhoneNumber = null;
            return;
        }

        var phone = ValueObjects.PhoneNumber.Create(phoneNumber);
        PhoneNumber = phone;
    }

    public void SetAddress(string? address)
    {
        Address = string.IsNullOrWhiteSpace(address) ? null : address.Trim();
    }

    public void SetTaxNumber(string? taxNumber)
    {
        if (string.IsNullOrWhiteSpace(taxNumber))
        {
            TaxNumber = null;
            return;
        }

        var tax = ValueObjects.TaxNumber.Create(taxNumber);
        TaxNumber = tax;
    }

    public void SetProvinceId(string? provinceId)
    {
        ProvinceId = string.IsNullOrWhiteSpace(provinceId) ? null : provinceId.Trim();
    }

    public void SetDistrictId(string? districtId)
    {
        DistrictId = string.IsNullOrWhiteSpace(districtId) ? null : districtId.Trim();
    }

    public void SetShopName(string? shopName)
    {
        ShopName = string.IsNullOrWhiteSpace(shopName) ? null : shopName.Trim();
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;

    public void SetClientCreationMetadata(DateTime createdDateUtc, string? createdBy)
    {
        ClientCreatedDate = DateTimeService.NormalizeUtc(createdDateUtc);
        ClientCreatedBy = NormalizeUserId(createdBy);
    }

    public void SetClientModificationMetadata(DateTime modifiedDateUtc, string? modifiedBy)
    {
        ClientModifiedDate = DateTimeService.NormalizeUtc(modifiedDateUtc);
        ClientModifiedBy = NormalizeUserId(modifiedBy);
    }

    public void ClearClientModificationMetadata()
    {
        ClientModifiedDate = null;
        ClientModifiedBy = null;
    }

    public void Delete(string deletedBy)
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
        DeletedBy = deletedBy;
        Deactivate();
    }

    public void Restore()
    {
        IsDeleted = false;
        DeletedAt = null;
        DeletedBy = null;
        Activate();
    }

    public DateTime GetConflictModifiedUtc() => DateTimeService.NormalizeUtc(
        ClientModifiedDate
        ?? UpdatedDate
        ?? ClientCreatedDate
        ?? CreatedDate
        ?? LastModifiedUtc);

    private static string? NormalizeUserId(string? value) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}
