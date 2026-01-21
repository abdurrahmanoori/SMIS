using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class TranslationSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new Translation { Id = "1", TranslationKeyId = "1", LanguageNo = "1" },
                new Translation { Id = "2", TranslationKeyId = "1", LanguageNo = "2" },
                new Translation { Id = "3", TranslationKeyId = "1", LanguageNo = "3" },

                new Translation { Id = "4", TranslationKeyId = "2", LanguageNo = "1" },
                new Translation { Id = "5", TranslationKeyId = "2", LanguageNo = "2" },
                new Translation { Id = "6", TranslationKeyId = "2", LanguageNo = "3" },

                new Translation { Id = "7", TranslationKeyId = "3", LanguageNo = "1" },
                new Translation { Id = "8", TranslationKeyId = "3", LanguageNo = "2" },
                new Translation { Id = "9", TranslationKeyId = "3", LanguageNo = "3" },

                new Translation { Id = "10", TranslationKeyId = "4", LanguageNo = "1" },
                new Translation { Id = "11", TranslationKeyId = "4", LanguageNo = "2" },
                new Translation { Id = "12", TranslationKeyId = "4", LanguageNo = "3" },

                new Translation { Id = "13", TranslationKeyId = "5", LanguageNo = "1" },
                new Translation { Id = "14", TranslationKeyId = "5", LanguageNo = "2" },
                new Translation { Id = "15", TranslationKeyId = "5", LanguageNo = "3" }
            );
        }
    }
}