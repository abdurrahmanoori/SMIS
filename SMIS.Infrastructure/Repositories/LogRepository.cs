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
        }

        public async Task SaveLogAsync(AppLog log)
        {
            await AddAsync(log);
            await _context.SaveChangesAsync();
        }

        public async Task SaveLogsAsync(List<AppLog> logs)
        {
            await AddRangeAsync(logs);
            await _context.SaveChangesAsync();
        }
    }
}
