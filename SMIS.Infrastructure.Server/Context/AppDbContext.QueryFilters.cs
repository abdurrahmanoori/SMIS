using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Server.Context;

public partial class AppDbContext
{
    // Every shop-owned entity is scoped to the current shop. When an entity also
    // supports soft deletion, both tenant isolation and deletion state are combined
    // into one filter because EF Core allows only one query filter per entity type.
    private void SetShopEntityFilter<TEntity>(
        ModelBuilder modelBuilder
    )
        where TEntity : class, IShopEntity
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e =>
            e.ShopId == _currentUser.GetShopId());
    }

    private void SetSoftDeletedShopEntityFilter<TEntity>(
        ModelBuilder modelBuilder
    )
        where TEntity : class, IShopEntity, ISoftDeletable
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e =>
            !e.IsDeleted &&
            e.ShopId == _currentUser.GetShopId());
    }

    private void SetSoftDeleteFilter<TEntity>(
        ModelBuilder modelBuilder
    )
        where TEntity : class, ISoftDeletable
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted);
    }
}