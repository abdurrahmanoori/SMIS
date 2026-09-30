using SMIS.Application.DTO.Shops;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Shops;

internal static class ShopMapping
{
    public static ShopDto ToDto(Shop shop) => new()
    {
        Id = shop.Id,
        Name = shop.Name,
        ShopType = shop.ShopType,
        Address = shop.Address,
        PhoneNumber = shop.PhoneNumber,
        Email = shop.Email,
        TaxNumber = shop.TaxNumber,
        IsActive = shop.IsActive,
        LastModifiedUtc = AsUtc(shop.LastModifiedUtc),
        IsDeleted = shop.IsDeleted,
        ClientModifiedDate = AsUtc(shop.ClientModifiedDate)
    };

    private static DateTime AsUtc(DateTime value) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(DateTime? value) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
