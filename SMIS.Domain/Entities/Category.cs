using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

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

        Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
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