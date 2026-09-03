using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class LanguageSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(
            new Language { Id = SeedIds.LangEn, Name = "English", Code = "en", IsActive = true },
            new Language { Id = SeedIds.LangPs, Name = "Pashto",  Code = "ps", IsActive = true },
            new Language { Id = SeedIds.LangFa, Name = "Farsi",   Code = "fa", IsActive = true }
        );
    }
}
