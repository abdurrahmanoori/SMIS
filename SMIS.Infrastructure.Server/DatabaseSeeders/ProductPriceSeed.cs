using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ProductPriceSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var effectiveDate = new DateTime(2024, 1, 1);
        var prices = new (string Id, string ProductUnitId, long SellPrice)[]
        {
            (SeedIds.PP1,  SeedIds.PU1,   160),
            (SeedIds.PP2,  SeedIds.PU2,  1920),
            (SeedIds.PP3,  SeedIds.PU3,  3840),
            (SeedIds.PP4,  SeedIds.PU4,   150),
            (SeedIds.PP5,  SeedIds.PU5,  1800),
            (SeedIds.PP6,  SeedIds.PU6,  3600),
            (SeedIds.PP7,  SeedIds.PU7,    90),
            (SeedIds.PP8,  SeedIds.PU8,   540),
            (SeedIds.PP9,  SeedIds.PU9,  1080),
            (SeedIds.PP10, SeedIds.PU10,  270),
            (SeedIds.PP11, SeedIds.PU11, 3240),
            (SeedIds.PP12, SeedIds.PU12,12960),
            (SeedIds.PP13, SeedIds.PU13,  190),
            (SeedIds.PP14, SeedIds.PU14, 3800),
            (SeedIds.PP15, SeedIds.PU15,11400),
            (SeedIds.PP16, SeedIds.PU16,  130),
            (SeedIds.PP17, SeedIds.PU17, 3120),
            (SeedIds.PP18, SeedIds.PU18, 9360),
            (SeedIds.PP19, SeedIds.PU19,  320),
            (SeedIds.PP20, SeedIds.PU20, 3840),
            (SeedIds.PP21, SeedIds.PU21,16000),
            (SeedIds.PP22, SeedIds.PU22,   55),
            (SeedIds.PP23, SeedIds.PU23,  660),
            (SeedIds.PP24, SeedIds.PU24, 7920),
            (SeedIds.PP25, SeedIds.PU25,  420),
            (SeedIds.PP26, SeedIds.PU26, 8400),
            (SeedIds.PP27, SeedIds.PU27,  470),
            (SeedIds.PP28, SeedIds.PU28, 5640),
            (SeedIds.PP29, SeedIds.PU29,11280),
            (SeedIds.PP30, SeedIds.PU30,  300),
            (SeedIds.PP31, SeedIds.PU31, 3000),
            (SeedIds.PP32, SeedIds.PU32, 7500),
            (SeedIds.PP33, SeedIds.PU33,  220),
            (SeedIds.PP34, SeedIds.PU34, 4400),
            (SeedIds.PP35, SeedIds.PU35,11000),
            (SeedIds.PP36, SeedIds.PU36,  370),
            (SeedIds.PP37, SeedIds.PU37, 4440),
            (SeedIds.PP38, SeedIds.PU38, 8880),
            (SeedIds.PP39, SeedIds.PU39,  200),
            (SeedIds.PP40, SeedIds.PU40, 4800),
            (SeedIds.PP41, SeedIds.PU41,14400),
            (SeedIds.PP42, SeedIds.PU42,  270),
            (SeedIds.PP43, SeedIds.PU43,13500),
            (SeedIds.PP44, SeedIds.PU44,54000),
            (SeedIds.PP45, SeedIds.PU45,  850),
            (SeedIds.PP46, SeedIds.PU46,17000),
            (SeedIds.PP47, SeedIds.PU47,85000)
        };

        modelBuilder.Entity<ProductPrice>().HasData(
            prices.Select(price => CreateProductPrice(
                price.Id,
                price.ProductUnitId,
                price.SellPrice,
                effectiveDate)));
    }

    private static ProductPrice CreateProductPrice(
        string id,
        string productUnitId,
        long sellPrice,
        DateTime effectiveDate)
    {
        var productPrice = ProductPrice.Create(productUnitId, sellPrice, effectiveDate);

        typeof(ProductPrice).GetProperty(nameof(ProductPrice.Id))!.SetValue(productPrice, id);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.CreatedDate))!.SetValue(productPrice, DateTimeService.NowUtc);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.UpdatedDate))!.SetValue(productPrice, DateTimeService.NowUtc);
        typeof(ProductPrice).GetProperty(nameof(ProductPrice.LastModifiedUtc))!.SetValue(productPrice, DateTimeService.NowUtc);

        return productPrice;
    }
}
