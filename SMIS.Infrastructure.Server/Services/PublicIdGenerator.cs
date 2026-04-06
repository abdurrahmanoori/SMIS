using Microsoft.Extensions.Configuration;
using SMIS.Application.Services;

namespace SMIS.Infrastructure.Server.Services
{
    public class PublicIdGenerator : IPublicIdGenerator
    {
        private readonly bool _useSequentialIds;

        public PublicIdGenerator(IConfiguration configuration)
        {
            var environment = configuration["Environment"] ?? "Production";
            // Sequential numeric IDs only in Development for readability.
            // Testing and Production both use GUIDs to match real production behaviour.
            _useSequentialIds = environment.Equals("Development", StringComparison.OrdinalIgnoreCase);
        }

        public string Generate()
        {
            // Return empty string to signal the interceptor to assign a sequential number.
            // For all other environments (Testing, Production) return a GUID.
            return _useSequentialIds ? string.Empty : Guid.NewGuid().ToString();
        }
    }
}
