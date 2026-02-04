using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>().HasData(
            // Coca Cola 500ml price history
            CreateProductPrice("1", "1", 150, new DateTime(2024, 1, 1), new DateTime(2024, 6, 30), false),
            CreateProductPrice("2", "1", 160, new DateTime(2024, 7, 1), null, true),

            // Pepsi 500ml price history
            CreateProductPrice("3", "2", 140, new DateTime(2024, 1, 1), new DateTime(2024, 5, 31), false),
            CreateProductPrice("4", "2", 145, new DateTime(2024, 6, 1), null, true),

            // Mineral Water 1L price history
            CreateProductPrice("5", "3", 80, new DateTime(2024, 1, 1), null, true),

            // Oreo Biscuits price history
            CreateProductPrice("6", "4", 250, new DateTime(2024, 1, 1), new DateTime(2024, 8, 31), false),
            CreateProductPrice("7", "4", 270, new DateTime(2024, 9, 1), null, true),

            // Lay's Chips price history
            CreateProductPrice("8", "5", 180, new DateTime(2024, 1, 1), null, true),

            // Instant Noodles price history
            CreateProductPrice("9", "6", 120, new DateTime(2024, 1, 1), new DateTime(2024, 4, 30), false),
            CreateProductPrice("10", "6", 125, new DateTime(2024, 5, 1), null, true),

            // A4 Notebook price history
            CreateProductPrice("11", "7", 300, new DateTime(2024, 1, 1), null, true),

            // Blue Pen price history
            CreateProductPrice("12", "8", 50, new DateTime(2024, 1, 1), null, true),

            // Pencil Set price history
            CreateProductPrice("13", "9", 400, new DateTime(2024, 1, 1), null, true),

            // Cooking Oil 1L price history
            CreateProductPrice("14", "10", 450, new DateTime(2024, 1, 1), new DateTime(2024, 3, 31), false),
            CreateProductPrice("15", "10", 480, new DateTime(2024, 4, 1), null, true),

            // Rice 1kg price history
            CreateProductPrice("16", "11", 280, new DateTime(2024, 1, 1), null, true),

            // Sugar 1kg price history
            CreateProductPrice("17", "12", 200, new DateTime(2024, 1, 1), null, true),

            // Shampoo 400ml price history
            CreateProductPrice("18", "13", 350, new DateTime(2024, 1, 1), null, true),

            // Toothpaste price history
            CreateProductPrice("19", "14", 180, new DateTime(2024, 1, 1), null, true),

            // USB Cable price history
            CreateProductPrice("20", "15", 250, new DateTime(2024, 1, 1), null, true),

            // Phone Charger price history
            CreateProductPrice("21", "16", 800, new DateTime(2024, 1, 1), new DateTime(2024, 6, 30), false),
            CreateProductPrice("22", "16", 750, new DateTime(2024, 7, 1), null, true)
        );
    }

    private static ProductPrice CreateProductPrice(string id, string productId, int price, DateTime effectiveDate, DateTime? endDate, bool isActive)
    {
        var productPrice = ProductPrice.Create(productId, price, effectiveDate);
        productPrice.SetEndDate(endDate);
        if (isActive) productPrice.Activate(); else productPrice.Deactivate();

        typeof(ProductPrice).GetProperty(nameof(ProductPrice.Id))!.SetValue(productPrice, id);

        return productPrice;
    }
}
