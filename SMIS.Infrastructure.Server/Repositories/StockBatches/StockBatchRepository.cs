using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.StockBatches
{
    public class StockBatchRepository : GenericRepository<StockBatch>, IStockBatchRepository
    {
        public StockBatchRepository(AppDbContext context) : base(context)
        {
        }
    }
}