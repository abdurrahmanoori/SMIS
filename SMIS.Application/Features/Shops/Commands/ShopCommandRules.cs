using SMIS.Application.DTO.Shops;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Shops.Commands;

/// <summary>
/// Business mutations shared by direct online commands and offline sync commands.
/// </summary>
internal static class ShopCommandRules
{
    public static Shop Create(
        ShopCreateDto dto
    ) =>
        Shop.Create(
            dto.Name,
            dto.ShopType,
            dto.Address,
            dto.PhoneNumber,
            dto.Email,
            dto.TaxNumber,
            dto.IsActive);

    public static void Apply(
        Shop shop,
        ShopCreateDto dto
    ) =>
        Apply(
            shop,
            dto.Name,
            dto.ShopType,
            dto.Address,
            dto.PhoneNumber,
            dto.Email,
            dto.TaxNumber,
            dto.IsActive);

    public static void Apply(
        Shop shop,
        ShopUpdateDto dto
    ) =>
        Apply(
            shop,
            dto.Name,
            dto.ShopType,
            dto.Address,
            dto.PhoneNumber,
            dto.Email,
            dto.TaxNumber,
            dto.IsActive);

    private static void Apply(
        Shop shop,
        string name,
        ShopType shopType,
        string? address,
        string? phoneNumber,
        string? email,
        string? taxNumber,
        bool isActive
    )
    {
        shop.SetName(name);
        shop.SetShopType(shopType);
        shop.SetAddress(address);
        shop.SetPhoneNumber(phoneNumber);
        shop.SetEmail(email);
        shop.SetTaxNumber(taxNumber);

        if (isActive)
            shop.Activate();
        else
            shop.Deactivate();
    }
}