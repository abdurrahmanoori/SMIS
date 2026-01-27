using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities;

public class Category : BaseAuditableEntity
{
    //public string Name { get; set; } = string.Empty; // "Beverages", "Soft Drinks"
    public string? Code { get; set; } = string.Empty; // "BEV", "SOFT"
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation Properties
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
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