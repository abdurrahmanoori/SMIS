namespace SMIS.Domain.Services;

public static class DateTimeService
{

    public static DateTime NowUtc => DateTime.UtcNow;

    public static DateTime NowLocal => DateTime.Now;

    public static DateTime NormalizeUtc(DateTime value) =>
        value.Kind switch
        {
            DateTimeKind.Utc => value,

            DateTimeKind.Local =>
                value.ToUniversalTime(),

            DateTimeKind.Unspecified =>
                DateTime.SpecifyKind(
                    value,
                    DateTimeKind.Utc),

            _ => value
        };
    public static bool UseUtc { get; set; } = true;
    //
    // public static DateTime Now => UseUtc ? DateTime.UtcNow : DateTime.Now;
    // //public static DateTime UtcNowReal => UseUtc ? DateTime.UtcNow : DateTime.Now;
    // public static DateTime UtcNow => UseUtc ? DateTime.UtcNow.AddHours(4.5) : DateTime.Now.AddHours(4.5);


    //
    // public static DateTime NowUtc => DateTime.UtcNow;
    //
    // public static DateTime NowLocal =>
    //     TimeZoneInfo.ConvertTimeFromUtc(
    //         DateTime.UtcNow,
    //         TimeZoneInfo.Local);


}
