using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(
            AppDbContext context
        ) : base(context)
        {
        }

        public Task<int> CountByCategoryIdAsync(
            string categoryId,
            CancellationToken cancellationToken = default
        )
        {
            return _context.Products.CountAsync(
                product => product.CategoryId == categoryId,
                cancellationToken);
        }

        public async Task<int> CountReferencesAsync(
            string id,
            CancellationToken cancellationToken = default
        )
        {
            // ProductUnit is an owned child of Product and is deleted by cascade.
            // Only external/business references should block deleting the product.
            var count = await _context.ProductPrices
                .CountAsync(
                    price => price.ProductUnit.ProductId == id,
                    cancellationToken);
            count += await _context.StockBatches
                .CountAsync(
                    batch => batch.ProductId == id,
                    cancellationToken);
            count += await _context.StockMovements
                .CountAsync(
                    movement => movement.ProductUnit.ProductId == id,
                    cancellationToken);
            count += await _context.SaleLines
                .CountAsync(
                    line => line.ProductId == id,
                    cancellationToken);
            return count;
        }

        public async Task<bool> HasStockOrConversionsAsync(
            string id,
            CancellationToken cancellationToken = default
        )
        {
            var baseUnitId = await _context.Products
                .IgnoreQueryFilters()
                .Where(product => product.Id == id)
                .Select(product => product.BaseUnitId)
                .FirstOrDefaultAsync(cancellationToken);

            var hasConversions = await _context.ProductUnits
                .IgnoreQueryFilters()
                .AnyAsync(
                    productUnit => productUnit.ProductId == id &&
                                   productUnit.UnitOfMeasureId != baseUnitId,
                    cancellationToken);
            if (hasConversions) return true;

            var hasStockBatches = await _context.StockBatches
                .IgnoreQueryFilters()
                .AnyAsync(batch => batch.ProductId == id, cancellationToken);
            if (hasStockBatches) return true;

            return await _context.StockMovements
                .IgnoreQueryFilters()
                .AnyAsync(movement => movement.StockBatch.ProductId == id, cancellationToken);
        }
    }
}