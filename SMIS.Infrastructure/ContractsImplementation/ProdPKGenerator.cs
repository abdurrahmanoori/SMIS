using SMIS.Domain.Contracts;

namespace SMIS.Infrastructure.ContractsImplementation
{
    public class ProdPKGenerator : IPKGenerator
    {
        public string Generate() => Guid.NewGuid().ToString("N");

    }
}
