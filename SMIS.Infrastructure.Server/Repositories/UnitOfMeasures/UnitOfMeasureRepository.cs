using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.UnitOfMeasures
{
    public class UnitOfMeasureRepository : GenericRepository<UnitOfMeasure>, IUnitOfMeasureRepository
    {
        public UnitOfMeasureRepository(AppDbContext context) : base(context)
        {
        }

        public Task<UnitOfMeasure?> GetByIdIncludingDeletedAsync(string id, CancellationToken cancellationToken = default) =>
            _context.UnitOfMeasures.IgnoreQueryFilters().FirstOrDefaultAsync(unit => unit.Id == id, cancellationToken);

        public async Task<int> CountReferencesAsync(
            string id,
            CancellationToken cancellationToken = default)
        {
            var count = await _context.Products.CountAsync(
                product => product.BaseUnitId == id,
                cancellationToken);
            count += await _context.ProductUnits.CountAsync(
                productUnit => productUnit.UnitOfMeasureId == id,
                cancellationToken);
            count += await _context.StockBatches.CountAsync(
                batch => batch.ReceivedProductUnit.UnitOfMeasureId == id,
                cancellationToken);
            count += await _context.StockMovements.CountAsync(
                movement => movement.ProductUnit.UnitOfMeasureId == id,
                cancellationToken);
            count += await _context.LoanAccounts.CountAsync(
                loan => loan.UnitId == id,
                cancellationToken);
            return count;
        }
    }
}
