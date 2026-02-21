using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class LanguageSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(
            new Language { Id = "1", Name = "English", Code = "en", IsActive = true },
            new Language { Id = "2", Name = "Pashto", Code = "ps", IsActive = true },
            new Language { Id = "3", Name = "Farsi", Code = "fa", IsActive = true }
        );
    }
}
