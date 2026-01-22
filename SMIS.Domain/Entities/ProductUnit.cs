using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities
{
    /// <summary>
    /// Defines how a specific Unit is converted for a specific Product.
    /// This entity exists because the same Unit (e.g. Box, Carton)
    /// can represent different quantities for different products.
    /// </summary>
    public class ProductUnit : EntityPK
    {
        /// <summary>
        /// Foreign key to the Product.
        /// Example: Biscuit, Notebook, Coca Cola
        /// </summary>
        public string ProductId { get; set; } = string.Empty;


        /// <summary>
        /// Foreign key to Unit.
        /// Example: Box, Carton, Pack
        /// </summary>
        public string UnitOfMeasureId { get; set; } = string.Empty;

        /// <summary>
        /// How many Base Units of the Product are contained in this Unit.
        /// 
        /// Example:
        /// - Biscuit: 1 Box = 12 Packs → ConversionFactor = 12
        /// - Notebook: 1 Box = 10 Pieces → ConversionFactor = 10
        /// - Coca Cola: 1 Carton = 24 Bottles → ConversionFactor = 24
        /// </summary>
        public decimal ConversionFactor { get; set; }


        /// <summary>
        /// Navigation property to Product.
        /// </summary>
        public Product Product { get; set; } = null!;

        /// <summary>
        /// Navigation property to Unit.
        /// </summary>
        public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
    }

}




/*
 📌 IMPORTANT NOTE — Why ProductUnit Exists
 

    Units do NOT mean the same thing for every product.

    A Box is not a universal quantity.

    A Carton is not a fixed number.

    A Pack depends on what is inside it.

Example from real life
| Product   | Unit   | Quantity inside |
| --------- | ------ | --------------- |
| Biscuit   | Box    | 12 Packs        |
| Notebook  | Box    | 10 Pieces       |
| Coca‑Cola | Carton | 24 Bottles      |
| Eggs      | Carton | 30 Pieces       |
Same unit name → different meaning. 

❌ Wrong Thinking (Beginner Mistake)
Box = 12
Carton = 24
This will silently destroy your inventory data.
✅ Correct Thinking (Professional Thinking)

    A unit only describes the container.
    The product defines how much that container holds.

So conversion belongs to:
Product + Unit → ConversionFactor
That is exactly why ProductUnit exists.
🧠 Mental Rule (Never Forget This)

    Unit = label
    ProductUnit = meaning

If you remember only ONE sentence from this system, remember this one.
📐 What ProductUnit Does

It answers one question:

    “For THIS product, how many base units are inside THIS unit?”

Example:
1 Box of Biscuit = 12 Packs
1 Box of Notebook = 10 Pieces
1 Carton of Coke = 24 Bottles





 */