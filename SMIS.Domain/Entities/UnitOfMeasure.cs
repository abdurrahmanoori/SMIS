using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;

namespace SMIS.Domain.Entities;

/// <summary>
/// Global unit dictionary such as Piece, Kilogram, Box, or Bottle.
/// A unit only supplies the label; product-specific meaning such as
/// "1 Box = 12 Bottles" belongs to <see cref="ProductUnit"/>.
/// </summary>
public class UnitOfMeasure : BaseSyncableAuditableEntity
{
    public string Name { get; private set; } = null!;

    /// <summary>
    /// Short display symbol such as pcs, kg, g, ml, or L.
    /// This is reference data, not a conversion factor.
    /// </summary>
    public string? Symbol { get; private set; } = null!;

    /// <summary>
    /// Optional human-readable explanation of the unit.
    /// </summary>
    public string? Description { get; private set; } = null!;

    // ProductUnit supplies the product-specific conversion semantics for this unit label.
    public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();

    internal UnitOfMeasure()
    {
    } // EF Core & Seeding

    public static UnitOfMeasure Create(
        string name,
        string? symbol,
        string? description = null
    )
    {
        var unit = new UnitOfMeasure();
        unit.SetName(name);
        unit.SetSymbol(symbol);
        unit.SetDescription(description);
        return unit;
    }

    public void SetName(
        string name
    )
    {
        var unitName = UnitName.Create(name);
        Name = unitName;
    }

    public void SetSymbol(
        string? symbol
    )
    {
        var unitSymbol = UnitSymbol.Create(symbol);
        Symbol = unitSymbol;
    }

    public void SetDescription(
        string? description
    )
    {
        Description = description?.Trim();
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