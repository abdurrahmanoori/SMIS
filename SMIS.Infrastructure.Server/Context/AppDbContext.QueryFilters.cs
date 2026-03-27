using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Server.Context;

public partial class AppDbContext
{
    // Shop-scoped entities: exclude soft-deleted rows AND scope to current shop.
    // EF Core allows only one HasQueryFilter per entity type, so both conditions
    // are combined here rather than applied separately.
    private void SetShopEntityFilter<TEntity>(ModelBuilder modelBuilder)
        where TEntity : class, IShopEntity, ISoftDeletable
    {
        var test = _currentUser.GetShopId();
        var test2 = _currentUser.IsSuperAdmin();
        modelBuilder.Entity<TEntity>().HasQueryFilter(e =>
            !e.IsDeleted &&
            (_currentUser.IsSuperAdmin() || e.ShopId == _currentUser.GetShopId()));
    }
}
