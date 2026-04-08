using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class ShopTestDataHelper
{
    private readonly HttpClient _client;
    private bool _dependenciesCreated;

    public ShopTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task GetOrCreateDependencies()
    {
        if (_dependenciesCreated)
            return;

        // Shops don't have dependencies, so just mark as created
        _dependenciesCreated = true;
    }

    public ShopFixtureBuilder CreateShopBuilder()
    {
        if (!_dependenciesCreated)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");

        return new ShopFixtureBuilder();
    }
}
