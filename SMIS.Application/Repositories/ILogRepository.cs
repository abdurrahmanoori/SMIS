using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories
{
    public interface ILogRepository

    {
        Task SaveLogAsync(AppLog log);
        Task SaveLogsAsync(List<AppLog> logs);
    }

}
