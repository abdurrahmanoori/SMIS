namespace SMIS.Domain.Services;

public static class DateTimeService
{
    public static DateTime Now => DateTime.Now;
    public static DateTime UtcNow => DateTime.UtcNow;
    public static DateTime NowOffSet => DateTime.UtcNow;
    public static DateTime UtcNowOffSet => DateTime.UtcNow;
}
