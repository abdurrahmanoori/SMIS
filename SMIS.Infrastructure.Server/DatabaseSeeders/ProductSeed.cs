using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProductSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            // Beverages (CatBeverages) - Bottle base unit
            CreateProduct(SeedIds.ProdCocaCola,     "Coca Cola 500ml",  SeedIds.Shop1, SeedIds.UnitBottle,   "COKE-500ML-001",  "Classic cola drink",          "1234567890001", null, SeedIds.CatBeverages,    true),
            CreateProduct(SeedIds.ProdPepsi,        "Pepsi 500ml",      SeedIds.Shop1, SeedIds.UnitBottle,   "PEPSI-500ML-002", "Cola soft drink",              "1234567890002", null, SeedIds.CatBeverages,    true),
            CreateProduct(SeedIds.ProdMineralWater, "Mineral Water 1L", SeedIds.Shop2, SeedIds.UnitBottle,   "WATER-1L-003",    "Pure drinking water",          "1234567890003", null, SeedIds.CatBeverages,    true),

            // Food Items (CatFood) - Pack base unit
            CreateProduct(SeedIds.ProdOreo,         "Oreo Biscuits",    SeedIds.Shop1, SeedIds.UnitPack,     "OREO-PACK-004",   "Chocolate sandwich cookies",   "1234567890004", null, SeedIds.CatFood,         true),
            CreateProduct(SeedIds.ProdLays,         "Lay's Chips",      SeedIds.Shop2, SeedIds.UnitPack,     "LAYS-PACK-005",   "Potato chips",                 "1234567890005", null, SeedIds.CatFood,         true),
            CreateProduct(SeedIds.ProdNoodles,      "Instant Noodles",  SeedIds.Shop3, SeedIds.UnitPack,     "NOODLE-PACK-006", "Quick meal noodles",           "1234567890006", null, SeedIds.CatFood,         true),

            // Stationery (CatStationery) - Piece base unit
            CreateProduct(SeedIds.ProdNotebook,     "A4 Notebook",      SeedIds.Shop1, SeedIds.UnitPiece,    "NOTE-A4-007",     "200 pages ruled notebook",     "1234567890007", null, SeedIds.CatStationery,   true),
            CreateProduct(SeedIds.ProdBluePen,      "Blue Pen",         SeedIds.Shop2, SeedIds.UnitPiece,    "PEN-BLUE-008",    "Ballpoint pen",                "1234567890008", null, SeedIds.CatStationery,   true),
            CreateProduct(SeedIds.ProdPencilSet,    "Pencil Set",       SeedIds.Shop3, SeedIds.UnitBox,      "PENCIL-BOX-009",  "12 pencils per box",           "1234567890009", null, SeedIds.CatStationery,   true),

            // Grocery (CatGrocery) - Bottle/Kg base units
            CreateProduct(SeedIds.ProdCookingOil,   "Cooking Oil 1L",   SeedIds.Shop1, SeedIds.UnitBottle,   "OIL-1L-010",      "Sunflower cooking oil",        "1234567890010", null, SeedIds.CatGrocery,      true),
            CreateProduct(SeedIds.ProdRice,         "Rice 1kg",         SeedIds.Shop2, SeedIds.UnitKilogram, "RICE-1KG-011",    "Basmati rice",                 "1234567890011", null, SeedIds.CatGrocery,      true),
            CreateProduct(SeedIds.ProdSugar,        "Sugar 1kg",        SeedIds.Shop3, SeedIds.UnitKilogram, "SUGAR-1KG-012",   "White granulated sugar",       "1234567890012", null, SeedIds.CatGrocery,      true),

            // Personal Care (CatPersonalCare) - Bottle/Piece base units
            CreateProduct(SeedIds.ProdShampoo,      "Shampoo 400ml",    SeedIds.Shop1, SeedIds.UnitBottle,   "SHAMP-400ML-013", "Hair care shampoo",            "1234567890013", null, SeedIds.CatPersonalCare, true),
            CreateProduct(SeedIds.ProdToothpaste,   "Toothpaste",       SeedIds.Shop2, SeedIds.UnitPiece,    "TOOTH-PASTE-014", "Dental care paste",            "1234567890014", null, SeedIds.CatPersonalCare, true),

            // Electronics (CatElectronics) - Piece base unit
            CreateProduct(SeedIds.ProdUsbCable,     "USB Cable",        SeedIds.Shop1, SeedIds.UnitPiece,    "USB-CABLE-015",   "Type-C charging cable",        "1234567890015", null, SeedIds.CatElectronics,  true),
            CreateProduct(SeedIds.ProdCharger,      "Phone Charger",    SeedIds.Shop3, SeedIds.UnitPiece,    "CHARGER-016",     "Fast charging adapter",        "1234567890016", null, SeedIds.CatElectronics,  true)
        );
    }

    private static Product CreateProduct(string id, string name, string shopId, string baseUnitId, string sku, string? description, string? barcode, string? imageUrl, string? categoryId, bool isActive)
    {
        var product = Product.Create(name, shopId, baseUnitId, sku, isActive, description, barcode, imageUrl, categoryId);

        // Set ID and Name fields for seeding
        typeof(Product).GetProperty(nameof(Product.Id))!.SetValue(product, id);
        typeof(Product).GetProperty(nameof(Product.ShopName))!.SetValue(product, GetShopName(shopId));
        typeof(Product).GetProperty(nameof(Product.BaseUnitName))!.SetValue(product, GetUnitName(baseUnitId));
        typeof(Product).GetProperty(nameof(Product.CategoryName))!.SetValue(product, GetCategoryName(categoryId));
        typeof(Product).GetProperty(nameof(Product.CreatedDate))!.SetValue(product, DateTimeService.NowUtc);
        typeof(Product).GetProperty(nameof(Product.UpdatedDate))!.SetValue(product, DateTimeService.NowUtc);
        typeof(Product).GetProperty(nameof(Product.LastModifiedUtc))!.SetValue(product, DateTimeService.NowUtc);

        return product;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
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

    private static string? GetCategoryName(string? categoryId) => categoryId switch
    {
        SeedIds.CatBeverages    => "Beverages",
        SeedIds.CatFood         => "Food Items",
        SeedIds.CatStationery   => "Stationery",
        SeedIds.CatGrocery      => "Grocery",
        SeedIds.CatPersonalCare => "Personal Care",
        SeedIds.CatElectronics  => "Electronics",
        _ => null
    };
}
