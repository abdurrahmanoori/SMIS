using SMIS.Test.Extensions;

namespace SMIS.Test.Utilities;

public class CategoryTestDataHelper
{
    private readonly HttpClient _client;
    private bool _dependenciesCreated;

    public CategoryTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task GetOrCreateDependencies()
    {
        if (_dependenciesCreated)
            return;

        // Categories don't have dependencies, so just mark as created
        _dependenciesCreated = true;
    }

    public CategoryFixtureBuilder CreateCategoryBuilder()
    {
        if (!_dependenciesCreated)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new CategoryFixtureBuilder();
    }
}