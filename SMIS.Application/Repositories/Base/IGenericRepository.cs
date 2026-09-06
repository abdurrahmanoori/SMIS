using System.Linq.Expressions;

namespace SMIS.Application.Repositories.Base;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    Task AddRangeAsync(List<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task RemoveAsync(TEntity entity);

    Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>> filter,
        CancellationToken cancellationToken = default);

    Task<TEntity?> GetByIdAsync(string id);

    Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> filter,
        string? includeProperties = null,
        bool tracked = true);

    Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> filter,
        bool tracked = true,
        params Expression<Func<TEntity, object>>[] includeProperties);

    Task<TEntity?> GetFirstOrDefaultAsyncWithInclude(
        Expression<Func<TEntity, bool>> filter,
        Func<IQueryable<TEntity>, IQueryable<TEntity>>? include = null,
        bool tracked = true);

    Task<IEnumerable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        string? includeProperties = null,
        bool tracked = false,
        bool ignoreQueryFilters = false);

    /// <summary>
    /// This method is deprecated and will be removed in future versions. Use GetAllAsync instead.
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="includeProperties"></param>
    /// <param name="tracked"></param>
    /// <returns></returns>
    IQueryable<TEntity> GetAllQueryable(
        Expression<Func<TEntity, bool>>? filter = null,
        string? includeProperties = null,
        bool tracked = false);
}
