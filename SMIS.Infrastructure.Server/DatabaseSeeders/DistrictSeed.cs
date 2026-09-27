using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class DistrictSeed
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<District>().HasData(SeedIds.Stamp(
            new District { Id = SeedIds.DistrictKabulCenter, Name = "Kabul Center" },
            new District { Id = SeedIds.DistrictKabulNorth, Name = "Kabul North" },
            new District { Id = SeedIds.DistrictHeratCenter, Name = "Herat Center" }
        ));
    }
}