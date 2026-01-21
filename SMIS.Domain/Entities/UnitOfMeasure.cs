using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities
{
    public class UnitOfMeasure : EntityPK
    {
        public string Name { get; set; } = null!;
        // Example: Piece, Gram, Milliliter, Liter, Box, Pack, Bottle
        public string Symbol { get; set; } = null!;
        // pcs, g, ml, l, box, pack
        public string? Description { get; set; } = null!;

    }
}

/*
 Real data examples
| Name       | Symbol |
| ---------- | ------ |
| Piece      | pcs    |
| Gram       | g      |
| Milliliter | ml     |
| Box        | box    |
| Bottle     | btl    |
 
 */
