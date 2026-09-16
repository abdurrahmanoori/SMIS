using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.StockBatches
{
    // Keeps batch-specific persistence rules together, including the FIFO ordering
    // used by every inventory issue workflow.
    public class StockBatchRepository : GenericRepository<StockBatch>, IStockBatchRepository
    {
        public StockBatchRepository(
            AppDbContext context
        ) : base(context)
        {
        }

        public Task<List<StockBatch>> GetAvailableFifoAsync(
            string shopId,
            string productId,
            DateTime occurredAtUtc,
            CancellationToken cancellationToken = default
        ) =>
            _context.StockBatches
                .Where(batch =>
                    batch.ShopId == shopId &&
                    batch.ProductId == productId &&
                    batch.RemainingQuantityBase > 0 &&
                    batch.Status == StatusEnum.Active &&
                    (!batch.ExpirationDate.HasValue || batch.ExpirationDate.Value > occurredAtUtc))
                // FEFO for dated stock, then FIFO. Batches without an expiry date are
                // consumed only after all eligible expiring batches.
                .OrderBy(batch => batch.ExpirationDate.HasValue ? 0 : 1)
                .ThenBy(batch => batch.ExpirationDate)
                .ThenBy(batch => batch.ReceivedAtUtc)
                .ThenBy(batch => batch.Id)
                .ToListAsync(cancellationToken);
    }
}