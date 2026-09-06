using SMIS.Domain.Services;

namespace SMIS.Application.Common.Validation;

public static class SyncValidationRules
{
    public static bool BeValidGuid(string? value) => Guid.TryParse(value, out _);

    public static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default &&
        DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);

    public static bool IsModifiedDateValid(DateTime created, DateTime modified) =>
        created == default ||
        modified == default ||
        DateTimeService.NormalizeUtc(modified) >= DateTimeService.NormalizeUtc(created);
}
