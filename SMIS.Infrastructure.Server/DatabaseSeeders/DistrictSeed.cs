using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class DistrictSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<District>().HasData(
            new District { Id = SeedIds.DistrictKabulCenter, Name = "Kabul Center", TranslationKeyId = SeedIds.TKey1 },
            new District { Id = SeedIds.DistrictKabulNorth,  Name = "Kabul North",  TranslationKeyId = SeedIds.TKey2 },
            new District { Id = SeedIds.DistrictHeratCenter, Name = "Herat Center", TranslationKeyId = SeedIds.TKey3 }
        );
    }
}
