using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories;

internal static class CategoryMapping
{
    public static CategoryDto ToDto(Category category) => new()
    {
        Id = category.Id,
        Name = category.Name,
        Code = category.Code,
        Description = category.Description,
        IsActive = category.IsActive,
        ShopId = category.ShopId,
        CreatedDate = AsUtc(category.CreatedDate),
        CreatedBy = category.CreatedBy,
        UpdatedDate = AsUtc(category.UpdatedDate),
        UpdatedBy = category.UpdatedBy,
        ClientModifiedDate = AsUtc(category.ClientModifiedDate),
        LastModifiedUtc = AsUtc(category.LastModifiedUtc),
        IsDeleted = category.IsDeleted
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
