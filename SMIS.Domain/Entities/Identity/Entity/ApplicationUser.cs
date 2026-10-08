using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationUser : IdentityUser<string>, IEntityPK
{
    public override string Id { get; set; } = Guid.NewGuid().ToString();
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string ShopId { get; private set; } = string.Empty;
    public string LanguageId { get; private set; } = LanguageDefaults.EnglishId;
    public string? ShopName { get; set; }
    public bool IsActive { get; private set; } = true;

    /// <summary>
    /// Monotonic session generation captured by refresh tokens. Changing it invalidates
    /// refresh-token renewal for older sessions; already-issued short-lived access tokens
    /// remain valid until their normal expiration.
    /// </summary>
    public int SecurityVersion { get; private set; }

    public int Version { get; set; }
    public DateTime LastModifiedUtc { get; set; }

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual Language Language { get; set; } = null!;

    internal ApplicationUser()
    {
    } // EF Core & Seeding

    public static ApplicationUser Create(
        string userName,
        string email,
        string shopId,
        string? firstName = null,
        string? lastName = null,
        string? phoneNumber = null,
        string? languageId = null
    )
    {
        var user = new ApplicationUser();
        user.SetUserName(userName);
        user.SetEmail(email);
        user.SetShopId(shopId);
        user.SetLanguageId(languageId ?? LanguageDefaults.EnglishId);
        user.SetFirstName(firstName);
        user.SetLastName(lastName);
        user.SetPhoneNumber(phoneNumber);
        user.EmailConfirmed = false;
        user.PhoneNumberConfirmed = false;
        return user;
    }

    public void SetUserName(
        string userName
    )
    {
        UserName = userName.Trim();
    }

    public void SetEmail(
        string email
    )
    {
        var emailVO = ValueObjects.Email.Create(email);
        Email = emailVO;
    }

    public void SetShopId(
        string shopId
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public void SetFirstName(
        string? firstName
    )
    {
        FirstName = firstName?.Trim();
    }

    public void SetLastName(
        string? lastName
    )
    {
        LastName = lastName?.Trim();
    }


    public void SetPhoneNumber(
        string? phoneNumber
    )
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

    public void SetLanguageId(
        string languageId
    )
    {
        if (string.IsNullOrWhiteSpace(languageId))
            throw new DomainValidationException("Language ID cannot be empty");

        LanguageId = languageId;
    }

    public void ConfirmEmail() => EmailConfirmed = true;
    public void ConfirmPhoneNumber() => PhoneNumberConfirmed = true;
    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;

    /// <summary>
    /// Advances the session generation so refresh tokens issued for an older generation
    /// are rejected. This intentionally does not revoke an already-issued access token;
    /// the access token remains usable only until its configured short lifetime expires.
    /// </summary>
    public void InvalidateSessions() => SecurityVersion++;
}