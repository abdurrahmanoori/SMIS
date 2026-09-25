using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.ValueObjects;

namespace SMIS.Domain.Entities;

public class Category : BaseSyncableAuditableEntity, IShopEntity
{
    // English/default value retained during the Category localization proof-of-concept
    // so existing offline PowerSync writes remain backward-compatible.
    public string Name { get; private set; } = string.Empty;

    public string NameLocalizedTextId { get; private set; } = string.Empty;

    public string? Code { get; private set; }

    public string? Description { get; private set; }

    public bool IsActive { get; private set; } = true;

    public string ShopId { get; private set; } = string.Empty;

    // Navigation Properties
    public virtual LocalizedText NameLocalizedText { get; private set; } = null!;
    public virtual Shop Shop { get; set; } = null!;
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    internal Category()
    {
    } // EF Core & Seeding

    public static Category Create(
        string name,
        string shopId,
        string? code = null,
        string? description = null,
        bool isActive = true
    )
    {
        var category = new Category();
        category.SetName(name);
        category.SetShopId(shopId);
        category.SetCode(code);
        category.SetDescription(description);
        if (!isActive) category.Deactivate();
        return category;
    }

    public void SetName(
        string name
    )
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Category name cannot be empty.");

        Name = name.Trim();
    }

    public void SetNameLocalizedText(LocalizedText localizedText)
    {
        ArgumentNullException.ThrowIfNull(localizedText);

        NameLocalizedText = localizedText;
        NameLocalizedTextId = localizedText.Id;
        Name = localizedText.DefaultValue;
    }

    public void SetNameLocalizedTextId(string localizedTextId)
    {
        if (string.IsNullOrWhiteSpace(localizedTextId))
            throw new DomainValidationException("Category localized text ID cannot be empty.");

        NameLocalizedTextId = localizedTextId.Trim();
    }

    public void SetShopId(
        string shopId
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId.Trim();
    }

    public void SetCode(
        string? code
    )
    {
        var categoryCode = CategoryCode.Create(code);
        Code = categoryCode;
    }

    public void SetDescription(
        string? description
    )
    {
        Description = description?.Trim();
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}
