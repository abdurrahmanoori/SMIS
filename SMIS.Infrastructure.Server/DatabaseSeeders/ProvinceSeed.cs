using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProvinceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            new Province { Id = SeedIds.ProvinceKabul,    Name = "Kabul" },
            new Province { Id = SeedIds.ProvinceHerat,    Name = "Herat" },
            new Province { Id = SeedIds.ProvinceKandahar, Name = "Kandahar" },
            new Province { Id = SeedIds.ProvinceBalkh,    Name = "Balkh" }
        );

        modelBuilder.Entity<ProvinceTranslation>().HasData(
            new ProvinceTranslation { Id = SeedIds.PTrans1,  ProvinceId = SeedIds.ProvinceKabul,    LanguageId = SeedIds.LangEn, LanguageCode = "en", Name = "Kabul",    IsDefault = true  },
            new ProvinceTranslation { Id = SeedIds.PTrans2,  ProvinceId = SeedIds.ProvinceKabul,    LanguageId = SeedIds.LangPs, LanguageCode = "ps", Name = "کابل",    IsDefault = false },
            new ProvinceTranslation { Id = SeedIds.PTrans3,  ProvinceId = SeedIds.ProvinceKabul,    LanguageId = SeedIds.LangFa, LanguageCode = "fa", Name = "کابل",    IsDefault = false },

            new ProvinceTranslation { Id = SeedIds.PTrans4,  ProvinceId = SeedIds.ProvinceHerat,    LanguageId = SeedIds.LangEn, LanguageCode = "en", Name = "Herat",    IsDefault = true  },
            new ProvinceTranslation { Id = SeedIds.PTrans5,  ProvinceId = SeedIds.ProvinceHerat,    LanguageId = SeedIds.LangPs, LanguageCode = "ps", Name = "هرات",    IsDefault = false },
            new ProvinceTranslation { Id = SeedIds.PTrans6,  ProvinceId = SeedIds.ProvinceHerat,    LanguageId = SeedIds.LangFa, LanguageCode = "fa", Name = "هرات",    IsDefault = false },

            new ProvinceTranslation { Id = SeedIds.PTrans7,  ProvinceId = SeedIds.ProvinceKandahar, LanguageId = SeedIds.LangEn, LanguageCode = "en", Name = "Kandahar", IsDefault = true  },
            new ProvinceTranslation { Id = SeedIds.PTrans8,  ProvinceId = SeedIds.ProvinceKandahar, LanguageId = SeedIds.LangPs, LanguageCode = "ps", Name = "کندهار",  IsDefault = false },
            new ProvinceTranslation { Id = SeedIds.PTrans9,  ProvinceId = SeedIds.ProvinceKandahar, LanguageId = SeedIds.LangFa, LanguageCode = "fa", Name = "قندهار",  IsDefault = false },

            new ProvinceTranslation { Id = SeedIds.PTrans10, ProvinceId = SeedIds.ProvinceBalkh,    LanguageId = SeedIds.LangEn, LanguageCode = "en", Name = "Balkh",    IsDefault = true  },
            new ProvinceTranslation { Id = SeedIds.PTrans11, ProvinceId = SeedIds.ProvinceBalkh,    LanguageId = SeedIds.LangPs, LanguageCode = "ps", Name = "بلخ",     IsDefault = false },
            new ProvinceTranslation { Id = SeedIds.PTrans12, ProvinceId = SeedIds.ProvinceBalkh,    LanguageId = SeedIds.LangFa, LanguageCode = "fa", Name = "بلخ",     IsDefault = false }
        );
    }
}
