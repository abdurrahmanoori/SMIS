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

        columns = columns.Select(x => x.ToUpper()).ToArray();
        var sourceType = source.ElementType;
        var resultType = typeof(TResult);
        var parameter = Expression.Parameter(sourceType, "e");

        var invalidColumns = string.Join(
            ", ",
            columns.Where(x => resultType.GetProperty(x, BindingFlags.IgnoreCase) == null)
        );
        if (string.IsNullOrEmpty(invalidColumns))
            throw new InvalidDataException($"{invalidColumns} columns are invalid.");

        var bindings = columns.Select(column => Expression.Bind(
                resultType.GetProperty(column)!,
                Expression.PropertyOrField(parameter, column)
            )
        );
        var body = Expression.MemberInit(Expression.New(resultType), bindings);
        var selector = Expression.Lambda(body, parameter);
        return source.Provider.CreateQuery<TResult>(
            Expression.Call(
                typeof(Queryable),
                "Select",
                new Type[] { sourceType, resultType },
                source.Expression,
                Expression.Quote(selector)
            )
        );
    }

    public static IQueryable<TResult> Filter<TResult>(this IQueryable<TResult> source, TResult? filter)
    {
        if (filter == null) return source;

        var properties = filter
            .GetType()
            .GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);

        Expression? conditions = null;
        var entityAccess = Expression.Parameter(typeof(TResult), "x");
        foreach (var property in properties)
        {
            var type = property.PropertyType;
            var value = property.GetValue(filter);
            if (value == null) continue;
            var propertyAccess = Expression.Property(entityAccess, property.Name);
            var constantExpression = Expression.Constant(value, type);

            Expression binaryExpression = type == typeof(string)
                ? GetLikeExpression(propertyAccess, (string)value)
                : Expression.Equal(propertyAccess, constantExpression);

            conditions = conditions == null
                ? binaryExpression
                : Expression.AndAlso(conditions, binaryExpression);
        }

        if (conditions == null) return source;
        var lambda = Expression.Lambda<Func<TResult, bool>>(conditions, entityAccess);
        source = source.Where(lambda);

        return source;
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

    public static MethodCallExpression GetLikeExpression(MemberExpression property, string term)
    {
        var method = (term.StartsWith('%'), term.EndsWith('%')) switch
        {
            (true, true) => nameof(string.Contains),
            (true, false) => nameof(string.StartsWith),
            (false, true) => nameof(string.EndsWith),
            (false, false) => nameof(string.Equals)
        };

        var toUpperMethod = typeof(string).GetMethod(nameof(string.ToUpper), Type.EmptyTypes)!;
        var upperTerm = term.ToUpper();

        return Expression.Call(
            Expression.Call(property, toUpperMethod),
            typeof(string).GetMethod(method, new[] { typeof(string) })!,
            Expression.Constant(upperTerm.Trim('%'), typeof(string))
        );
    }
}
