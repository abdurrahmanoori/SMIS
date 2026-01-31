namespace SMIS.Test.Utilities;

public class UnitOfMeasureTestDataHelper
{
    private readonly HttpClient _client;
    private bool _dependenciesInitialized;

    public UnitOfMeasureTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public Task GetOrCreateDependencies()
    {
        _dependenciesInitialized = true;
        return Task.CompletedTask;
    }

    public UnitOfMeasureFixtureBuilder CreateUnitOfMeasureBuilder()
    {
        if (!_dependenciesInitialized)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new UnitOfMeasureFixtureBuilder();
    }
}
