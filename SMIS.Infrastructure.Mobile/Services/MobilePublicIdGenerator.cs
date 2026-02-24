using SMIS.Application.Services;

namespace SMIS.Infrastructure.Mobile.Services;

public class MobilePublicIdGenerator : IPublicIdGenerator
{
    private readonly bool _isDevelopment;

    public MobilePublicIdGenerator()
    {
        // Check if running in debug mode
#if DEBUG
        _isDevelopment = true;
#else
        _isDevelopment = false;
#endif
    }

    public string Generate()
    {
        // Development: return empty string (sequential IDs will be assigned by interceptor)
        // Production: return GUID for offline-first
        return _isDevelopment ? string.Empty : Guid.NewGuid().ToString();
    }
}
