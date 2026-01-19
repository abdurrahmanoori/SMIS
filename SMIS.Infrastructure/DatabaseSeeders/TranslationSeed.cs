using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class TranslationSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                // District translations
                new Translation { Id = 1, TranslationKeyPublicId = "district_kabul_center", LanguageNo = 1 },
                new Translation { Id = 2, TranslationKeyPublicId = "district_kabul_center", LanguageNo = 2 },
                new Translation { Id = 3, TranslationKeyPublicId = "district_kabul_center", LanguageNo = 3 },
                
                new Translation { Id = 4, TranslationKeyPublicId = "district_kabul_north", LanguageNo = 1 },
                new Translation { Id = 5, TranslationKeyPublicId = "district_kabul_north", LanguageNo = 2 },
                new Translation { Id = 6, TranslationKeyPublicId = "district_kabul_north", LanguageNo = 3 },
                
                new Translation { Id = 7, TranslationKeyPublicId = "district_herat_center", LanguageNo = 1 },
                new Translation { Id = 8, TranslationKeyPublicId = "district_herat_center", LanguageNo = 2 },
                new Translation { Id = 9, TranslationKeyPublicId = "district_herat_center", LanguageNo = 3 },
                
                // Province translations
                new Translation { Id = 10, TranslationKeyPublicId = "province_kabul", LanguageNo = 1 },
                new Translation { Id = 11, TranslationKeyPublicId = "province_kabul", LanguageNo = 2 },
                new Translation { Id = 12, TranslationKeyPublicId = "province_kabul", LanguageNo = 3 },
                
                new Translation { Id = 13, TranslationKeyPublicId = "province_herat", LanguageNo = 1 },
                new Translation { Id = 14, TranslationKeyPublicId = "province_herat", LanguageNo = 2 },
                new Translation { Id = 15, TranslationKeyPublicId = "province_herat", LanguageNo = 3 }
            );
        }
    }
}