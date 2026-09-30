using SMIS.Application.DTO.Users;
using SMIS.Application.Features.Shops;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users;

internal static class UserMapping
{
    public static ApplicationUser Create(UserCreateDto dto) => ApplicationUser.Create(
        dto.UserName,
        dto.Email,
        dto.ShopId,
        dto.FirstName,
        dto.LastName,
        dto.PhoneNumber,
        dto.LanguageId);

    public static UserDto ToDto(ApplicationUser user) => new()
    {
        Id = user.Id,
        UserName = user.UserName,
        Email = user.Email,
        PhoneNumber = user.PhoneNumber,
        FirstName = user.FirstName,
        LastName = user.LastName,
        ShopId = user.ShopId,
        LanguageId = user.LanguageId,
        EmailConfirmed = user.EmailConfirmed,
        PhoneNumberConfirmed = user.PhoneNumberConfirmed,
        Shop = user.Shop is null ? null : ShopMapping.ToDto(user.Shop)
    };
}
