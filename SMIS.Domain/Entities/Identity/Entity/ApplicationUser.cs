using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationUser : IdentityUser<string>, IEntityPK
{
    public override string Id { get; set; } = Guid.NewGuid().ToString();
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string ShopId { get; private set; } = string.Empty;
    public string LanguageId { get; private set; } = "1";
    public string? ShopName { get; set; }
    public int Version { get; set; }
    public EntityStateEnum EntityState { get; set; }
    public DateTimeOffset LastModifiedUtc { get; set; }

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual Language Language { get; set; } = null!;

    internal ApplicationUser() { } // EF Core & Seeding

    public static ApplicationUser Create(string userName, string email, string shopId, string? firstName = null, string? lastName = null, string? phoneNumber = null, string? languageId = null)
    {
        var user = new ApplicationUser();
        user.SetUserName(userName);
        user.SetEmail(email);
        user.SetShopId(shopId);
        user.SetLanguageId(languageId ?? "1");
        user.SetFirstName(firstName);
        user.SetLastName(lastName);
        user.SetPhoneNumber(phoneNumber);
        user.EmailConfirmed = false;
        user.PhoneNumberConfirmed = false;
        return user;
    }

    public void SetUserName(string userName)
    {
        if (string.IsNullOrWhiteSpace(userName))
            throw new DomainValidationException("Username cannot be empty");

        if (userName.Length > 256)
            throw new DomainValidationException("Username cannot exceed 256 characters");

        UserName = userName.Trim();
    }

    public void SetEmail(string email)
    {
        var emailVO = ValueObjects.Email.Create(email);
        Email = emailVO;
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public void SetFirstName(string? firstName)
    {
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

    public void SetLanguageId(string languageId)
    {
        if (string.IsNullOrWhiteSpace(languageId))
            throw new DomainValidationException("Language ID cannot be empty");

        LanguageId = languageId;
    }

    public void ConfirmEmail() => EmailConfirmed = true;
    public void ConfirmPhoneNumber() => PhoneNumberConfirmed = true;
}
