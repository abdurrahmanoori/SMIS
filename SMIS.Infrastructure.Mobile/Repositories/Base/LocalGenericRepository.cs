using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Infrastructure.Mobile.Context;
using System.Linq.Expressions;

namespace SMIS.Infrastructure.Mobile.Repositories.Base;

public class LocalGenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly LocalDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public LocalGenericRepository(LocalDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task AddRangeAsync(List<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public Task<T> UpdateAsync(T entity)
    {
        _context.Update(entity);
        return Task.FromResult(entity);
    }

    public Task RemoveAsync(T entity)
    {
        _dbSet.Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<bool> ExistsAsync(string id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity != null;
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AnyAsync(filter, cancellationToken);
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string? includeProperties = null,
        bool tracked = true)
    {
        IQueryable<T> query = tracked ? _dbSet : _dbSet.AsNoTracking();
        query = query.Where(filter);

        if (includeProperties != null)
        {
            foreach (var prop in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(prop);
            }
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        bool tracked = true,
        params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = tracked ? _dbSet : _dbSet.AsNoTracking();
        query = query.Where(filter);

        foreach (var prop in includeProperties)
        {
            query = query.Include(prop);
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task<T?> GetFirstOrDefaultAsyncWithInclude(
        Expression<Func<T, bool>> filter,
        Func<IQueryable<T>, IQueryable<T>>? include = null,
        bool tracked = true)
    {
        IQueryable<T> query = tracked ? _dbSet : _dbSet.AsNoTracking();
        query = query.Where(filter);

        if (include != null)
        {
            query = include(query);
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task<T> GetLastOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        bool tracked = true,
        Expression<Func<T, object>>[]? includeProperties = null,
        params Expression<Func<T, object>>[] orderByProperties)
    {
        IQueryable<T> query = tracked ? _dbSet : _dbSet.AsNoTracking();
        query = query.Where(filter);

        if (includeProperties != null)
        {
            foreach (var prop in includeProperties)
            {
                query = query.Include(prop);
            }
        }

        if (orderByProperties.Any())
        {
            IOrderedQueryable<T> orderedQuery = query.OrderBy(orderByProperties[0]);
            for (int i = 1; i < orderByProperties.Length; i++)
            {
                orderedQuery = orderedQuery.ThenBy(orderByProperties[i]);
            }
            query = orderedQuery;
        }

        return await query.LastOrDefaultAsync() ?? throw new InvalidOperationException("No elements found");
    }

    public async Task<List<T>> GetWhenAsync(Expression<Func<T, bool>> condition)
    {
        return await _dbSet.Where(condition).ToListAsync();
    }

    public async Task<List<T>> GetWhenContainsAsync<TProperty>(Expression<Func<T, TProperty>> property, List<TProperty> ids)
    {
        ids = ids.Where(x => x != null).ToList();
        var parameter = property.Parameters.First();
        var containsMethod = typeof(Enumerable).GetMethods()
            .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(TProperty));

        var containsExpression = Expression.Call(null, containsMethod, Expression.Constant(ids), Expression.Invoke(property, parameter));
        var lambda = Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
        return await _dbSet.Where(lambda).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (includeProperties != null)
        {
            foreach (var prop in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(prop);
            }
        }

        return await query.ToListAsync();
    }

    public IQueryable<T> GetAllQueryable(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (includeProperties != null)
        {
            foreach (var prop in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(prop);
            }
        }

        return query;
    }

    public async Task<List<T>> GetListAsync<T>(IQueryable<T> query)
    {
        return await query.ToListAsync();
    }

    public async Task<IReadOnlyList<T>> ExecuteRawQueryAsync(string sqlQuery)
    {
        return await _dbSet.FromSqlRaw(sqlQuery).ToListAsync();
    }

    public IQueryable<T> ExecuteRawQueryQueryable(string sqlQuery)
    {
        return _dbSet.FromSqlRaw(sqlQuery);
    }

    public async Task<bool> RecordExistsAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        return await _context.Set<T>().AnyAsync(predicate);
    }

    public async Task<int> ExecuteDeleteAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ExecuteDeleteAsync();
    }
}
