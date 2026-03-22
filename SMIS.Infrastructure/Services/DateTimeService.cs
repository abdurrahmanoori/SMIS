using SMIS.Domain.Contracts;

namespace SMIS.Infrastructure.Server.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime Now => DateTime.UtcNow;
    public DateTime NowOffSet => DateTime.UtcNow;
}
