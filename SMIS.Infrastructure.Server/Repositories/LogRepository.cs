using SMIS.Application.Repositories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories
{
    public class LogRepository : GenericRepository<AppLog>, ILogRepository
    {
        private readonly AppDbContext _db;

        public LogRepository(AppDbContext context) : base(context)
        {
            _db = context;
        }

        public async Task SaveLogAsync(AppLog log)
        {
            await AddAsync(log);
            await _db.SaveChangesAsync();
        }

        public async Task SaveLogsAsync(List<AppLog> logs)
        {
            await AddRangeAsync(logs);
            await _db.SaveChangesAsync();
        }
    }
}
