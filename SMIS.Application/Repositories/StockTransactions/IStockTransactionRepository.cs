using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.StockTransactions
{
    public interface IStockTransactionRepository : IGenericRepository<StockTransaction>
    {
        Task<IEnumerable<StockTransaction>> GetByProductIdAsync(string productId);
        Task<IEnumerable<StockTransaction>> GetByStockBatchIdAsync(string stockBatchId);
        Task<IEnumerable<StockTransaction>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
    }
}