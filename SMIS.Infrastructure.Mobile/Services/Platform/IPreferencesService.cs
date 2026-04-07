namespace SMIS.Infrastructure.Mobile.Services.Platform;

public interface IPreferencesService
{
    string Get(string key, string defaultValue);
    void Set(string key, string value);
}
