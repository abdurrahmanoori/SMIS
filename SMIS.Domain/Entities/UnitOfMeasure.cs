using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;

namespace SMIS.Domain.Entities;

public class UnitOfMeasure : EntityPK
{
    public string Name { get; private set; } = null!;
    // Example: Piece, Gram, Milliliter, Liter, Box, Pack, Bottle
    public string? Symbol { get; private set; } = null!;
    // pcs, g, ml, l, box, pack
    public string? Description { get; private set; } = null!;
    public string ShopId { get; private set; } = string.Empty;

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();

    internal UnitOfMeasure() { } // EF Core & Seeding

    public static UnitOfMeasure Create(string name, string? symbol, string shopId, string? description = null)
    {
        var unit = new UnitOfMeasure();
        unit.SetName(name);
        unit.SetSymbol(symbol);
        unit.SetShopId(shopId);
        unit.SetDescription(description);
        return unit;
    }

    public void SetName(string name)
    {
        var unitName = UnitName.Create(name);
        Name = unitName;
    }

    public void SetSymbol(string? symbol)
    {
        var unitSymbol = UnitSymbol.Create(symbol);
        Symbol = unitSymbol;
    }

    public void SetDescription(string? description)
    {
        if (description?.Length > 500)
            throw new DomainValidationException("Description cannot exceed 500 characters");

        Description = description?.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }
}

/*
Real data examples
| Id | Name   |
| -- | ------ |
| 1  | Piece  |
| 2  | Bottle |
| 3  | Pack   |
| 4  | Liter  |
| 5  | Box    |

*/

/*
Real data examples
| Id | Name   |
| -- | ------ |
| 1  | Piece  |
| 2  | Bottle |
| 3  | Pack   |
| 4  | Liter  |
| 5  | Box    |

*/
