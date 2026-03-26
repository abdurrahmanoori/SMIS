using Microsoft.Extensions.Configuration;
using SMIS.Application.Services;

namespace SMIS.Infrastructure.Server.Services
{
    public class PublicIdGenerator : IPublicIdGenerator
    {
        private readonly bool _isDevelopment;

        public PublicIdGenerator(IConfiguration configuration)
        {
            var environment = configuration["Environment"] ?? "Production";
            _isDevelopment = environment.Equals("Development", StringComparison.OrdinalIgnoreCase);
        }

        public string Generate()
        {
            return _isDevelopment ? string.Empty : Guid.NewGuid().ToString();
        }
    }
}
