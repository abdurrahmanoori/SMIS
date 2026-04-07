namespace SMIS.Infrastructure.Mobile.Services.Platform;

/// <summary>
/// Wraps the MAUI Preferences API so it can be injected and mocked in tests.
/// </summary>
public class MauiPreferencesService : IPreferencesService
{
    public string Get(string key, string defaultValue)
        => Preferences.Get(key, defaultValue);

    public void Set(string key, string value)
        => Preferences.Set(key, value);
}
