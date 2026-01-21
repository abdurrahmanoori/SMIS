using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProvinceSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            // Seed provinces
            modelBuilder.Entity<Province>().HasData(
                new Province { Id = 1, PublicId = "1", Name = "Kabul" },
                new Province { Id = 2, PublicId = "2", Name = "Herat" },
                new Province { Id = 3, PublicId = "3", Name = "Kandahar" },
                new Province { Id = 4, PublicId = "4", Name = "Balkh" }
            );

            // Seed province translations
            modelBuilder.Entity<ProvinceTranslation>().HasData(
                // Kabul translations
                new ProvinceTranslation { Id = 1, PublicId = "1", ProvinceId = 1, LanguageId = 1, LanguageCode = "en", Name = "Kabul", IsDefault = true },
                new ProvinceTranslation { Id = 2, PublicId = "2", ProvinceId = 1, LanguageId = 2, LanguageCode = "ps", Name = "کابل", IsDefault = false },
                new ProvinceTranslation { Id = 3, PublicId = "3", ProvinceId = 1, LanguageId = 3, LanguageCode = "fa", Name = "کابل", IsDefault = false },

                // Herat translations
                new ProvinceTranslation { Id = 4, PublicId = "4", ProvinceId = 2, LanguageId = 1, LanguageCode = "en", Name = "Herat", IsDefault = true },
                new ProvinceTranslation { Id = 5, PublicId = "5", ProvinceId = 2, LanguageId = 2, LanguageCode = "ps", Name = "هرات", IsDefault = false },
                new ProvinceTranslation { Id = 6, PublicId = "6", ProvinceId = 2, LanguageId = 3, LanguageCode = "fa", Name = "هرات", IsDefault = false },

                // Kandahar translations
                new ProvinceTranslation { Id = 7, PublicId = "7", ProvinceId = 3, LanguageId = 1, LanguageCode = "en", Name = "Kandahar", IsDefault = true },
                new ProvinceTranslation { Id = 8, PublicId = "8", ProvinceId = 3, LanguageId = 2, LanguageCode = "ps", Name = "کندهار", IsDefault = false },
                new ProvinceTranslation { Id = 9, PublicId = "9", ProvinceId = 3, LanguageId = 3, LanguageCode = "fa", Name = "قندهار", IsDefault = false },

                // Balkh translations
                new ProvinceTranslation { Id = 10, PublicId = "10", ProvinceId = 4, LanguageId = 1, LanguageCode = "en", Name = "Balkh", IsDefault = true },
                new ProvinceTranslation { Id = 11, PublicId = "11", ProvinceId = 4, LanguageId = 2, LanguageCode = "ps", Name = "بلخ", IsDefault = false },
                new ProvinceTranslation { Id = 12, PublicId = "12", ProvinceId = 4, LanguageId = 3, LanguageCode = "fa", Name = "بلخ", IsDefault = false }
            );
        }
    }
}