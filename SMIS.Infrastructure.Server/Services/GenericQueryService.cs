using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SMIS.Application.Common;
using SMIS.Application.Common.Queries;
using SMIS.Application.Services;
using SMIS.Infrastructure.Server.Context;

namespace SMIS.Infrastructure.Server.Services;

public sealed class GenericQueryService : IGenericQueryService
{
    private readonly AppDbContext _context;

    public GenericQueryService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PagedList<TEntity>> QueryAsync<TEntity, TQuery>(
        TQuery query,
        CancellationToken cancellationToken = default)
        where TEntity : class
        where TQuery : PagedQuery
    {
        ArgumentNullException.ThrowIfNull(query);
        ValidatePagination(query);

        IQueryable<TEntity> entities = _context.Set<TEntity>().AsNoTracking();
        entities = ApplyFilters(entities, query);

        var totalCount = await entities.CountAsync(cancellationToken);
        var orderedEntities = ApplyPrimaryKeyOrdering(entities);
        var offset = ((long)query.PageNumber - 1) * query.PageSize;
        var items = offset > int.MaxValue
            ? []
            : await orderedEntities
                .Skip((int)offset)
                .Take(query.PageSize)
                .ToListAsync(cancellationToken);

        return new PagedList<TEntity>
        {
            Items = items,
            PageNumber = query.PageNumber,
            PageSize = query.PageSize,
            TotalCount = totalCount,
            TotalPages = (int)Math.Ceiling((double)totalCount / query.PageSize)
        };
    }

    private static IQueryable<TEntity> ApplyFilters<TEntity, TQuery>(
        IQueryable<TEntity> entities,
        TQuery query)
        where TEntity : class
        where TQuery : PagedQuery
    {
        var parameter = Expression.Parameter(typeof(TEntity), "entity");
        Expression? body = null;

        foreach (var propertyPair in FilterMetadata<TEntity, TQuery>.PropertyPairs)
        {
            var value = propertyPair.QueryProperty.GetValue(query);
            if (value is null)
            {
                continue;
            }

            var entityProperty = Expression.Property(parameter, propertyPair.EntityProperty);
            var filter = propertyPair.UseContains
                ? CreateStringContainsFilter(entityProperty, (string)value)
                : CreateEqualityFilter(entityProperty, value);
            body = body is null ? filter : Expression.AndAlso(body, filter);
        }

        if (body is null)
        {
            return entities;
        }

        var predicate = Expression.Lambda<Func<TEntity, bool>>(body, parameter);
        return entities.Where(predicate);
    }

    private static Expression CreateStringContainsFilter(
        MemberExpression entityProperty,
        string suppliedValue)
    {
        var propertyIsNotNull = Expression.NotEqual(
            entityProperty,
            Expression.Constant(null, typeof(string)));
        var normalizedProperty = Expression.Call(
            entityProperty,
            nameof(string.ToLower),
            Type.EmptyTypes);
        var contains = Expression.Call(
            normalizedProperty,
            nameof(string.Contains),
            Type.EmptyTypes,
            Expression.Constant(suppliedValue.ToLowerInvariant()));

        return Expression.AndAlso(propertyIsNotNull, contains);
    }

    private static Expression CreateEqualityFilter(
        MemberExpression entityProperty,
        object suppliedValue)
    {
        Expression value = Expression.Constant(suppliedValue, suppliedValue.GetType());
        if (value.Type != entityProperty.Type)
        {
            value = Expression.Convert(value, entityProperty.Type);
        }

        return Expression.Equal(entityProperty, value);
    }

    private IQueryable<TEntity> ApplyPrimaryKeyOrdering<TEntity>(
        IQueryable<TEntity> entities)
        where TEntity : class
    {
        var entityType = _context.Model.FindEntityType(typeof(TEntity))
            ?? throw new InvalidOperationException(
                $"{typeof(TEntity).Name} is not part of the EF Core model.");
        var primaryKey = entityType.FindPrimaryKey()
            ?? throw new InvalidOperationException(
                $"{typeof(TEntity).Name} does not define a primary key.");

        IQueryable<TEntity> ordered = entities;
        var firstKey = true;

        foreach (var keyProperty in primaryKey.Properties)
        {
            ordered = ApplyOrdering(ordered, keyProperty, firstKey);
            firstKey = false;
        }

        return ordered;
    }

    private static IQueryable<TEntity> ApplyOrdering<TEntity>(
        IQueryable<TEntity> entities,
        IProperty keyProperty,
        bool firstKey)
        where TEntity : class
    {
        var parameter = Expression.Parameter(typeof(TEntity), "entity");
        Expression key = keyProperty.PropertyInfo is { } propertyInfo
            ? Expression.Property(parameter, propertyInfo)
            : Expression.Call(
                typeof(EF),
                nameof(EF.Property),
                [keyProperty.ClrType],
                parameter,
                Expression.Constant(keyProperty.Name));
        var keySelector = Expression.Lambda(key, parameter);
        var methodName = firstKey ? nameof(Queryable.OrderBy) : nameof(Queryable.ThenBy);
        var orderedExpression = Expression.Call(
            typeof(Queryable),
            methodName,
            [typeof(TEntity), keyProperty.ClrType],
            entities.Expression,
            Expression.Quote(keySelector));

        return entities.Provider.CreateQuery<TEntity>(orderedExpression);
    }

    private static void ValidatePagination(PagedQuery query)
    {
        if (query.PageNumber < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(query.PageNumber),
                "Page number must be at least 1.");
        }

        if (query.PageSize is < 1 or > PagedQuery.MaxPageSize)
        {
            throw new ArgumentOutOfRangeException(
                nameof(query.PageSize),
                $"Page size must be between 1 and {PagedQuery.MaxPageSize}.");
        }
    }

    private static class FilterMetadata<TEntity, TQuery>
        where TEntity : class
        where TQuery : PagedQuery
    {
        public static IReadOnlyList<PropertyPair> PropertyPairs { get; } = CreatePropertyPairs();

        private static IReadOnlyList<PropertyPair> CreatePropertyPairs()
        {
            var entityProperties = typeof(TEntity)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(property => property.CanRead)
                .ToDictionary(property => property.Name, StringComparer.OrdinalIgnoreCase);
            var paginationProperties = typeof(PagedQuery)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(property => property.Name)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            return typeof(TQuery)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(property => property.CanRead)
                .Where(property => !paginationProperties.Contains(property.Name))
                .Where(property => entityProperties.ContainsKey(property.Name))
                .Select(property => new PropertyPair(
                    property,
                    entityProperties[property.Name],
                    property.IsDefined(typeof(ContainsFilterAttribute))))
                .Where(pair => HaveCompatibleTypes(
                    pair.QueryProperty.PropertyType,
                    pair.EntityProperty.PropertyType))
                .Where(pair => !pair.UseContains
                    || pair.EntityProperty.PropertyType == typeof(string))
                .ToArray();
        }

        private static bool HaveCompatibleTypes(Type queryType, Type entityType) =>
            (Nullable.GetUnderlyingType(queryType) ?? queryType)
                == (Nullable.GetUnderlyingType(entityType) ?? entityType);
    }

    private sealed record PropertyPair(
        PropertyInfo QueryProperty,
        PropertyInfo EntityProperty,
        bool UseContains);
}
