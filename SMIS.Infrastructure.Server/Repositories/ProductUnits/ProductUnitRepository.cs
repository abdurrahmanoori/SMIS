using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.ProductUnits
{
    public class ProductUnitRepository : GenericRepository<ProductUnit>, IProductUnitRepository
    {
        public ProductUnitRepository(AppDbContext context) : base(context)
        {
        }

        public Task<ProductUnit?> GetByIdIncludingDeletedAsync(string id, CancellationToken cancellationToken = default) =>
            _context.ProductUnits.IgnoreQueryFilters().FirstOrDefaultAsync(unit => unit.Id == id, cancellationToken);

        public Task<bool> ExistsPairAsync(
            string productId,
            string unitOfMeasureId,
            string? excludeId = null,
            CancellationToken cancellationToken = default) =>
            _context.ProductUnits.IgnoreQueryFilters().AnyAsync(
                item => item.ProductId == productId &&
                        item.UnitOfMeasureId == unitOfMeasureId &&
                         (excludeId == null || item.Id != excludeId),
                cancellationToken);

        public async Task<bool> HasUsageAsync(
            string id,
            CancellationToken cancellationToken = default)
        {
            var productUnit = await _context.ProductUnits
                .IgnoreQueryFilters()
                .Where(item => item.Id == id)
                .Select(item => new { item.ProductId, item.UnitOfMeasureId })
                .FirstOrDefaultAsync(cancellationToken);

            if (productUnit is null) return false;

            if (await _context.ProductPrices
                    .IgnoreQueryFilters()
                    .AnyAsync(price => price.ProductUnitId == id, cancellationToken))
                return true;

            if (await _context.StockBatches
                    .IgnoreQueryFilters()
                    .AnyAsync(batch => batch.ReceivedProductUnitId == id, cancellationToken))
                return true;

            return await _context.StockMovements
                .IgnoreQueryFilters()
                .AnyAsync(movement => movement.ProductUnitId == id, cancellationToken);
        }
    }
}
