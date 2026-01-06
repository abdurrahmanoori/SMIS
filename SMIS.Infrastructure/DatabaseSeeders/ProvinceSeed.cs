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
                new Province { Id = new Guid("00000000-0000-0000-0000-000000000001"), Name = "Kabul" },
                new Province { Id = new Guid("00000000-0000-0000-0000-000000000002"), Name = "Herat" },
                new Province { Id = new Guid("00000000-0000-0000-0000-000000000003"), Name = "Kandahar" },
                new Province { Id = new Guid("00000000-0000-0000-0000-000000000004"), Name = "Balkh" }
            );

            // Seed province translations
            modelBuilder.Entity<ProvinceTranslation>().HasData(
                // Kabul translations
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000001"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageCode = "en", Name = "Kabul", IsDefault = true },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000002"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageCode = "ps", Name = "کابل", IsDefault = false },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000003"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageCode = "fa", Name = "کابل", IsDefault = false },

                // Herat translations
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000004"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageCode = "en", Name = "Herat", IsDefault = true },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000005"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageCode = "ps", Name = "هرات", IsDefault = false },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000006"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageCode = "fa", Name = "هرات", IsDefault = false },

                // Kandahar translations
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000007"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageCode = "en", Name = "Kandahar", IsDefault = true },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000008"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageCode = "ps", Name = "کندهار", IsDefault = false },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-000000000009"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageCode = "fa", Name = "قندهار", IsDefault = false },

                // Balkh translations
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-00000000000A"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000004"), LanguageId = new Guid("00000000-0000-0000-0000-000000000001"), LanguageCode = "en", Name = "Balkh", IsDefault = true },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-00000000000B"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000004"), LanguageId = new Guid("00000000-0000-0000-0000-000000000002"), LanguageCode = "ps", Name = "بلخ", IsDefault = false },
                new ProvinceTranslation { Id = new Guid("00000000-0000-0000-0000-00000000000C"), ProvinceId = new Guid("00000000-0000-0000-0000-000000000004"), LanguageId = new Guid("00000000-0000-0000-0000-000000000003"), LanguageCode = "fa", Name = "بلخ", IsDefault = false }
            );
        }
    }
}