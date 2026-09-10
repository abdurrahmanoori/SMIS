using System.Linq.Expressions;
using System.Reflection;

namespace SMIS.Application.Common;


public static class QueryExtensions
{
    // public static async Task<List<T>> QueryListAsync<T>(
    //     this IDbConnection connection,
    //     string sql,
    //     object? param = null)
    // {
    //     return (await connection.QueryAsync<T>(sql, param)).ToList();
    // }
    //
    // public static async Task<DataTable> QueryDataTableAsync(
    //        this IDbConnection connection,
    //        string sql,
    //        object? parameters = null,
    //        CancellationToken? cancellationToken = null)
    // {
    //     var datatable = new DataTable();
    //
    //     // 1. Wrap your query, parameters, and token into a CommandDefinition.
    //     // If cancellationToken is null, it defaults to CancellationToken.None safely.
    //     var commandDefinition = new CommandDefinition(
    //         commandText: sql,
    //         parameters: parameters,
    //         cancellationToken: cancellationToken ?? CancellationToken.None
    //     );
    //
    //     // 2. Pass the command definition into Dapper.
    //     // This fully enables Oracle query cancellation.
    //     var results = await connection.QueryAsync(commandDefinition);
    //
    //     if (results.Any())
    //     {
    //         var firstRecord = results.First();
    //         var columnNames = ((IDictionary<string, object>)firstRecord).Keys.ToList();
    //
    //         foreach (var columnName in columnNames)
    //         {
    //             var dataType = typeof(object);
    //             // Try to determine the actual type from the first non-null value
    //             foreach (var row in results)
    //             {
    //                 var dict = (IDictionary<string, object>)row;
    //                 if (dict[columnName] != null)
    //                 {
    //                     dataType = dict[columnName].GetType();
    //                     break;
    //                 }
    //             }
    //             datatable.Columns.Add(columnName, Nullable.GetUnderlyingType(dataType) ?? dataType);
    //         }
    //
    //         foreach (var row in results)
    //         {
    //             var dict = (IDictionary<string, object>)row;
    //             var dataRow = datatable.NewRow();
    //             foreach (var columnName in columnNames)
    //             {
    //                 dataRow[columnName] = dict[columnName] ?? DBNull.Value;
    //             }
    //             datatable.Rows.Add(dataRow);
    //         }
    //     }
    //
    //     return datatable;
    // }
    // public static async Task<T> QuerySingleWithTokenAsync<T>(
    //           this IDbConnection connection,
    //           string sql,
    //           object? parameters = null,
    //           CancellationToken cancellationToken = default)
    // {
    //     var commandDefinition = new CommandDefinition(
    //         commandText: sql,
    //         parameters: parameters,
    //         cancellationToken: cancellationToken
    //     );
    //
    //     return await connection.QuerySingleAsync<T>(commandDefinition);
    // }
    public static IQueryable<TResult> Select<TResult>(this IQueryable<TResult> source, string[]? columns)
    {
        if (columns == null || columns.Length == 0) return source;

        var resultType = typeof(TResult);
        var parameter = Expression.Parameter(resultType, "e");
        const BindingFlags propertyFlags =
            BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public;

        var selectedProperties = columns
            .Select(column => new
            {
                Column = column,
                Property = resultType.GetProperty(column, propertyFlags)
            })
            .ToList();

        var invalidColumns = string.Join(
            ", ",
            selectedProperties.Where(x => x.Property == null).Select(x => x.Column)
        );
        if (!string.IsNullOrEmpty(invalidColumns))
            throw new InvalidDataException($"{invalidColumns} columns are invalid.");

        var bindings = selectedProperties.Select(item => Expression.Bind(
                item.Property!,
                Expression.Property(parameter, item.Property!)
            )
        );
        var body = Expression.MemberInit(Expression.New(resultType), bindings);
        var selector = Expression.Lambda(body, parameter);
        return source.Provider.CreateQuery<TResult>(
            Expression.Call(
                typeof(Queryable),
                "Select",
                new Type[] { resultType, resultType },
                source.Expression,
                Expression.Quote(selector)
            )
        );
    }

    public static IQueryable<TEntity> Filter<TEntity, TFilter>(
        this IQueryable<TEntity> source,
        TFilter? filter)
    {
        if (filter == null) return source;

        var filterProperties = typeof(TFilter)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public);
        const BindingFlags entityPropertyFlags =
            BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public;

        Expression? conditions = null;
        var entityAccess = Expression.Parameter(typeof(TEntity), "x");

        foreach (var filterProperty in filterProperties)
        {
            var value = filterProperty.GetValue(filter);
            if (value == null) continue;

            if (value is string stringValue && string.IsNullOrWhiteSpace(stringValue))
                continue;

            var entityProperty = typeof(TEntity).GetProperty(
                filterProperty.Name,
                entityPropertyFlags);

            if (entityProperty == null)
                throw new InvalidDataException(
                    $"{filterProperty.Name} is not a valid filter property for {typeof(TEntity).Name}.");

            var propertyAccess = Expression.Property(entityAccess, entityProperty);
            Expression condition;

            if (value is string term)
            {
                if (entityProperty.PropertyType != typeof(string))
                    throw new InvalidDataException(
                        $"{filterProperty.Name} must match the entity property type.");

                condition = GetLikeExpression(propertyAccess, term.Trim());
            }
            else
            {
                Expression constant = Expression.Constant(value, value.GetType());
                if (constant.Type != propertyAccess.Type)
                    constant = Expression.Convert(constant, propertyAccess.Type);

                condition = Expression.Equal(propertyAccess, constant);
            }

            conditions = conditions == null
                ? condition
                : Expression.AndAlso(conditions, condition);
        }

        if (conditions == null) return source;
        var lambda = Expression.Lambda<Func<TEntity, bool>>(conditions, entityAccess);
        return source.Where(lambda);
    }

    public static IQueryable<TEntity> WhereIf<TEntity>(this IQueryable<TEntity> queryable, bool condition,
        Expression<Func<TEntity, bool>> expression)
    {
        return condition ? queryable.Where(expression) : queryable;
    }

    public static IQueryable<TEntity> WhereIfElse<TEntity>(
        this IQueryable<TEntity> queryable,
        bool condition,
        Expression<Func<TEntity, bool>> ifExpression,
        Expression<Func<TEntity, bool>> elseExpression
    )
    {
        return queryable.Where(condition ? ifExpression : elseExpression);
    }

    public static IQueryable<TEntity> WhereLike<TEntity, TProperty>(
        this IQueryable<TEntity> queryable,
        Expression<Func<TEntity, TProperty?>> propertySelector,
        string? term
    )
    {
        if (string.IsNullOrEmpty(term)) return queryable;
        if (propertySelector.Body is not MemberExpression property)
        {
            throw new ArgumentException("The expression must be a member expression.", nameof(propertySelector));
        }

        return queryable.Where(
            Expression.Lambda<Func<TEntity, bool>>(
                GetLikeExpression(property, term),
                propertySelector.Parameters
            )
        );
    }

    public static Expression GetLikeExpression(MemberExpression property, string term)
    {
        var method = (term.StartsWith('%'), term.EndsWith('%')) switch
        {
            (true, true) => nameof(string.Contains),
            (true, false) => nameof(string.EndsWith),
            (false, true) => nameof(string.StartsWith),
            (false, false) when property.Member.Name.EndsWith(
                "Id",
                StringComparison.OrdinalIgnoreCase) => nameof(string.Equals),
            (false, false) => nameof(string.Contains)
        };

        var toUpperMethod = typeof(string).GetMethod(nameof(string.ToUpper), Type.EmptyTypes)!;
        var upperTerm = term.ToUpper();

        var stringComparison = Expression.Call(
            Expression.Call(property, toUpperMethod),
            typeof(string).GetMethod(method, new[] { typeof(string) })!,
            Expression.Constant(upperTerm.Trim('%'), typeof(string))
        );

        return Expression.AndAlso(
            Expression.NotEqual(property, Expression.Constant(null, typeof(string))),
            stringComparison);
    }
}
