using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class TranslationSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Translation>().HasData(
            new Translation { Id = SeedIds.Trans1,  Name = "Kabul Center District",  TranslationKeyId = SeedIds.TKey1, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans2,  Name = "منطقه مرکز کابل",        TranslationKeyId = SeedIds.TKey1, LanguageNo = SeedIds.LangPs },
            new Translation { Id = SeedIds.Trans3,  Name = "Kabul North District",   TranslationKeyId = SeedIds.TKey2, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans4,  Name = "منطقه شمال کابل",        TranslationKeyId = SeedIds.TKey2, LanguageNo = SeedIds.LangPs },
            new Translation { Id = SeedIds.Trans5,  Name = "Herat Center District",  TranslationKeyId = SeedIds.TKey3, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans6,  Name = "منطقه مرکز هرات",        TranslationKeyId = SeedIds.TKey3, LanguageNo = SeedIds.LangPs },
            new Translation { Id = SeedIds.Trans7,  Name = "Kabul Province",         TranslationKeyId = SeedIds.TKey4, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans8,  Name = "ولایت کابل",             TranslationKeyId = SeedIds.TKey4, LanguageNo = SeedIds.LangPs },
            new Translation { Id = SeedIds.Trans9,  Name = "Herat Province",         TranslationKeyId = SeedIds.TKey5, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans10, Name = "ولایت هرات",             TranslationKeyId = SeedIds.TKey5, LanguageNo = SeedIds.LangPs },
            new Translation { Id = SeedIds.Trans11, Name = "Welcome Message",        TranslationKeyId = SeedIds.TKey6, LanguageNo = SeedIds.LangEn },
            new Translation { Id = SeedIds.Trans12, Name = "پیام خوش آمدید",         TranslationKeyId = SeedIds.TKey6, LanguageNo = SeedIds.LangPs }
        );
    }
}
