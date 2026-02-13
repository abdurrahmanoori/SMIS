using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Context;

public partial class AppDbContext
{
    private void SetShopEntityFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : class, IShopEntity
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e => 
            _currentUser.IsSuperAdmin() ||             
            e.ShopId == _currentUser.GetShopId());
    }
}
