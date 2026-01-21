using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class DistrictSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(
                new District { PublicId = "1", Name = "Kabul Center", TranslationKeyId = "1" },
                new District { PublicId = "2", Name = "Kabul North", TranslationKeyId = "2" },
                new District { PublicId = "3", Name = "Herat Center", TranslationKeyId = "3" }
            );
        }
    }
}