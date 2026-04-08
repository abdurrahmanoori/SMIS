using SMIS.Application.DTO.Shops;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.Services.Sync.Shops;

public class ShopSyncConfiguration : ISyncConfiguration<Shop, ShopCreateDto, ShopUpdateDto, ShopDto>
{
    public string EntityName => "Shop";
    public string ApiEndpoint => "/api/Shop";

    public ShopCreateDto MapToCreateDto(Shop entity)
    {
        return new ShopCreateDto
        {
            Id = entity.Id,
            Name = entity.Name,
            ShopType = entity.ShopType,
            Address = entity.Address,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            TaxNumber = entity.TaxNumber,
            IsActive = entity.IsActive,
            CreatedDate = entity.CreatedDate,
            CreatedBy = entity.CreatedBy,
            LastModifiedUtc = entity.LastModifiedUtc
        };
    }

    public ShopUpdateDto MapToUpdateDto(Shop entity)
    {
        return new ShopUpdateDto
        {
            Name = entity.Name,
            ShopType = entity.ShopType,
            Address = entity.Address,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            TaxNumber = entity.TaxNumber,
            IsActive = entity.IsActive,
            UpdatedDate = entity.UpdatedDate,
            UpdatedBy = entity.UpdatedBy,
            LastModifiedUtc = entity.LastModifiedUtc
        };
    }
}
