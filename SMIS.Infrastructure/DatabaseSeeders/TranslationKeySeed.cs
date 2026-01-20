using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class TranslationKeySeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TranslationKey>().HasData(
                new TranslationKey { Id = 1, PublicId = "district_kabul_center", Name = "Kabul Center District", MessageCode = 1001, IsActive = true },
                new TranslationKey { Id = 2, PublicId = "district_kabul_north", Name = "Kabul North District", MessageCode = 1002, IsActive = true },
                new TranslationKey { Id = 3, PublicId = "district_herat_center", Name = "Herat Center District", MessageCode = 1003, IsActive = true },
                new TranslationKey { Id = 4, PublicId = "province_kabul", Name = "Kabul Province", MessageCode = 2001, IsActive = true },
                new TranslationKey { Id = 5, PublicId = "province_herat", Name = "Herat Province", MessageCode = 2002, IsActive = true }
            );
        }
    }
}