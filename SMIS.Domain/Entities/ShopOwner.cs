using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class ShopOwner : BaseAuditableEntity
{
    public string ApplicationUserId { get; private set; } = string.Empty;
    public string ShopId { get; private set; } = string.Empty;
    public string ShopName { get; set; } = string.Empty;
    public string FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? NationalIdCardNumber { get; private set; }
    public string? PhoneNumber { get; private set; }
    public string? Email { get; private set; }
    public string? Address { get; private set; }
    public decimal OwnershipPercentage { get; private set; } = 100.0m;
    // Tracks ownership period
    public DateTime StartDate { get; private set; } = DateTime.Now;
    // Tracks ownership period
    public DateTime? EndDate { get; private set; }
    // Current ownership status
    public bool IsActive { get; private set; } = true;
    public string? ProvinceId { get; private set; } = null;
    public string? DistrictId { get; private set; } = null;

    // Navigation Properties
    public virtual ApplicationUser User { get; set; } = null!;
    public virtual Shop Shop { get; set; } = null!;

    internal ShopOwner() { } // EF Core & Seeding

    public static ShopOwner Create(string userId, string shopId, string? firstName = null, string? lastName = null, 
        string? phoneNumber = null, string? email = null, string? address = null, decimal ownershipPercentage = 100.0m)
    {
        var owner = new ShopOwner();
        owner.SetUserId(userId);
        owner.SetShopId(shopId);
        owner.SetFirstName(firstName);
        owner.SetLastName(lastName);
        owner.SetPhoneNumber(phoneNumber);
        owner.SetEmail(email);
        owner.SetAddress(address);
        owner.SetOwnershipPercentage(ownershipPercentage);
        return owner;
    }

    public void SetUserId(string userId)
    {
        if (string.IsNullOrWhiteSpace(userId))
            throw new DomainValidationException("User ID cannot be empty");

        ApplicationUserId = userId;
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public void SetFirstName(string? firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            throw new DomainValidationException("First name cannot be empty");
        }
        if (firstName?.Length > 100)
            throw new DomainValidationException("First name cannot exceed 100 characters");

        FirstName = firstName?.Trim();
    }

    public void SetLastName(string? lastName)
    {
        if (lastName?.Length > 100)
            throw new DomainValidationException("Last name cannot exceed 100 characters");

        LastName = lastName?.Trim();
    }

    public void SetNationalIdCardNumber(string? idCardNumber)
    {
        if (idCardNumber?.Length > 50)
            throw new DomainValidationException("National ID Card Number cannot exceed 50 characters");
        NationalIdCardNumber = idCardNumber?.Trim();
    }

    public void SetPhoneNumber(string? phoneNumber)
    {
        if (!string.IsNullOrWhiteSpace(phoneNumber))
        {
            var phoneVO = ValueObjects.PhoneNumber.Create(phoneNumber);
            PhoneNumber = phoneVO;
        }
        else
        {
            PhoneNumber = null;
        }
    }

    public void SetEmail(string? email)
    {
        if (!string.IsNullOrWhiteSpace(email))
        {
            var emailVO = ValueObjects.Email.Create(email);
            Email = emailVO;
        }
        else
        {
            Email = null;
        }
    }

    public void SetAddress(string? address)
    {
        if (address?.Length > 500)
            throw new DomainValidationException("Address cannot exceed 500 characters");

        Address = address?.Trim();
    }

    public void SetOwnershipPercentage(decimal percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new DomainValidationException("Ownership percentage must be between 0 and 100");

        OwnershipPercentage = percentage;
    }

    public void SetEndDate(DateTime? endDate)
    {
        if (endDate.HasValue && endDate.Value <= StartDate)
            throw new DomainValidationException("End date must be after start date");

        EndDate = endDate;
        if (endDate.HasValue)
            IsActive = false;
    }

    public void Activate() => IsActive = true;
    public void Deactivate() 
    {
        IsActive = false;
        EndDate = DateTime.Now;
    }

    public string GetFullName() => $"{FirstName} {LastName}".Trim();
}


/*
This allows for scenarios like:
Single owner(100% ownership)
Multiple owners with different percentages
Ownership transfers over time
Historical ownership tracking
 */