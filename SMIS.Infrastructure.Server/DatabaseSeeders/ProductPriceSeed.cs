using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>().HasData(
            // Coca Cola 500ml - PU1(Bottle), PU2(Box), PU3(Carton)
            CreateProductPrice(SeedIds.PP1,  SeedIds.ProdCocaCola,     SeedIds.PU1,  140,   160,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP2,  SeedIds.ProdCocaCola,     SeedIds.PU2,  1680,  1920,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP3,  SeedIds.ProdCocaCola,     SeedIds.PU3,  3360,  3840,  new DateTime(2024, 1, 1), null, true),

            // Pepsi 500ml - PU4(Bottle), PU5(Box), PU6(Carton)
            CreateProductPrice(SeedIds.PP4,  SeedIds.ProdPepsi,        SeedIds.PU4,  130,   150,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP5,  SeedIds.ProdPepsi,        SeedIds.PU5,  1560,  1800,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP6,  SeedIds.ProdPepsi,        SeedIds.PU6,  3120,  3600,  new DateTime(2024, 1, 1), null, true),

            // Mineral Water 1L - PU7(Bottle), PU8(Box), PU9(Carton)
            CreateProductPrice(SeedIds.PP7,  SeedIds.ProdMineralWater, SeedIds.PU7,  70,    90,    new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP8,  SeedIds.ProdMineralWater, SeedIds.PU8,  420,   540,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP9,  SeedIds.ProdMineralWater, SeedIds.PU9,  840,   1080,  new DateTime(2024, 1, 1), null, true),

            // Oreo Biscuits - PU10(Pack), PU11(Box), PU12(Carton)
            CreateProductPrice(SeedIds.PP10, SeedIds.ProdOreo,         SeedIds.PU10, 230,   270,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP11, SeedIds.ProdOreo,         SeedIds.PU11, 2760,  3240,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP12, SeedIds.ProdOreo,         SeedIds.PU12, 11040, 12960, new DateTime(2024, 1, 1), null, true),

            // Lay's Chips - PU13(Pack), PU14(Box), PU15(Carton)
            CreateProductPrice(SeedIds.PP13, SeedIds.ProdLays,         SeedIds.PU13, 160,   190,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP14, SeedIds.ProdLays,         SeedIds.PU14, 3200,  3800,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP15, SeedIds.ProdLays,         SeedIds.PU15, 9600,  11400, new DateTime(2024, 1, 1), null, true),

            // Instant Noodles - PU16(Pack), PU17(Box), PU18(Carton)
            CreateProductPrice(SeedIds.PP16, SeedIds.ProdNoodles,      SeedIds.PU16, 110,   130,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP17, SeedIds.ProdNoodles,      SeedIds.PU17, 2640,  3120,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP18, SeedIds.ProdNoodles,      SeedIds.PU18, 7920,  9360,  new DateTime(2024, 1, 1), null, true),

            // A4 Notebook - PU19(Piece), PU20(Dozen), PU21(Box)
            CreateProductPrice(SeedIds.PP19, SeedIds.ProdNotebook,     SeedIds.PU19, 280,   320,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP20, SeedIds.ProdNotebook,     SeedIds.PU20, 3360,  3840,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP21, SeedIds.ProdNotebook,     SeedIds.PU21, 14000, 16000, new DateTime(2024, 1, 1), null, true),

            // Blue Pen - PU22(Piece), PU23(Dozen), PU24(Box)
            CreateProductPrice(SeedIds.PP22, SeedIds.ProdBluePen,      SeedIds.PU22, 45,    55,    new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP23, SeedIds.ProdBluePen,      SeedIds.PU23, 540,   660,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP24, SeedIds.ProdBluePen,      SeedIds.PU24, 6480,  7920,  new DateTime(2024, 1, 1), null, true),

            // Pencil Set - PU25(Box), PU26(Carton)
            CreateProductPrice(SeedIds.PP25, SeedIds.ProdPencilSet,    SeedIds.PU25, 380,   420,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP26, SeedIds.ProdPencilSet,    SeedIds.PU26, 7600,  8400,  new DateTime(2024, 1, 1), null, true),

            // Cooking Oil 1L - PU27(Bottle), PU28(Box), PU29(Carton)
            CreateProductPrice(SeedIds.PP27, SeedIds.ProdCookingOil,   SeedIds.PU27, 430,   470,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP28, SeedIds.ProdCookingOil,   SeedIds.PU28, 5160,  5640,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP29, SeedIds.ProdCookingOil,   SeedIds.PU29, 10320, 11280, new DateTime(2024, 1, 1), null, true),

            // Rice 1kg - PU30(Kg), PU31(Box), PU32(Carton)
            CreateProductPrice(SeedIds.PP30, SeedIds.ProdRice,         SeedIds.PU30, 260,   300,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP31, SeedIds.ProdRice,         SeedIds.PU31, 2600,  3000,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP32, SeedIds.ProdRice,         SeedIds.PU32, 6500,  7500,  new DateTime(2024, 1, 1), null, true),

            // Sugar 1kg - PU33(Kg), PU34(Box), PU35(Carton)
            CreateProductPrice(SeedIds.PP33, SeedIds.ProdSugar,        SeedIds.PU33, 180,   220,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP34, SeedIds.ProdSugar,        SeedIds.PU34, 3600,  4400,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP35, SeedIds.ProdSugar,        SeedIds.PU35, 9000,  11000, new DateTime(2024, 1, 1), null, true),

            // Shampoo 400ml - PU36(Bottle), PU37(Box), PU38(Carton)
            CreateProductPrice(SeedIds.PP36, SeedIds.ProdShampoo,      SeedIds.PU36, 330,   370,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP37, SeedIds.ProdShampoo,      SeedIds.PU37, 3960,  4440,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP38, SeedIds.ProdShampoo,      SeedIds.PU38, 7920,  8880,  new DateTime(2024, 1, 1), null, true),

            // Toothpaste - PU39(Piece), PU40(Box), PU41(Carton)
            CreateProductPrice(SeedIds.PP39, SeedIds.ProdToothpaste,   SeedIds.PU39, 160,   200,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP40, SeedIds.ProdToothpaste,   SeedIds.PU40, 3840,  4800,  new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP41, SeedIds.ProdToothpaste,   SeedIds.PU41, 11520, 14400, new DateTime(2024, 1, 1), null, true),

            // USB Cable - PU42(Piece), PU43(Box), PU44(Carton)
            CreateProductPrice(SeedIds.PP42, SeedIds.ProdUsbCable,     SeedIds.PU42, 230,   270,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP43, SeedIds.ProdUsbCable,     SeedIds.PU43, 11500, 13500, new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP44, SeedIds.ProdUsbCable,     SeedIds.PU44, 46000, 54000, new DateTime(2024, 1, 1), null, true),

            // Phone Charger - PU45(Piece), PU46(Box), PU47(Carton)
            CreateProductPrice(SeedIds.PP45, SeedIds.ProdCharger,      SeedIds.PU45, 750,   850,   new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP46, SeedIds.ProdCharger,      SeedIds.PU46, 15000, 17000, new DateTime(2024, 1, 1), null, true),
            CreateProductPrice(SeedIds.PP47, SeedIds.ProdCharger,      SeedIds.PU47, 75000, 85000, new DateTime(2024, 1, 1), null, true)
        );
    }

    private static ProductPrice CreateProductPrice(string id, string productId, string unitId, long buyPrice, long sellPrice, DateTime effectiveDate, DateTime? endDate, bool isActive)
    {
        var productPrice = ProductPrice.Create(productId, unitId, buyPrice, sellPrice, effectiveDate);
        productPrice.SetEndDate(endDate);
        if (isActive) productPrice.Activate(); else productPrice.Deactivate();

        typeof(ProductPrice).GetProperty(nameof(ProductPrice.Id))!.SetValue(productPrice, id);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.CreatedDate))!.SetValue(productPrice, DateTimeService.NowUtc);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.UpdatedDate))!.SetValue(productPrice, DateTimeService.NowUtc);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.LastModifiedUtc))!.SetValue(productPrice, DateTimeService.NowUtc);

        return productPrice;
    }
}
