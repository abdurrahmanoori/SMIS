using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class LocalizedTextSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocalizedText>().HasData(SeedIds.Stamp(
            CreateText(SeedIds.CatTextBeverages, "Beverages"),
            CreateText(SeedIds.CatTextFood, "Food Items"),
            CreateText(SeedIds.CatTextStationery, "Stationery"),
            CreateText(SeedIds.CatTextGrocery, "Grocery"),
            CreateText(SeedIds.CatTextPersonalCare, "Personal Care"),
            CreateText(SeedIds.CatTextElectronics, "Electronics")
        ));

        modelBuilder.Entity<LocalizedTextTranslation>().HasData(SeedIds.Stamp(
            CreateTranslation(SeedIds.CatTextTransEnBeverages, SeedIds.CatTextBeverages, SeedIds.LangEn, "Beverages"),
            CreateTranslation(SeedIds.CatTextTransEnFood, SeedIds.CatTextFood, SeedIds.LangEn, "Food Items"),
            CreateTranslation(SeedIds.CatTextTransEnStationery, SeedIds.CatTextStationery, SeedIds.LangEn, "Stationery"),
            CreateTranslation(SeedIds.CatTextTransEnGrocery, SeedIds.CatTextGrocery, SeedIds.LangEn, "Grocery"),
            CreateTranslation(SeedIds.CatTextTransEnPersonalCare, SeedIds.CatTextPersonalCare, SeedIds.LangEn, "Personal Care"),
            CreateTranslation(SeedIds.CatTextTransEnElectronics, SeedIds.CatTextElectronics, SeedIds.LangEn, "Electronics"),
            CreateTranslation(SeedIds.CatTextTransFaBeverages, SeedIds.CatTextBeverages, SeedIds.LangFa, "نوشیدنی‌ها"),
            CreateTranslation(SeedIds.CatTextTransFaFood, SeedIds.CatTextFood, SeedIds.LangFa, "مواد غذایی"),
            CreateTranslation(SeedIds.CatTextTransFaStationery, SeedIds.CatTextStationery, SeedIds.LangFa, "لوازم تحریر"),
            CreateTranslation(SeedIds.CatTextTransFaGrocery, SeedIds.CatTextGrocery, SeedIds.LangFa, "مواد خوراکی"),
            CreateTranslation(SeedIds.CatTextTransFaPersonalCare, SeedIds.CatTextPersonalCare, SeedIds.LangFa, "مراقبت شخصی"),
            CreateTranslation(SeedIds.CatTextTransFaElectronics, SeedIds.CatTextElectronics, SeedIds.LangFa, "وسایل الکترونیکی")
        ));
    }

    private static LocalizedText CreateText(string id, string defaultValue)
    {
        var text = LocalizedText.Create(defaultValue);
        text.Id = id;
        return text;
    }

    private static LocalizedTextTranslation CreateTranslation(
        string id,
        string localizedTextId,
        string languageId,
        string value
    )
    {
        var translation = LocalizedTextTranslation.Create(localizedTextId, languageId, value);
        translation.Id = id;
        return translation;
    }
}
