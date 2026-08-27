using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

public class Category : BaseAuditableEntity, IShopEntity, ISyncableEntity
{
    [Required]
    [MaxLength(200)]
    public string Name { get; private set; } = string.Empty;
    
   
    [MaxLength(50)]
    public string? Code { get; private set; }
    
    [MaxLength(500)]
    public string? Description { get; private set; }
    
    [Required]
    public bool IsActive { get; private set; } = true;
    
    [Required]
    public string ShopId { get; private set; } = string.Empty;

    // Client-originated sync metadata. These fields are intentionally separate
    // from the trusted server audit fields inherited from BaseAuditableEntity.
    public DateTime? ClientCreatedDate { get; private set; }
    public DateTime? ClientModifiedDate { get; private set; }
    [MaxLength(450)]
    public string? ClientCreatedBy { get; private set; }
    [MaxLength(450)]
    public string? ClientModifiedBy { get; private set; }

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    internal Category() { } // EF Core & Seeding

    public static Category Create(string name, string shopId, string? code = null, string? description = null, bool isActive = true)
    {
        var category = new Category();
        category.SetName(name);
        category.SetShopId(shopId);
        category.SetCode(code);
        category.SetDescription(description);
        if (!isActive) category.Deactivate();
        return category;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Category name cannot be empty");

        if (name.Length > 200)
            throw new DomainValidationException("Category name cannot exceed 200 characters");

        Name = name.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId.Trim();
    }

    public void SetCode(string? code)
    {
        var categoryCode = CategoryCode.Create(code);
        Code = categoryCode;
    }

    public void SetDescription(string? description)
    {
        if (!string.IsNullOrWhiteSpace(description) && description.Length > 500)
            throw new DomainValidationException("Category description cannot exceed 500 characters");

        Description =  description?.Trim();
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

    public void Restore()
    {
        IsDeleted = false;
        DeletedAt = null;
    }

    public DateTime GetConflictModifiedUtc() => DateTimeService.NormalizeUtc(
        ClientModifiedDate
        ?? UpdatedDate
        ?? ClientCreatedDate
        ?? CreatedDate
        ?? LastModifiedUtc);

    // private static DateTime NormalizeUtc(DateTime value) => value.Kind switch
    // {
    //     DateTimeKind.Utc => value,
    //     DateTimeKind.Local => value.ToUniversalTime(),
    //     _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    // };

    private static string? NormalizeUserId(string? value) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}

/*
 Purpose

Groups products (Drink, Food, Stationery, etc.)
| Id | Name       |
| -- | ---------- |
| 1  | Drinks     |
| 2  | Food       |
| 3  | Stationery |
| 4  | Grocery    |

 */
