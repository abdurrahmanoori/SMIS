using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UnitOfMeasureSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var units = new[]
        {
            CreateUnit(SeedIds.UnitPiece,      "Piece",      "pcs", SeedIds.Shop1, "Individual items"),
            CreateUnit(SeedIds.UnitBottle,     "Bottle",     "btl", SeedIds.Shop1, "Liquid containers"),
            CreateUnit(SeedIds.UnitPack,       "Pack",       "pk",  SeedIds.Shop1, "Small packages"),
            CreateUnit(SeedIds.UnitBox,        "Box",        "box", SeedIds.Shop1, "Medium containers"),
            CreateUnit(SeedIds.UnitCarton,     "Carton",     "ctn", SeedIds.Shop1, "Large containers"),
            CreateUnit(SeedIds.UnitLiter,      "Liter",      "L",   SeedIds.Shop1, "Volume measurement"),
            CreateUnit(SeedIds.UnitKilogram,   "Kilogram",   "kg",  SeedIds.Shop1, "Weight measurement"),
            CreateUnit(SeedIds.UnitGram,       "Gram",       "g",   SeedIds.Shop1, "Small weight measurement"),
            CreateUnit(SeedIds.UnitMilliliter, "Milliliter", "ml",  SeedIds.Shop1, "Small volume measurement"),
            CreateUnit(SeedIds.UnitDozen,      "Dozen",      "dz",  SeedIds.Shop1, "12 pieces")
        };

        modelBuilder.Entity<UnitOfMeasure>().HasData(units);
    }

    private static UnitOfMeasure CreateUnit(string id, string name, string? symbol, string shopId, string description)
    {
        var unit = UnitOfMeasure.Create(name, symbol, shopId, description);

        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.Id))!.SetValue(unit, id);
        typeof(UnitOfMeasure).GetProperty(nameof(UnitOfMeasure.LastModifiedUtc))!.SetValue(unit, DateTimeService.NowUtc);

        return unit;
    }
}
