using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class UnitOfMeasureSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(
                new UnitOfMeasure { PublicId = Guid.NewGuid().ToString(), Id = 1, Name = "Piece", Symbol = "pcs" },
                new UnitOfMeasure { PublicId = Guid.NewGuid().ToString(), Id = 2, Name = "Gram", Symbol = "g" },
                new UnitOfMeasure { PublicId = Guid.NewGuid().ToString(), Id = 3, Name = "Milliliter", Symbol = "ml" },
                new UnitOfMeasure { PublicId = Guid.NewGuid().ToString(), Id = 4, Name = "Box", Symbol = "box" },
                new UnitOfMeasure { PublicId = Guid.NewGuid().ToString(), Id = 5, Name = "Bottle", Symbol = "btl" }
            );
        }
    }
}
