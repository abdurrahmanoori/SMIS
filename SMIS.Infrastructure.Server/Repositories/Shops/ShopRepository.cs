using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace SMIS.Infrastructure.Server.Repositories.Shops
{
    public class ShopRepository : GenericRepository<Shop>, IShopRepository
    {
        public ShopRepository(AppDbContext context) : base(context)
    {
    }

    public Task<Shop?> GetByIdIncludingDeletedAsync(
        string id,
        CancellationToken cancellationToken = default) =>
        _context.Shops.IgnoreQueryFilters()
            .FirstOrDefaultAsync(shop => shop.Id == id, cancellationToken);
}
}
