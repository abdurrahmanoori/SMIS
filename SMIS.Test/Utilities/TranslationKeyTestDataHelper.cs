using SMIS.Application.DTO.TranslationKeys;

namespace SMIS.Test.Utilities;

public class TranslationKeyTestDataHelper
{
    private readonly HttpClient _client;
    private bool _dependenciesInitialized;

    public TranslationKeyTestDataHelper(HttpClient client)
    {
        _client = client;
    }

    public Task GetOrCreateDependencies()
    {
        _dependenciesInitialized = true;
        return Task.CompletedTask;
    }

    public TranslationKeyFixtureBuilder CreateTranslationKeyBuilder()
    {
        if (!_dependenciesInitialized)
            throw new InvalidOperationException("Dependencies must be created first. Call GetOrCreateDependencies().");
            
        return new TranslationKeyFixtureBuilder();
    }
}

public class TranslationKeyFixtureBuilder
{
    private string _name = "test_key";
    private string? _messageCode = "TEST001";
    private string _shopId = "1";
    private bool _isActive = true;

    public TranslationKeyFixtureBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public TranslationKeyFixtureBuilder WithMessageCode(string? messageCode)
    {
        _messageCode = messageCode;
        return this;
    }

    public TranslationKeyFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public TranslationKeyFixtureBuilder WithIsActive(bool isActive)
    {
        _isActive = isActive;
        return this;
    }

    public TranslationKeyCreateDto Build()
    {
        return new TranslationKeyCreateDto
        {
            Name = _name,
            MessageCode = _messageCode,
            ShopId = _shopId,
            IsActive = _isActive
        };
    }
}