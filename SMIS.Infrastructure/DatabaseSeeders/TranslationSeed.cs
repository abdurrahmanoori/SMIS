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
                new Translation { Id = 1, PublicId = "1", TranslationKeyPublicId = "1", LanguageNo = 1 },
                new Translation { Id = 2, PublicId = "2", TranslationKeyPublicId = "1", LanguageNo = 2 },
                new Translation { Id = 3, PublicId = "3", TranslationKeyPublicId = "1", LanguageNo = 3 },
                
                new Translation { Id = 4, PublicId = "4", TranslationKeyPublicId = "2", LanguageNo = 1 },
                new Translation { Id = 5, PublicId = "5", TranslationKeyPublicId = "2", LanguageNo = 2 },
                new Translation { Id = 6, PublicId = "6", TranslationKeyPublicId = "2", LanguageNo = 3 },
                
                new Translation { Id = 7, PublicId = "7", TranslationKeyPublicId = "3", LanguageNo = 1 },
                new Translation { Id = 8, PublicId = "8", TranslationKeyPublicId = "3", LanguageNo = 2 },
                new Translation { Id = 9, PublicId = "9", TranslationKeyPublicId = "3", LanguageNo = 3 },
                
                // Province translations
                new Translation { Id = 10, PublicId = "10", TranslationKeyPublicId = "4", LanguageNo = 1 },
                new Translation { Id = 11, PublicId = "11", TranslationKeyPublicId = "4", LanguageNo = 2 },
                new Translation { Id = 12, PublicId = "12", TranslationKeyPublicId = "4", LanguageNo = 3 },
                
                new Translation { Id = 13, PublicId = "13", TranslationKeyPublicId = "5", LanguageNo = 1 },
                new Translation { Id = 14, PublicId = "14", TranslationKeyPublicId = "5", LanguageNo = 2 },
                new Translation { Id = 15, PublicId = "15", TranslationKeyPublicId = "5", LanguageNo = 3 }
            );
        }
    }
}