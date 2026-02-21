using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.StockTransactions;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.StockTransactions
{
    public class StockTransactionRepository : GenericRepository<StockTransaction>, IStockTransactionRepository
    {
        private readonly AppDbContext _context;
        public StockTransactionRepository(AppDbContext context) : base(context)
        { 
               _context = context;
        }

        public async Task<IEnumerable<StockTransaction>> GetByProductIdAsync(string productId)
        {
            return await _context.StockTransactions
                .AsNoTracking()
                .Where(st => st.ProductId == productId)
                .OrderByDescending(st => st.TransactionDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<StockTransaction>> GetByStockBatchIdAsync(string stockBatchId)
        {
            return await _context.StockTransactions
                .AsNoTracking()
                .Where(st => st.StockBatchId == stockBatchId)
                .OrderByDescending(st => st.TransactionDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<StockTransaction>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.StockTransactions
                .AsNoTracking()
                .Where(st => st.TransactionDate >= startDate && st.TransactionDate <= endDate)
                .OrderByDescending(st => st.TransactionDate)
                .ToListAsync();
        }
    }
}