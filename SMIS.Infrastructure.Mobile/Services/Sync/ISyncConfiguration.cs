using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

public interface ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto>
    where TEntity : class, ISyncableEntity
{
    string EntityName { get; }
    string ApiEndpoint { get; }
    string CreateEndpoint => ApiEndpoint;
    string UpdateEndpoint(string id) => $"{ApiEndpoint}/{id}";
    DateTime GetConflictModifiedUtc(TDto dto) => ((dynamic)dto!).LastModifiedUtc;
    TCreateDto MapToCreateDto(TEntity entity);
    TUpdateDto MapToUpdateDto(TEntity entity);
}
