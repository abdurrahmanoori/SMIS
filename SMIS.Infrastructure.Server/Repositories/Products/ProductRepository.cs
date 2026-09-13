using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Product?> GetByIdIncludingDeletedAsync(
            string id,
            CancellationToken cancellationToken = default)
        {
            return _context.Products
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(product => product.Id == id, cancellationToken);
        }

        public Task<int> CountByCategoryIdAsync(
            string categoryId,
            CancellationToken cancellationToken = default)
        {
            return _context.Products.CountAsync(
                product => product.CategoryId == categoryId,
                cancellationToken);
        }

        public async Task<int> CountReferencesAsync(
            string id,
            CancellationToken cancellationToken = default)
        {
            var count = await _context.ProductUnits.CountAsync(
                productUnit => productUnit.ProductId == id,
                cancellationToken);
            count += await _context.ProductPrices.CountAsync(
                price => price.ProductId == id,
                cancellationToken);
            count += await _context.StockBatches.CountAsync(
                batch => batch.ProductId == id,
                cancellationToken);
            count += await _context.StockTransactions.CountAsync(
                transaction => transaction.ProductId == id,
                cancellationToken);
            count += await _context.LoanAccounts.CountAsync(
                loan => loan.ProductId == id,
                cancellationToken);
            return count;
        }
    }
}
