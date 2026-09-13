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

    public async Task<int> CountReferencesAsync(
        string id,
        CancellationToken cancellationToken = default)
    {
        var count = await _context.Users.CountAsync(user => user.ShopId == id, cancellationToken);
        count += await _context.Categories.CountAsync(category => category.ShopId == id, cancellationToken);
        count += await _context.UnitOfMeasures.CountAsync(unit => unit.ShopId == id, cancellationToken);
        count += await _context.Products.CountAsync(product => product.ShopId == id, cancellationToken);
        count += await _context.StockTransactions.CountAsync(transaction => transaction.ShopId == id, cancellationToken);
        count += await _context.Customers.CountAsync(customer => customer.ShopId == id, cancellationToken);
        count += await _context.ShopOwners.CountAsync(owner => owner.ShopId == id, cancellationToken);
        count += await _context.LoanAccounts.CountAsync(loan => loan.ShopId == id, cancellationToken);
        return count;
    }
}
}
