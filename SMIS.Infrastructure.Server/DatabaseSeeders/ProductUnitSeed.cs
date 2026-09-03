using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProductUnitSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductUnit>().HasData(
            // Coca Cola - Bottle base unit
            CreateProductUnit(SeedIds.PU1,  SeedIds.ProdCocaCola,     SeedIds.UnitBottle,   1),   // 1 Bottle = 1 Bottle (base)
            CreateProductUnit(SeedIds.PU2,  SeedIds.ProdCocaCola,     SeedIds.UnitBox,      12),  // 1 Box = 12 Bottles
            CreateProductUnit(SeedIds.PU3,  SeedIds.ProdCocaCola,     SeedIds.UnitCarton,   24),  // 1 Carton = 24 Bottles

            // Pepsi - Bottle base unit
            CreateProductUnit(SeedIds.PU4,  SeedIds.ProdPepsi,        SeedIds.UnitBottle,   1),
            CreateProductUnit(SeedIds.PU5,  SeedIds.ProdPepsi,        SeedIds.UnitBox,      12),
            CreateProductUnit(SeedIds.PU6,  SeedIds.ProdPepsi,        SeedIds.UnitCarton,   24),

            // Mineral Water - Bottle base unit
            CreateProductUnit(SeedIds.PU7,  SeedIds.ProdMineralWater, SeedIds.UnitBottle,   1),
            CreateProductUnit(SeedIds.PU8,  SeedIds.ProdMineralWater, SeedIds.UnitBox,      6),   // 1L bottles
            CreateProductUnit(SeedIds.PU9,  SeedIds.ProdMineralWater, SeedIds.UnitCarton,   12),

            // Oreo Biscuits - Pack base unit
            CreateProductUnit(SeedIds.PU10, SeedIds.ProdOreo,         SeedIds.UnitPack,     1),
            CreateProductUnit(SeedIds.PU11, SeedIds.ProdOreo,         SeedIds.UnitBox,      12),
            CreateProductUnit(SeedIds.PU12, SeedIds.ProdOreo,         SeedIds.UnitCarton,   48),

            // Lay's Chips - Pack base unit
            CreateProductUnit(SeedIds.PU13, SeedIds.ProdLays,         SeedIds.UnitPack,     1),
            CreateProductUnit(SeedIds.PU14, SeedIds.ProdLays,         SeedIds.UnitBox,      20),
            CreateProductUnit(SeedIds.PU15, SeedIds.ProdLays,         SeedIds.UnitCarton,   60),

            // Instant Noodles - Pack base unit
            CreateProductUnit(SeedIds.PU16, SeedIds.ProdNoodles,      SeedIds.UnitPack,     1),
            CreateProductUnit(SeedIds.PU17, SeedIds.ProdNoodles,      SeedIds.UnitBox,      24),
            CreateProductUnit(SeedIds.PU18, SeedIds.ProdNoodles,      SeedIds.UnitCarton,   72),

            // A4 Notebook - Piece base unit
            CreateProductUnit(SeedIds.PU19, SeedIds.ProdNotebook,     SeedIds.UnitPiece,    1),
            CreateProductUnit(SeedIds.PU20, SeedIds.ProdNotebook,     SeedIds.UnitDozen,    12),
            CreateProductUnit(SeedIds.PU21, SeedIds.ProdNotebook,     SeedIds.UnitBox,      50),

            // Blue Pen - Piece base unit
            CreateProductUnit(SeedIds.PU22, SeedIds.ProdBluePen,      SeedIds.UnitPiece,    1),
            CreateProductUnit(SeedIds.PU23, SeedIds.ProdBluePen,      SeedIds.UnitDozen,    12),
            CreateProductUnit(SeedIds.PU24, SeedIds.ProdBluePen,      SeedIds.UnitBox,      144),

            // Pencil Set - Box base unit
            CreateProductUnit(SeedIds.PU25, SeedIds.ProdPencilSet,    SeedIds.UnitBox,      1),
            CreateProductUnit(SeedIds.PU26, SeedIds.ProdPencilSet,    SeedIds.UnitCarton,   20),

            // Cooking Oil - Bottle base unit
            CreateProductUnit(SeedIds.PU27, SeedIds.ProdCookingOil,   SeedIds.UnitBottle,   1),
            CreateProductUnit(SeedIds.PU28, SeedIds.ProdCookingOil,   SeedIds.UnitBox,      12),
            CreateProductUnit(SeedIds.PU29, SeedIds.ProdCookingOil,   SeedIds.UnitCarton,   24),

            // Rice - Kg base unit
            CreateProductUnit(SeedIds.PU30, SeedIds.ProdRice,         SeedIds.UnitKilogram, 1),
            CreateProductUnit(SeedIds.PU31, SeedIds.ProdRice,         SeedIds.UnitBox,      10),
            CreateProductUnit(SeedIds.PU32, SeedIds.ProdRice,         SeedIds.UnitCarton,   25),

            // Sugar - Kg base unit
            CreateProductUnit(SeedIds.PU33, SeedIds.ProdSugar,        SeedIds.UnitKilogram, 1),
            CreateProductUnit(SeedIds.PU34, SeedIds.ProdSugar,        SeedIds.UnitBox,      20),
            CreateProductUnit(SeedIds.PU35, SeedIds.ProdSugar,        SeedIds.UnitCarton,   50),

            // Shampoo - Bottle base unit
            CreateProductUnit(SeedIds.PU36, SeedIds.ProdShampoo,      SeedIds.UnitBottle,   1),
            CreateProductUnit(SeedIds.PU37, SeedIds.ProdShampoo,      SeedIds.UnitBox,      12),
            CreateProductUnit(SeedIds.PU38, SeedIds.ProdShampoo,      SeedIds.UnitCarton,   24),

            // Toothpaste - Piece base unit
            CreateProductUnit(SeedIds.PU39, SeedIds.ProdToothpaste,   SeedIds.UnitPiece,    1),
            CreateProductUnit(SeedIds.PU40, SeedIds.ProdToothpaste,   SeedIds.UnitBox,      24),
            CreateProductUnit(SeedIds.PU41, SeedIds.ProdToothpaste,   SeedIds.UnitCarton,   72),

            // USB Cable - Piece base unit
            CreateProductUnit(SeedIds.PU42, SeedIds.ProdUsbCable,     SeedIds.UnitPiece,    1),
            CreateProductUnit(SeedIds.PU43, SeedIds.ProdUsbCable,     SeedIds.UnitBox,      50),
            CreateProductUnit(SeedIds.PU44, SeedIds.ProdUsbCable,     SeedIds.UnitCarton,   200),

            // Phone Charger - Piece base unit
            CreateProductUnit(SeedIds.PU45, SeedIds.ProdCharger,      SeedIds.UnitPiece,    1),
            CreateProductUnit(SeedIds.PU46, SeedIds.ProdCharger,      SeedIds.UnitBox,      20),
            CreateProductUnit(SeedIds.PU47, SeedIds.ProdCharger,      SeedIds.UnitCarton,   100)
        );
    }

    private static ProductUnit CreateProductUnit(string id, string productId, string unitOfMeasureId, decimal conversionFactor)
    {
        var productUnit = ProductUnit.Create(productId, unitOfMeasureId, conversionFactor);

        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(ProductUnit).GetProperty(nameof(ProductUnit.Id))!.SetValue(productUnit, id);

        // Set name fields for seeding
        productUnit.SetProductName(GetProductName(productId));
        productUnit.SetUnitName(GetUnitName(unitOfMeasureId));

        typeof(ProductUnit).GetProperty(nameof(ProductUnit.LastModifiedUtc))!.SetValue(productUnit, DateTimeService.NowUtc);

        return productUnit;
    }

    private static string? GetProductName(string productId) => productId switch
    {
        SeedIds.ProdCocaCola     => "Coca Cola 500ml",
        SeedIds.ProdPepsi        => "Pepsi 500ml",
        SeedIds.ProdMineralWater => "Mineral Water 1L",
        SeedIds.ProdOreo         => "Oreo Biscuits",
        SeedIds.ProdLays         => "Lay's Chips",
        SeedIds.ProdNoodles      => "Instant Noodles",
        SeedIds.ProdNotebook     => "A4 Notebook",
        SeedIds.ProdBluePen      => "Blue Pen",
        SeedIds.ProdPencilSet    => "Pencil Set",
        SeedIds.ProdCookingOil   => "Cooking Oil 1L",
        SeedIds.ProdRice         => "Rice 1kg",
        SeedIds.ProdSugar        => "Sugar 1kg",
        SeedIds.ProdShampoo      => "Shampoo 400ml",
        SeedIds.ProdToothpaste   => "Toothpaste",
        SeedIds.ProdUsbCable     => "USB Cable",
        SeedIds.ProdCharger      => "Phone Charger",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        SeedIds.UnitPiece      => "Piece",
        SeedIds.UnitBottle     => "Bottle",
        SeedIds.UnitPack       => "Pack",
        SeedIds.UnitBox        => "Box",
        SeedIds.UnitCarton     => "Carton",
        SeedIds.UnitLiter      => "Liter",
        SeedIds.UnitKilogram   => "Kilogram",
        SeedIds.UnitGram       => "Gram",
        SeedIds.UnitMilliliter => "Milliliter",
        SeedIds.UnitDozen      => "Dozen",
        _ => null
    };
}
