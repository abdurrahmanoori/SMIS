using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>().HasData(
            // Coca Cola 500ml (Product 1) - Base unit: Bottle (Unit 2)
            CreateProductPrice("1", "1", "2", 140, 160, new DateTime(2024, 1, 1), new DateTime(2024, 6, 30), false),
            CreateProductPrice("2", "1", "2", 150, 170, new DateTime(2024, 7, 1), null, true),

            // Pepsi 500ml (Product 2) - Base unit: Bottle (Unit 2)
            CreateProductPrice("3", "2", "2", 130, 150, new DateTime(2024, 1, 1), new DateTime(2024, 5, 31), false),
            CreateProductPrice("4", "2", "2", 135, 155, new DateTime(2024, 6, 1), null, true),

            // Mineral Water 1L (Product 3) - Base unit: Bottle (Unit 2)
            CreateProductPrice("5", "3", "2", 70, 90, new DateTime(2024, 1, 1), null, true),

            // Oreo Biscuits (Product 4) - Base unit: Pack (Unit 3)
            CreateProductPrice("6", "4", "3", 230, 270, new DateTime(2024, 1, 1), new DateTime(2024, 8, 31), false),
            CreateProductPrice("7", "4", "3", 250, 290, new DateTime(2024, 9, 1), null, true),

            // Lay's Chips (Product 5) - Base unit: Pack (Unit 3)
            CreateProductPrice("8", "5", "3", 160, 190, new DateTime(2024, 1, 1), null, true),

            // Instant Noodles (Product 6) - Base unit: Pack (Unit 3)
            CreateProductPrice("9", "6", "3", 110, 130, new DateTime(2024, 1, 1), new DateTime(2024, 4, 30), false),
            CreateProductPrice("10", "6", "3", 115, 135, new DateTime(2024, 5, 1), null, true),

            // A4 Notebook (Product 7) - Base unit: Piece (Unit 1)
            CreateProductPrice("11", "7", "1", 280, 320, new DateTime(2024, 1, 1), null, true),

            // Blue Pen (Product 8) - Base unit: Piece (Unit 1)
            CreateProductPrice("12", "8", "1", 45, 55, new DateTime(2024, 1, 1), null, true),

            // Pencil Set (Product 9) - Base unit: Box (Unit 4)
            CreateProductPrice("13", "9", "4", 380, 420, new DateTime(2024, 1, 1), null, true),

            // Cooking Oil 1L (Product 10) - Base unit: Bottle (Unit 2)
            CreateProductPrice("14", "10", "2", 430, 470, new DateTime(2024, 1, 1), new DateTime(2024, 3, 31), false),
            CreateProductPrice("15", "10", "2", 460, 500, new DateTime(2024, 4, 1), null, true),

            // Rice 1kg (Product 11) - Base unit: Kilogram (Unit 7)
            CreateProductPrice("16", "11", "7", 260, 300, new DateTime(2024, 1, 1), null, true),

            // Sugar 1kg (Product 12) - Base unit: Kilogram (Unit 7)
            CreateProductPrice("17", "12", "7", 180, 220, new DateTime(2024, 1, 1), null, true),

            // Shampoo 400ml (Product 13) - Base unit: Bottle (Unit 2)
            CreateProductPrice("18", "13", "2", 330, 370, new DateTime(2024, 1, 1), null, true),

            // Toothpaste (Product 14) - Base unit: Piece (Unit 1)
            CreateProductPrice("19", "14", "1", 160, 200, new DateTime(2024, 1, 1), null, true),

            // USB Cable (Product 15) - Base unit: Piece (Unit 1)
            CreateProductPrice("20", "15", "1", 230, 270, new DateTime(2024, 1, 1), null, true),

            // Phone Charger (Product 16) - Base unit: Piece (Unit 1)
            CreateProductPrice("21", "16", "1", 750, 850, new DateTime(2024, 1, 1), new DateTime(2024, 6, 30), false),
            CreateProductPrice("22", "16", "1", 700, 800, new DateTime(2024, 7, 1), null, true)
        );
    }

    private static ProductPrice CreateProductPrice(string id, string productId, string unitId, long buyPrice, long sellPrice, DateTime effectiveDate, DateTime? endDate, bool isActive)
    {
        var productPrice = ProductPrice.Create(productId, unitId, buyPrice, sellPrice, effectiveDate);
        productPrice.SetEndDate(endDate);
        if (isActive) productPrice.Activate(); else productPrice.Deactivate();

        typeof(ProductPrice).GetProperty(nameof(ProductPrice.Id))!.SetValue(productPrice, id);

        return productPrice;
    }
}
