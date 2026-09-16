using SMIS.Domain.Services;

namespace SMIS.Application.Common.Validation;

/// <summary>
/// Shared validation rules for offline synchronization DTOs. These checks reject
/// malformed identity/timestamp metadata before conflict-resolution code sees it.
/// </summary>
public static class SyncValidationRules
{
    public static bool BeValidGuid(string? value) => Guid.TryParse(value, out _);

    public static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default &&
        // A small future tolerance avoids rejecting a valid offline edit because two
        // devices have slightly different clocks, while still catching obviously bad dates.
        DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);

    public static bool IsModifiedDateValid(DateTime created, DateTime modified) =>
        created == default ||
        modified == default ||
        DateTimeService.NormalizeUtc(modified) >= DateTimeService.NormalizeUtc(created);
}
