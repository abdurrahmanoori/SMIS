using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class DistrictSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(
                new District { Id = 1, PublicId = "district-kabul-center-guid", Name = "Kabul Center", TranslationKeyId = "district_kabul_center" },
                new District { Id = 2, PublicId = "district-kabul-north-guid", Name = "Kabul North", TranslationKeyId = "district_kabul_north" },
                new District { Id = 3, PublicId = "district-herat-center-guid", Name = "Herat Center", TranslationKeyId = "district_herat_center" }
            );
        }
    }
}