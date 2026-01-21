using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class TranslationSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new Translation { PublicId = "1", TranslationKeyPublicId = "1", LanguageNo = "1" },
                new Translation { PublicId = "2", TranslationKeyPublicId = "1", LanguageNo = "2" },
                new Translation { PublicId = "3", TranslationKeyPublicId = "1", LanguageNo = "3" },
                
                new Translation { PublicId = "4", TranslationKeyPublicId = "2", LanguageNo = "1" },
                new Translation { PublicId = "5", TranslationKeyPublicId = "2", LanguageNo = "2" },
                new Translation { PublicId = "6", TranslationKeyPublicId = "2", LanguageNo = "3" },
                
                new Translation { PublicId = "7", TranslationKeyPublicId = "3", LanguageNo = "1" },
                new Translation { PublicId = "8", TranslationKeyPublicId = "3", LanguageNo = "2" },
                new Translation { PublicId = "9", TranslationKeyPublicId = "3", LanguageNo = "3" },
                
                new Translation { PublicId = "10", TranslationKeyPublicId = "4", LanguageNo = "1" },
                new Translation { PublicId = "11", TranslationKeyPublicId = "4", LanguageNo = "2" },
                new Translation { PublicId = "12", TranslationKeyPublicId = "4", LanguageNo = "3" },
                
                new Translation { PublicId = "13", TranslationKeyPublicId = "5", LanguageNo = "1" },
                new Translation { PublicId = "14", TranslationKeyPublicId = "5", LanguageNo = "2" },
                new Translation { PublicId = "15", TranslationKeyPublicId = "5", LanguageNo = "3" }
            );
        }
    }
}