using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.StockBatches
{
    public class StockBatchRepository : GenericRepository<StockBatch>, IStockBatchRepository
    {
        public StockBatchRepository(AppDbContext context) : base(context)
        {
        }
    }
}