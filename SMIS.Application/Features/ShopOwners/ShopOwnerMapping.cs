using SMIS.Application.DTO.ShopOwners;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ShopOwners;

internal static class ShopOwnerMapping
{
    public static ShopOwnerDto ToDto(ShopOwner owner) => new()
    {
        Id = owner.Id,
        ApplicationUserId = owner.ApplicationUserId,
        ShopId = owner.ShopId,
        ShopName = owner.ShopName,
        FirstName = owner.FirstName,
        LastName = owner.LastName,
        NationalIdCardNumber = owner.NationalIdCardNumber,
        PhoneNumber = owner.PhoneNumber,
        Email = owner.Email,
        Address = owner.Address,
        OwnershipPercentage = owner.OwnershipPercentage,
        StartDate = owner.StartDate,
        EndDate = owner.EndDate,
        IsActive = owner.IsActive,
        ProvinceId = owner.ProvinceId,
        DistrictId = owner.DistrictId
    };
}
