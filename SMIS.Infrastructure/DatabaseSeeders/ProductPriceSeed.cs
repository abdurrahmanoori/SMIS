using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>().HasData(
            // Coca Cola 500ml (Product 1) - Base: Bottle, ProductUnits: 1(Bottle), 2(Box), 3(Carton)
            CreateProductPrice("1", "1", "1", 140, 160, new DateTime(2024, 1, 1), null, true), // Bottle (base)
            CreateProductPrice("2", "1", "2", 1680, 1920, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("3", "1", "3", 3360, 3840, new DateTime(2024, 1, 1), null, true), // Carton

            // Pepsi 500ml (Product 2) - ProductUnits: 4(Bottle), 5(Box), 6(Carton)
            CreateProductPrice("4", "2", "4", 130, 150, new DateTime(2024, 1, 1), null, true), // Bottle (base)
            CreateProductPrice("5", "2", "5", 1560, 1800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("6", "2", "6", 3120, 3600, new DateTime(2024, 1, 1), null, true), // Carton

            // Mineral Water 1L (Product 3) - ProductUnits: 7(Bottle), 8(Box), 9(Carton)
            CreateProductPrice("7", "3", "7", 70, 90, new DateTime(2024, 1, 1), null, true), // Bottle (base)
            CreateProductPrice("8", "3", "8", 420, 540, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("9", "3", "9", 840, 1080, new DateTime(2024, 1, 1), null, true), // Carton

            // Oreo Biscuits (Product 4) - ProductUnits: 10(Pack), 11(Box), 12(Carton)
            CreateProductPrice("10", "4", "10", 230, 270, new DateTime(2024, 1, 1), null, true), // Pack (base)
            CreateProductPrice("11", "4", "11", 2760, 3240, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("12", "4", "12", 11040, 12960, new DateTime(2024, 1, 1), null, true), // Carton

            // Lay's Chips (Product 5) - ProductUnits: 13(Pack), 14(Box), 15(Carton)
            CreateProductPrice("13", "5", "13", 160, 190, new DateTime(2024, 1, 1), null, true), // Pack (base)
            CreateProductPrice("14", "5", "14", 3200, 3800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("15", "5", "15", 9600, 11400, new DateTime(2024, 1, 1), null, true), // Carton

            // Instant Noodles (Product 6) - ProductUnits: 16(Pack), 17(Box), 18(Carton)
            CreateProductPrice("16", "6", "16", 110, 130, new DateTime(2024, 1, 1), null, true), // Pack (base)
            CreateProductPrice("17", "6", "17", 2640, 3120, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("18", "6", "18", 7920, 9360, new DateTime(2024, 1, 1), null, true), // Carton

            // A4 Notebook (Product 7) - ProductUnits: 19(Piece), 20(Dozen), 21(Box)
            CreateProductPrice("19", "7", "19", 280, 320, new DateTime(2024, 1, 1), null, true), // Piece (base)
            CreateProductPrice("20", "7", "20", 3360, 3840, new DateTime(2024, 1, 1), null, true), // Dozen
            CreateProductPrice("21", "7", "21", 14000, 16000, new DateTime(2024, 1, 1), null, true), // Box

            // Blue Pen (Product 8) - ProductUnits: 22(Piece), 23(Dozen), 24(Box)
            CreateProductPrice("22", "8", "22", 45, 55, new DateTime(2024, 1, 1), null, true), // Piece (base)
            CreateProductPrice("23", "8", "23", 540, 660, new DateTime(2024, 1, 1), null, true), // Dozen
            CreateProductPrice("24", "8", "24", 6480, 7920, new DateTime(2024, 1, 1), null, true), // Box

            // Pencil Set (Product 9) - ProductUnits: 25(Box), 26(Carton)
            CreateProductPrice("25", "9", "25", 380, 420, new DateTime(2024, 1, 1), null, true), // Box (base)
            CreateProductPrice("26", "9", "26", 7600, 8400, new DateTime(2024, 1, 1), null, true), // Carton

            // Cooking Oil 1L (Product 10) - ProductUnits: 27(Bottle), 28(Box), 29(Carton)
            CreateProductPrice("27", "10", "27", 430, 470, new DateTime(2024, 1, 1), null, true), // Bottle (base)
            CreateProductPrice("28", "10", "28", 5160, 5640, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("29", "10", "29", 10320, 11280, new DateTime(2024, 1, 1), null, true), // Carton

            // Rice 1kg (Product 11) - ProductUnits: 30(Kg), 31(Box), 32(Carton)
            CreateProductPrice("30", "11", "30", 260, 300, new DateTime(2024, 1, 1), null, true), // Kg (base)
            CreateProductPrice("31", "11", "31", 2600, 3000, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("32", "11", "32", 6500, 7500, new DateTime(2024, 1, 1), null, true), // Carton

            // Sugar 1kg (Product 12) - ProductUnits: 33(Kg), 34(Box), 35(Carton)
            CreateProductPrice("33", "12", "33", 180, 220, new DateTime(2024, 1, 1), null, true), // Kg (base)
            CreateProductPrice("34", "12", "34", 3600, 4400, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("35", "12", "35", 9000, 11000, new DateTime(2024, 1, 1), null, true), // Carton

            // Shampoo 400ml (Product 13) - ProductUnits: 36(Bottle), 37(Box), 38(Carton)
            CreateProductPrice("36", "13", "36", 330, 370, new DateTime(2024, 1, 1), null, true), // Bottle (base)
            CreateProductPrice("37", "13", "37", 3960, 4440, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("38", "13", "38", 7920, 8880, new DateTime(2024, 1, 1), null, true), // Carton

            // Toothpaste (Product 14) - ProductUnits: 39(Piece), 40(Box), 41(Carton)
            CreateProductPrice("39", "14", "39", 160, 200, new DateTime(2024, 1, 1), null, true), // Piece (base)
            CreateProductPrice("40", "14", "40", 3840, 4800, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("41", "14", "41", 11520, 14400, new DateTime(2024, 1, 1), null, true), // Carton

            // USB Cable (Product 15) - ProductUnits: 42(Piece), 43(Box), 44(Carton)
            CreateProductPrice("42", "15", "42", 230, 270, new DateTime(2024, 1, 1), null, true), // Piece (base)
            CreateProductPrice("43", "15", "43", 11500, 13500, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("44", "15", "44", 46000, 54000, new DateTime(2024, 1, 1), null, true), // Carton

            // Phone Charger (Product 16) - ProductUnits: 45(Piece), 46(Box), 47(Carton)
            CreateProductPrice("45", "16", "45", 750, 850, new DateTime(2024, 1, 1), null, true), // Piece (base)
            CreateProductPrice("46", "16", "46", 15000, 17000, new DateTime(2024, 1, 1), null, true), // Box
            CreateProductPrice("47", "16", "47", 75000, 85000, new DateTime(2024, 1, 1), null, true) // Carton
        );
    }

    private static ProductPrice CreateProductPrice(string id, string productId, string unitId, long buyPrice, long sellPrice, DateTime effectiveDate, DateTime? endDate, bool isActive)
    {
        var productPrice = ProductPrice.Create(productId, unitId, buyPrice, sellPrice, effectiveDate);
        productPrice.SetEndDate(endDate);
        if (isActive) productPrice.Activate(); else productPrice.Deactivate();

        typeof(ProductPrice).GetProperty(nameof(ProductPrice.Id))!.SetValue(productPrice, id);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.CreatedDate))!.SetValue(productPrice, DateTimeService.Now);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.UpdatedDate))!.SetValue(productPrice, DateTimeService.Now);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.LastModifiedUtc))!.SetValue(productPrice, DateTimeService.NowOffSet);

        return productPrice;
    }
}
