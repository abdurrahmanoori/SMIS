using Bogus;
using SMIS.Domain.Entities;

namespace SMIS.Infra.M.Test.Utilities;

public class CategoryFixtureBuilder
{
    private string _name;
    private string _shopId;
    private string? _code;
    private string? _description;
    private bool _isActive;

    public CategoryFixtureBuilder()
    {
        var faker = new Faker();
        _name = faker.Commerce.Department();
        _shopId = "shop-1";
        _code = faker.Commerce.Categories(1)[0].ToUpper().Replace(" ", "");
        _description = faker.Lorem.Sentence();
        _isActive = true;
    }

    public CategoryFixtureBuilder WithName(string name) { _name = name; return this; }
    public CategoryFixtureBuilder WithShopId(string shopId) { _shopId = shopId; return this; }
    public CategoryFixtureBuilder WithCode(string? code) { _code = code; return this; }
    public CategoryFixtureBuilder WithDescription(string? description) { _description = description; return this; }
    public CategoryFixtureBuilder WithIsActive(bool isActive) { _isActive = isActive; return this; }

    public Category Build() => Category.Create(_name, _shopId, _code, _description, _isActive);
}
