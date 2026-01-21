using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class UnitOfMeasureSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(
                new UnitOfMeasure { Id = "1", Name = "Piece", Symbol = "pcs" },
                new UnitOfMeasure { Id = "2", Name = "Gram", Symbol = "g" },
                new UnitOfMeasure { Id = "3", Name = "Milliliter", Symbol = "ml" },
                new UnitOfMeasure { Id = "4", Name = "Box", Symbol = "box" },
                new UnitOfMeasure { Id = "5", Name = "Bottle", Symbol = "btl" }
            );
        }
    }
}
