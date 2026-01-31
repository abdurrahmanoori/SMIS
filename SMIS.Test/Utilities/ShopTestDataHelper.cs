namespace SMIS.Test.Utilities;

public class ShopTestDataHelper
{
    private readonly HttpClient _client;
    private bool _dependenciesInitialized;

    public ShopTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public Task GetOrCreateDependencies()
    {
        _dependenciesInitialized = true;
        return Task.CompletedTask;
    }

    public ShopFixtureBuilder CreateShopBuilder()
    {
        if (!_dependenciesInitialized)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new ShopFixtureBuilder();
    }
}
