using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.StockBatches
{
    public interface IStockBatchRepository : IGenericRepository<StockBatch>
    {
        Task<List<StockBatch>> GetAvailableFifoAsync(
            string shopId,
            string productId,
            CancellationToken cancellationToken = default);
    }
}