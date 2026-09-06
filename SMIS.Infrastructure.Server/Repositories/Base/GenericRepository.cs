using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Infrastructure.Server.Context;

namespace SMIS.Infrastructure.Server.Repositories.Base;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class
{
    internal readonly AppDbContext _context;

    public GenericRepository(
        AppDbContext context
    )
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(
        TEntity entity
    )
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public Task AddRangeAsync(
        List<TEntity> entities
    ) =>
        _context.Set<TEntity>().AddRangeAsync(entities);

    public Task<TEntity> UpdateAsync(
        TEntity entity
    )
    {
        _context.Set<TEntity>().Update(entity);
        return Task.FromResult(entity);
    }

    public Task RemoveAsync(
        TEntity entity
    )
    {
        _context.Set<TEntity>().Remove(entity);
        return Task.CompletedTask;
    }

    public Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>> filter,
        CancellationToken cancellationToken = default
    ) =>
        _context.Set<TEntity>().AnyAsync(filter, cancellationToken);

    public async Task<TEntity?> GetByIdAsync(
        string id
    ) =>
        await _context.Set<TEntity>().FindAsync(id);


    public Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> filter,
        string? includeProperties = null,
        bool tracked = true
    )
    {
        var query = ApplyIncludes(CreateQuery(tracked), includeProperties);
        return query.FirstOrDefaultAsync(filter);
    }

    public Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> filter,
        bool tracked = true,
        params Expression<Func<TEntity, object>>[] includeProperties
    )
    {
        var query = CreateQuery(tracked);
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return query.FirstOrDefaultAsync(filter);
    }

    public Task<TEntity?> GetFirstOrDefaultAsyncWithInclude(
        Expression<Func<TEntity, bool>> filter,
        Func<IQueryable<TEntity>, IQueryable<TEntity>>? include = null,
        bool tracked = true
    )
    {
        var query = CreateQuery(tracked);
        if (include is not null)
        {
            query = include(query);
        }

        return query.FirstOrDefaultAsync(filter);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        string? includeProperties = null,
        bool tracked = false,
        bool ignoreQueryFilters = false
    )
    {
        var query = CreateQuery(tracked);
        if (ignoreQueryFilters)
        {
            query = query.IgnoreQueryFilters();
        }

        query = ApplyFilter(query, filter);
        query = ApplyIncludes(query, includeProperties);
        return await query.ToListAsync();
    }

    /// <summary>
    /// This method is deprecated and will be removed in future versions. Use GetAllAsync instead.
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="includeProperties"></param>
    /// <param name="tracked"></param>
    /// <returns></returns>
    public IQueryable<TEntity> GetAllQueryable(
        Expression<Func<TEntity, bool>>? filter = null,
        string? includeProperties = null,
        bool tracked = false
    )
    {
        var query = ApplyFilter(CreateQuery(tracked), filter);
        return ApplyIncludes(query, includeProperties);
    }

    private IQueryable<TEntity> CreateQuery(
        bool tracked
    ) =>
        tracked ? _context.Set<TEntity>().AsTracking() : _context.Set<TEntity>().AsNoTracking();

    private static IQueryable<TEntity> ApplyFilter(
        IQueryable<TEntity> query,
        Expression<Func<TEntity, bool>>? filter
    ) =>
        filter is null ? query : query.Where(filter);

    private static IQueryable<TEntity> ApplyIncludes(
        IQueryable<TEntity> query,
        string? includeProperties
    )
    {
        if (string.IsNullOrWhiteSpace(includeProperties))
        {
            return query;
        }

        foreach (var includeProperty in includeProperties.Split(
                     ',',
                     StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            query = query.Include(includeProperty);
        }

        return query;
    }
}