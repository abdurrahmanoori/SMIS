using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities;

public class UnitOfMeasure : EntityPK
{
    public string Name { get; set; } = null!;
    // Example: Piece, Gram, Milliliter, Liter, Box, Pack, Bottle
    public string Symbol { get; set; } = null!;
    // pcs, g, ml, l, box, pack
    public string? Description { get; set; } = null!;
    public string ShopId { get; set; } = string.Empty;

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();
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
