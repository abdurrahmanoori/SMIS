using SMIS.Application.Repositories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories
{
    public class LogRepository : GenericRepository<AppLog>, ILogRepository
    {
        private readonly AppDbContext _context;
        
        public LogRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task SaveLogAsync(AppLog log)
        {
            try
            {
                await AddAsync(log);
                await _context.SaveChangesAsync();
            }
            catch
            {
                // Silently fail to prevent logging errors from crashing the app
            }
        }

        public async Task SaveLogsAsync(List<AppLog> logs)
        {
            try
            {
                await AddRangeAsync(logs);
                await _context.SaveChangesAsync();
            }
            catch
            {
                // Silently fail to prevent logging errors from crashing the app
            }
        }
    }
}
