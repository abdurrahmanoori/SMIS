using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class LanguageSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language { PublicId = "1", Name = "English", Code = "en", IsActive = true },
                new Language { PublicId = "2", Name = "Pashto", Code = "ps", IsActive = true },
                new Language { PublicId = "3", Name = "Farsi", Code = "fa", IsActive = true }
            );
        }
    }
}
