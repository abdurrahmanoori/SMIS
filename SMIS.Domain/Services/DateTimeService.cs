namespace SMIS.Domain.Services;

public static class DateTimeService
{
    public static bool UseUtc { get; set; } = true;

    public static DateTime Now => UseUtc ? DateTime.UtcNow : DateTime.Now;
    public static DateTime UtcNow => DateTime.UtcNow;
}
