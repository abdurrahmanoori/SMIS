using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ProductUnitSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductUnit>().HasData(
            // Coca Cola - Bottle base unit (ID: 1)
            CreateProductUnit("1", "1", "2", 1),  // 1 Bottle = 1 Bottle (base)
            CreateProductUnit("2", "1", "4", 12), // 1 Box = 12 Bottles
            CreateProductUnit("3", "1", "5", 24), // 1 Carton = 24 Bottles
            
            // Pepsi - Bottle base unit (ID: 2)
            CreateProductUnit("4", "2", "2", 1),  // 1 Bottle = 1 Bottle (base)
            CreateProductUnit("5", "2", "4", 12), // 1 Box = 12 Bottles
            CreateProductUnit("6", "2", "5", 24), // 1 Carton = 24 Bottles
            
            // Mineral Water - Bottle base unit (ID: 3)
            CreateProductUnit("7", "3", "2", 1),  // 1 Bottle = 1 Bottle (base)
            CreateProductUnit("8", "3", "4", 6),  // 1 Box = 6 Bottles (1L bottles)
            CreateProductUnit("9", "3", "5", 12), // 1 Carton = 12 Bottles
            
            // Oreo Biscuits - Pack base unit (ID: 4)
            CreateProductUnit("10", "4", "3", 1),  // 1 Pack = 1 Pack (base)
            CreateProductUnit("11", "4", "4", 12), // 1 Box = 12 Packs
            CreateProductUnit("12", "4", "5", 48), // 1 Carton = 48 Packs
            
            // Lay's Chips - Pack base unit (ID: 5)
            CreateProductUnit("13", "5", "3", 1),  // 1 Pack = 1 Pack (base)
            CreateProductUnit("14", "5", "4", 20), // 1 Box = 20 Packs
            CreateProductUnit("15", "5", "5", 60), // 1 Carton = 60 Packs
            
            // Instant Noodles - Pack base unit (ID: 6)
            CreateProductUnit("16", "6", "3", 1),  // 1 Pack = 1 Pack (base)
            CreateProductUnit("17", "6", "4", 24), // 1 Box = 24 Packs
            CreateProductUnit("18", "6", "5", 72), // 1 Carton = 72 Packs
            
            // A4 Notebook - Piece base unit (ID: 7)
            CreateProductUnit("19", "7", "1", 1),  // 1 Piece = 1 Piece (base)
            CreateProductUnit("20", "7", "10", 12), // 1 Dozen = 12 Pieces
            CreateProductUnit("21", "7", "4", 50), // 1 Box = 50 Pieces
            
            // Blue Pen - Piece base unit (ID: 8)
            CreateProductUnit("22", "8", "1", 1),  // 1 Piece = 1 Piece (base)
            CreateProductUnit("23", "8", "10", 12), // 1 Dozen = 12 Pieces
            CreateProductUnit("24", "8", "4", 144), // 1 Box = 144 Pieces (12 dozen)
            
            // Pencil Set - Box base unit (ID: 9) - already in boxes
            CreateProductUnit("25", "9", "4", 1),  // 1 Box = 1 Box (base)
            CreateProductUnit("26", "9", "5", 20), // 1 Carton = 20 Boxes
            
            // Cooking Oil - Bottle base unit (ID: 10)
            CreateProductUnit("27", "10", "2", 1),  // 1 Bottle = 1 Bottle (base)
            CreateProductUnit("28", "10", "4", 12), // 1 Box = 12 Bottles
            CreateProductUnit("29", "10", "5", 24), // 1 Carton = 24 Bottles
            
            // Rice - Kg base unit (ID: 11)
            CreateProductUnit("30", "11", "7", 1),  // 1 Kg = 1 Kg (base)
            CreateProductUnit("31", "11", "4", 10), // 1 Box = 10 Kg bags
            CreateProductUnit("32", "11", "5", 25), // 1 Carton = 25 Kg bags
            
            // Sugar - Kg base unit (ID: 12)
            CreateProductUnit("33", "12", "7", 1),  // 1 Kg = 1 Kg (base)
            CreateProductUnit("34", "12", "4", 20), // 1 Box = 20 Kg bags
            CreateProductUnit("35", "12", "5", 50), // 1 Carton = 50 Kg bags
            
            // Shampoo - Bottle base unit (ID: 13)
            CreateProductUnit("36", "13", "2", 1),  // 1 Bottle = 1 Bottle (base)
            CreateProductUnit("37", "13", "4", 12), // 1 Box = 12 Bottles
            CreateProductUnit("38", "13", "5", 24), // 1 Carton = 24 Bottles
            
            // Toothpaste - Piece base unit (ID: 14)
            CreateProductUnit("39", "14", "1", 1),  // 1 Piece = 1 Piece (base)
            CreateProductUnit("40", "14", "4", 24), // 1 Box = 24 Pieces
            CreateProductUnit("41", "14", "5", 72), // 1 Carton = 72 Pieces
            
            // USB Cable - Piece base unit (ID: 15)
            CreateProductUnit("42", "15", "1", 1),  // 1 Piece = 1 Piece (base)
            CreateProductUnit("43", "15", "4", 50), // 1 Box = 50 Pieces
            CreateProductUnit("44", "15", "5", 200), // 1 Carton = 200 Pieces
            
            // Phone Charger - Piece base unit (ID: 16)
            CreateProductUnit("45", "16", "1", 1),  // 1 Piece = 1 Piece (base)
            CreateProductUnit("46", "16", "4", 20), // 1 Box = 20 Pieces
            CreateProductUnit("47", "16", "5", 100)  // 1 Carton = 100 Pieces
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
        
        return productUnit;
    }

    private static string? GetProductName(string productId) => productId switch
    {
        "1" => "Coca Cola 500ml",
        "2" => "Pepsi 500ml",
        "3" => "Mineral Water 1L",
        "4" => "Oreo Biscuits",
        "5" => "Lay's Chips",
        "6" => "Instant Noodles",
        "7" => "A4 Notebook",
        "8" => "Blue Pen",
        "9" => "Pencil Set",
        "10" => "Cooking Oil 1L",
        "11" => "Rice 1kg",
        "12" => "Sugar 1kg",
        "13" => "Shampoo 400ml",
        "14" => "Toothpaste",
        "15" => "USB Cable",
        "16" => "Phone Charger",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        "1" => "Piece",
        "2" => "Bottle",
        "3" => "Pack",
        "4" => "Box",
        "5" => "Carton",
        "6" => "Liter",
        "7" => "Kilogram",
        "8" => "Gram",
        "9" => "Milliliter",
        "10" => "Dozen",
        _ => null
    };
}