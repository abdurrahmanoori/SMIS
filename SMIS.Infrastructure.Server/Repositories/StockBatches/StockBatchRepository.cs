using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.StockBatches
{
    public class StockBatchRepository : GenericRepository<StockBatch>, IStockBatchRepository
    {
        public StockBatchRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<StockBatch>> GetAvailableFifoAsync(
            string shopId,
            string productId,
            CancellationToken cancellationToken = default) =>
            _context.StockBatches
                .Where(batch =>
                    batch.ShopId == shopId &&
                    batch.ProductId == productId &&
                    batch.RemainingQuantityBase > 0 &&
                    batch.Status == StatusEnum.Active)
                .OrderBy(batch => batch.ReceivedAtUtc)
                .ThenBy(batch => batch.Id)
                .ToListAsync(cancellationToken);
    }
}