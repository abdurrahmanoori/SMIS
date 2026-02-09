using SMIS.Domain.Contracts;

namespace SMIS.Infrastructure.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime Now => DateTime.UtcNow;
    public DateTimeOffset NowOffSet => DateTimeOffset.UtcNow;
}
