using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;

namespace SMIS.UI.Services.Sync.Configurations;

public class CategorySyncConfiguration : ISyncConfiguration<Category, CategoryCreateDto, CategoryUpdateDto, CategoryDto>
{
    public string ApiEndpoint => "/api/category";
    public string EntityName => "Category";

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
