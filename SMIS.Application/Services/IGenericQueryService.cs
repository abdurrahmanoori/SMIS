using SMIS.Application.Common;
using SMIS.Application.Common.Queries;

namespace SMIS.Application.Services;

public interface IGenericQueryService
{
    Task<PagedList<TEntity>> QueryAsync<TEntity, TQuery>(
        TQuery query,
        CancellationToken cancellationToken = default)
        where TEntity : class
        where TQuery : PagedQuery;
}
