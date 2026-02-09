using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>().HasData(
            // Coca Cola 500ml (Product 1) - ProductUnit 1 (Box=12 bottles), ProductUnit 2 (Carton=24 bottles)
            CreateProductPrice("1", "1", "1", 1680, 1920, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("2", "1", "2", 3360, 3840, new DateTime(2024, 1, 1), null, true), // Carton

            // Pepsi 500ml (Product 2) - ProductUnit 3 (Box=12), ProductUnit 4 (Carton=24)
            CreateProductPrice("3", "2", "3", 1560, 1800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("4", "2", "4", 3120, 3600, new DateTime(2024, 1, 1), null, true), // Carton

            // Mineral Water 1L (Product 3) - ProductUnit 5 (Box=6), ProductUnit 6 (Carton=12)
            CreateProductPrice("5", "3", "5", 420, 540, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("6", "3", "6", 840, 1080, new DateTime(2024, 1, 1), null, true), // Carton

            // Oreo Biscuits (Product 4) - ProductUnit 7 (Box=12 packs), ProductUnit 8 (Carton=48)
            CreateProductPrice("7", "4", "7", 2760, 3240, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("8", "4", "8", 11040, 12960, new DateTime(2024, 1, 1), null, true), // Carton

            // Lay's Chips (Product 5) - ProductUnit 9 (Box=20), ProductUnit 10 (Carton=60)
            CreateProductPrice("9", "5", "9", 3200, 3800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("10", "5", "10", 9600, 11400, new DateTime(2024, 1, 1), null, true), // Carton

            // Instant Noodles (Product 6) - ProductUnit 11 (Box=24), ProductUnit 12 (Carton=72)
            CreateProductPrice("11", "6", "11", 2640, 3120, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("12", "6", "12", 7920, 9360, new DateTime(2024, 1, 1), null, true), // Carton

            // A4 Notebook (Product 7) - ProductUnit 13 (Dozen=12), ProductUnit 14 (Box=50)
            CreateProductPrice("13", "7", "13", 3360, 3840, new DateTime(2024, 1, 1), null, true), // Dozen
            CreateProductPrice("14", "7", "14", 14000, 16000, new DateTime(2024, 1, 1), null, true), // Box

            // Blue Pen (Product 8) - ProductUnit 15 (Dozen=12), ProductUnit 16 (Box=144)
            CreateProductPrice("15", "8", "15", 540, 660, new DateTime(2024, 1, 1), null, true), // Dozen
            CreateProductPrice("16", "8", "16", 6480, 7920, new DateTime(2024, 1, 1), null, true), // Box

            // Pencil Set (Product 9) - ProductUnit 17 (Carton=20 boxes)
            CreateProductPrice("17", "9", "17", 7600, 8400, new DateTime(2024, 1, 1), null, true), // Carton

            // Cooking Oil 1L (Product 10) - ProductUnit 18 (Box=12), ProductUnit 19 (Carton=24)
            CreateProductPrice("18", "10", "18", 5160, 5640, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("19", "10", "19", 10320, 11280, new DateTime(2024, 1, 1), null, true), // Carton

            // Rice 1kg (Product 11) - ProductUnit 20 (Box=10kg), ProductUnit 21 (Carton=25kg)
            CreateProductPrice("20", "11", "20", 2600, 3000, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("21", "11", "21", 6500, 7500, new DateTime(2024, 1, 1), null, true), // Carton

            // Sugar 1kg (Product 12) - ProductUnit 22 (Box=20kg), ProductUnit 23 (Carton=50kg)
            CreateProductPrice("22", "12", "22", 3600, 4400, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("23", "12", "23", 9000, 11000, new DateTime(2024, 1, 1), null, true), // Carton

            // Shampoo 400ml (Product 13) - ProductUnit 24 (Box=12), ProductUnit 25 (Carton=24)
            CreateProductPrice("24", "13", "24", 3960, 4440, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("25", "13", "25", 7920, 8880, new DateTime(2024, 1, 1), null, true), // Carton

            // Toothpaste (Product 14) - ProductUnit 26 (Box=24), ProductUnit 27 (Carton=72)
            CreateProductPrice("26", "14", "26", 3840, 4800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("27", "14", "27", 11520, 14400, new DateTime(2024, 1, 1), null, true), // Carton

            // USB Cable (Product 15) - ProductUnit 28 (Box=50), ProductUnit 29 (Carton=200)
            CreateProductPrice("28", "15", "28", 11500, 13500, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("29", "15", "29", 46000, 54000, new DateTime(2024, 1, 1), null, true), // Carton

            // Phone Charger (Product 16) - ProductUnit 30 (Box=20), ProductUnit 31 (Carton=100)
            CreateProductPrice("30", "16", "30", 15000, 17000, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("31", "16", "31", 75000, 85000, new DateTime(2024, 1, 1), null, true) // Carton
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
