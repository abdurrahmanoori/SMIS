using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class LanguageSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = new Guid("00000000-0000-0000-0000-000000000001"), Name = "English", Code = "en", IsActive = true },
                new Language { Id = new Guid("00000000-0000-0000-0000-000000000002"), Name = "Pashto", Code = "ps", IsActive = true },
                new Language { Id = new Guid("00000000-0000-0000-0000-000000000003"), Name = "Farsi", Code = "fa", IsActive = true }
            );
        }
    }
}
