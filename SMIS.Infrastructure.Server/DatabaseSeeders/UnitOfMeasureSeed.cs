using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UnitOfMeasureSeed
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        var units = new[]
        {
            CreateUnit(SeedIds.UnitPiece, "Piece", "pcs", "Individual items"),
            CreateUnit(SeedIds.UnitBottle, "Bottle", "btl", "Liquid containers"),
            CreateUnit(SeedIds.UnitPack, "Pack", "pk", "Small packages"),
            CreateUnit(SeedIds.UnitBox, "Box", "box", "Medium containers"),
            CreateUnit(SeedIds.UnitCarton, "Carton", "ctn", "Large containers"),
            CreateUnit(SeedIds.UnitLiter, "Liter", "L", "Volume measurement"),
            CreateUnit(SeedIds.UnitKilogram, "Kilogram", "kg", "Weight measurement"),
            CreateUnit(SeedIds.UnitGram, "Gram", "g", "Small weight measurement"),
            CreateUnit(SeedIds.UnitMilliliter, "Milliliter", "ml", "Small volume measurement"),
            CreateUnit(SeedIds.UnitDozen, "Dozen", "dz", "12 pieces")
        };

        modelBuilder.Entity<UnitOfMeasure>().HasData(units);
    }

    private static UnitOfMeasure CreateUnit(
        string id,
        string name,
        string? symbol,
        string description
    )
    {
        var unit = UnitOfMeasure.Create(name, symbol, description);

        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.Id))!.SetValue(unit, id);
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.LastModifiedUtc))!
            .SetValue(unit, SeedIds.SeedTimestampUtc);

        return unit;
    }
}