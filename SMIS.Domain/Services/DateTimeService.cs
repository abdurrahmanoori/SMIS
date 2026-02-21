namespace SMIS.Domain.Services;

public static class DateTimeService
{
    public static DateTime Now => DateTime.Now;
    public static DateTime UtcNow => DateTime.UtcNow;
    public static DateTimeOffset NowOffSet => DateTimeOffset.Now;
    public static DateTimeOffset UtcNowOffSet => DateTimeOffset.UtcNow;
}
