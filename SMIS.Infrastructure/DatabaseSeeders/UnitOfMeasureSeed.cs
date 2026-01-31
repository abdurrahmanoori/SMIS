using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class UnitOfMeasureSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UnitOfMeasure>().HasData(
            new UnitOfMeasure { Id = "1", Name = "Piece", Symbol = "pcs", Description = "Individual items" },
            new UnitOfMeasure { Id = "2", Name = "Bottle", Symbol = "btl", Description = "Liquid containers" },
            new UnitOfMeasure { Id = "3", Name = "Pack", Symbol = "pk", Description = "Small packages" },
            new UnitOfMeasure { Id = "4", Name = "Box", Symbol = "box", Description = "Medium containers" },
            new UnitOfMeasure { Id = "5", Name = "Carton", Symbol = "ctn", Description = "Large containers" },
            new UnitOfMeasure { Id = "6", Name = "Liter", Symbol = "L", Description = "Volume measurement" },
            new UnitOfMeasure { Id = "7", Name = "Kilogram", Symbol = "kg", Description = "Weight measurement" },
            new UnitOfMeasure { Id = "8", Name = "Gram", Symbol = "g", Description = "Small weight measurement" },
            new UnitOfMeasure { Id = "9", Name = "Milliliter", Symbol = "ml", Description = "Small volume measurement" },
            new UnitOfMeasure { Id = "10", Name = "Dozen", Symbol = "dz", Description = "12 pieces" }
        );
    }
}
