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
                new Province { PublicId = "1", Name = "Kabul" },
                new Province { PublicId = "2", Name = "Herat" },
                new Province { PublicId = "3", Name = "Kandahar" },
                new Province { PublicId = "4", Name = "Balkh" }
            );

            modelBuilder.Entity<ProvinceTranslation>().HasData(
                new ProvinceTranslation { PublicId = "1", ProvinceId = "1", LanguageId = "1", LanguageCode = "en", Name = "Kabul", IsDefault = true },
                new ProvinceTranslation { PublicId = "2", ProvinceId = "1", LanguageId = "2", LanguageCode = "ps", Name = "کابل", IsDefault = false },
                new ProvinceTranslation { PublicId = "3", ProvinceId = "1", LanguageId = "3", LanguageCode = "fa", Name = "کابل", IsDefault = false },

                new ProvinceTranslation { PublicId = "4", ProvinceId = "2", LanguageId = "1", LanguageCode = "en", Name = "Herat", IsDefault = true },
                new ProvinceTranslation { PublicId = "5", ProvinceId = "2", LanguageId = "2", LanguageCode = "ps", Name = "هرات", IsDefault = false },
                new ProvinceTranslation { PublicId = "6", ProvinceId = "2", LanguageId = "3", LanguageCode = "fa", Name = "هرات", IsDefault = false },

                new ProvinceTranslation { PublicId = "7", ProvinceId = "3", LanguageId = "1", LanguageCode = "en", Name = "Kandahar", IsDefault = true },
                new ProvinceTranslation { PublicId = "8", ProvinceId = "3", LanguageId = "2", LanguageCode = "ps", Name = "کندهار", IsDefault = false },
                new ProvinceTranslation { PublicId = "9", ProvinceId = "3", LanguageId = "3", LanguageCode = "fa", Name = "قندهار", IsDefault = false },

                new ProvinceTranslation { PublicId = "10", ProvinceId = "4", LanguageId = "1", LanguageCode = "en", Name = "Balkh", IsDefault = true },
                new ProvinceTranslation { PublicId = "11", ProvinceId = "4", LanguageId = "2", LanguageCode = "ps", Name = "بلخ", IsDefault = false },
                new ProvinceTranslation { PublicId = "12", ProvinceId = "4", LanguageId = "3", LanguageCode = "fa", Name = "بلخ", IsDefault = false }
            );
        }
    }
}