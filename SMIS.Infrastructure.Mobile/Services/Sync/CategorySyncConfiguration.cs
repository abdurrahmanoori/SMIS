using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

public class CategorySyncConfiguration : ISyncConfiguration<Category, CategoryCreateDto, CategoryUpdateDto, CategoryDto>
{
    public string EntityName => "Category";
    public string ApiEndpoint => "/api/categories";

    public CategoryCreateDto MapToCreateDto(Category entity)
    {
        return new CategoryCreateDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Code = entity.Code,
            Description = entity.Description,
            IsActive = entity.IsActive,
            ShopId = entity.ShopId
        };
    }

    public CategoryUpdateDto MapToUpdateDto(Category entity)
    {
        return new CategoryUpdateDto
        {
            Name = entity.Name,
            Code = entity.Code,
            Description = entity.Description,
            IsActive = entity.IsActive
        };
    }
}
