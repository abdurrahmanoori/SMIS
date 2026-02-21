using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class UnitOfMeasureSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var units = new[]
        {
            CreateUnit("1", "Piece", "pcs", "1", "Individual items"),
            CreateUnit("2", "Bottle", "btl", "1", "Liquid containers"),
            CreateUnit("3", "Pack", "pk", "1", "Small packages"),
            CreateUnit("4", "Box", "box", "1", "Medium containers"),
            CreateUnit("5", "Carton", "ctn", "1", "Large containers"),
            CreateUnit("6", "Liter", "L", "1", "Volume measurement"),
            CreateUnit("7", "Kilogram", "kg", "1", "Weight measurement"),
            CreateUnit("8", "Gram", "g", "1", "Small weight measurement"),
            CreateUnit("9", "Milliliter", "ml", "1", "Small volume measurement"),
            CreateUnit("10", "Dozen", "dz", "1", "12 pieces")
        };

        modelBuilder.Entity<UnitOfMeasure>().HasData(units);
    }

    private static UnitOfMeasure CreateUnit(string id, string name, string? symbol, string shopId, string description)
    {
        var unit = UnitOfMeasure.Create(name, symbol, shopId, description);
        
        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.Id))!.SetValue(unit, id);
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.LastModifiedUtc))!.SetValue(unit, DateTimeService.NowOffSet);
        
        return unit;
    }
}
