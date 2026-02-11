using Microsoft.EntityFrameworkCore;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Common.Interfaces;
using System.Linq.Expressions;

namespace SMIS.Infrastructure.Context;

public partial class AppDbContext
{
    private static void SetShopEntityFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : class, IShopEntity
    {
        var filterExpression = CreateShopFilterExpression<TEntity>();
        modelBuilder.Entity<TEntity>().HasQueryFilter(filterExpression);
    }

    private static Expression<Func<TEntity, bool>> CreateShopFilterExpression<TEntity>() where TEntity : class, IShopEntity
    {
        // Create: e => string.IsNullOrEmpty(currentShopId) || e.ShopId == currentShopId
        var parameter = Expression.Parameter(typeof(TEntity), "e");
        
        // Access to _currentUser.GetShopId() via static field (set per request)
        var currentShopIdProperty = Expression.Property(
            Expression.Constant(ShopIdHolder.Instance),
            nameof(ShopIdHolder.CurrentShopId));

        // e.ShopId
        var entityShopId = Expression.Property(parameter, nameof(IShopEntity.ShopId));

        // string.IsNullOrEmpty(currentShopId)
        var isNullOrEmpty = Expression.Call(
            typeof(string),
            nameof(string.IsNullOrEmpty),
            null,
            currentShopIdProperty);

        // e.ShopId == currentShopId
        var shopIdEquals = Expression.Equal(entityShopId, currentShopIdProperty);

        // string.IsNullOrEmpty(currentShopId) || e.ShopId == currentShopId
        var condition = Expression.OrElse(isNullOrEmpty, shopIdEquals);

        return Expression.Lambda<Func<TEntity, bool>>(condition, parameter);
    }

    public override int SaveChanges()
    {
        SetShopIdFromCurrentUser();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SetShopIdFromCurrentUser();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void SetShopIdFromCurrentUser()
    {
        if (_currentUser != null)
        {
            ShopIdHolder.Instance.CurrentShopId = _currentUser.GetShopId();
        }
    }
}

// Thread-safe holder for current ShopId per request
internal class ShopIdHolder
{
    private static readonly AsyncLocal<ShopIdHolder> _current = new();

    public static ShopIdHolder Instance => _current.Value ??= new ShopIdHolder();

    public string CurrentShopId { get; set; } = string.Empty;
}
