using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class TranslationKeySeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TranslationKey>().HasData(
            new TranslationKey { Id = SeedIds.TKey1, Name = "Kabul Center District", MessageCode = "1001", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey2, Name = "Kabul North District",  MessageCode = "1002", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey3, Name = "Herat Center District", MessageCode = "1003", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey4, Name = "Kabul Province",        MessageCode = "2001", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey5, Name = "Herat Province",        MessageCode = "2002", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey6, Name = "Welcome Message",       MessageCode = "3001", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey7, Name = "Error Message",         MessageCode = "3002", IsActive = true },
            new TranslationKey { Id = SeedIds.TKey8, Name = "Success Message",       MessageCode = "3003", IsActive = true }
        );
    }
}
