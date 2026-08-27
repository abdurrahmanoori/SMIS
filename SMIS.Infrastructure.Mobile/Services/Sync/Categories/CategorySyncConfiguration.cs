using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.Services.Sync.Categories;

public class CategorySyncConfiguration : ISyncConfiguration<Category, CategorySyncCreateDto, CategorySyncUpdateDto, CategoryDto>
{
    public string EntityName => "Category";
    public string ApiEndpoint => "/api/Category";
    public string CreateEndpoint => "/api/Category/sync";
    public string UpdateEndpoint(string id) => $"/api/Category/{id}/sync";
    public DateTime GetConflictModifiedUtc(CategoryDto dto) =>
        dto.ConflictModifiedUtc == default ? dto.LastModifiedUtc : dto.ConflictModifiedUtc;

    public CategorySyncCreateDto MapToCreateDto(Category entity)
    {
        return new CategorySyncCreateDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Code = entity.Code,
            Description = entity.Description,
            IsActive = entity.IsActive,
            ClientCreatedDate = entity.CreatedDate ?? entity.LastModifiedUtc,
            ClientModifiedDate = entity.LastModifiedUtc,
            ClientCreatedBy = entity.CreatedBy,
            ClientModifiedBy = entity.UpdatedBy ?? entity.CreatedBy
        };
    }

    public CategorySyncUpdateDto MapToUpdateDto(Category entity)
    {
        return new CategorySyncUpdateDto
        {
            Name = entity.Name,
            Code = entity.Code,
            Description = entity.Description,
            IsActive = entity.IsActive,
            ClientModifiedDate = entity.LastModifiedUtc,
            ClientModifiedBy = entity.UpdatedBy ?? entity.CreatedBy
        };
    }
}
