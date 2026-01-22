using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class TranslationSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new Translation { Id = "1", Name = "Kabul Center District", TranslationKeyId = "1", LanguageNo = "1" },
                new Translation { Id = "2", Name = "منطقه مرکز کابل", TranslationKeyId = "1", LanguageNo = "2" },
                new Translation { Id = "3", Name = "Kabul North District", TranslationKeyId = "2", LanguageNo = "1" },
                new Translation { Id = "4", Name = "منطقه شمال کابل", TranslationKeyId = "2", LanguageNo = "2" },
                new Translation { Id = "5", Name = "Herat Center District", TranslationKeyId = "3", LanguageNo = "1" },
                new Translation { Id = "6", Name = "منطقه مرکز هرات", TranslationKeyId = "3", LanguageNo = "2" },
                new Translation { Id = "7", Name = "Kabul Province", TranslationKeyId = "4", LanguageNo = "1" },
                new Translation { Id = "8", Name = "ولایت کابل", TranslationKeyId = "4", LanguageNo = "2" },
                new Translation { Id = "9", Name = "Herat Province", TranslationKeyId = "5", LanguageNo = "1" },
                new Translation { Id = "10", Name = "ولایت هرات", TranslationKeyId = "5", LanguageNo = "2" },
                new Translation { Id = "11", Name = "Welcome Message", TranslationKeyId = "6", LanguageNo = "1" },
                new Translation { Id = "12", Name = "پیام خوش آمدید", TranslationKeyId = "6", LanguageNo = "2" }
            );
        }
    }
}