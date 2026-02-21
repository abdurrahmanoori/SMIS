using SMIS.Domain.Contracts;

namespace SMIS.Infrastructure.Server.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime Now => DateTime.UtcNow;
    public DateTimeOffset NowOffSet => DateTimeOffset.UtcNow;
}
