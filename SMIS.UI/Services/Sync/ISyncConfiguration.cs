using SMIS.Domain.Common.Interfaces;

namespace SMIS.UI.Services.Sync;

public interface ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto>
    where TEntity : class, ISyncableEntity
{
    string ApiEndpoint { get; }
    string EntityName { get; }
    TCreateDto MapToCreateDto(TEntity entity);
    TUpdateDto MapToUpdateDto(TEntity entity);
}
