using Bogus;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.Test.Utilities;

/// <summary>
/// Fluent builder for Category domain entities using Bogus.
/// Mirrors CategoryFixtureBuilder in SMIS.Test — same conventions, domain layer target.
/// </summary>
public class CategoryEntityBuilder
{
    private string _shopId = "shop-1";
    private string? _name;
    private string? _code;
    private string? _description;
    private bool _isActive = true;
    private bool _isSynced = false;
    private DateTime _lastModifiedUtc = DateTime.UtcNow;

    private static readonly Faker Faker = new();

    public CategoryEntityBuilder WithShopId(string shopId) { _shopId = shopId; return this; }
    public CategoryEntityBuilder WithName(string name) { _name = name; return this; }
    public CategoryEntityBuilder WithCode(string? code) { _code = code; return this; }
    public CategoryEntityBuilder WithIsActive(bool isActive) { _isActive = isActive; return this; }
    public CategoryEntityBuilder AsSynced() { _isSynced = true; return this; }
    public CategoryEntityBuilder WithLastModifiedUtc(DateTime utc) { _lastModifiedUtc = utc; return this; }

    public Category Build()
    {
        var name = _name ?? Faker.Commerce.Department();
        var category = Category.Create(name, _shopId, _code, _description, _isActive);
        category.IsSyncedToServer = _isSynced;
        category.LastModifiedUtc = _lastModifiedUtc;
        return category;
    }

    public List<Category> BuildMany(int count)
        => Enumerable.Range(0, count).Select(_ => new CategoryEntityBuilder()
            .WithShopId(_shopId)
            .WithIsActive(_isActive)
            .Build()).ToList();
}
