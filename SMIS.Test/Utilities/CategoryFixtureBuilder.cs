using Bogus;
using SMIS.Application.DTO.Categories;

namespace SMIS.Test.Utilities;

public class CategoryFixtureBuilder
{
    private readonly Faker<CategoryCreateDto> _faker;

    public CategoryFixtureBuilder()
    {
        _faker = new Faker<CategoryCreateDto>()
            .RuleFor(c => c.Name, f => f.Commerce.Department())
            .RuleFor(c => c.Code, f => f.Commerce.Categories(1)[0].ToUpper().Replace(" ", ""))
            .RuleFor(c => c.Description, f => f.Lorem.Sentence())
            .RuleFor(c => c.IsActive, true)
            .RuleFor(c => c.ShopId, "1"); // Default to shop ID "1" from seed data
    }

    public CategoryFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(c => c.Name, name);
        return this;
    }

    public CategoryFixtureBuilder WithCode(string? code)
    {
        _faker.RuleFor(c => c.Code, code);
        return this;
    }

    public CategoryFixtureBuilder WithDescription(string? description)
    {
        _faker.RuleFor(c => c.Description, description);
        return this;
    }

    public CategoryFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(c => c.IsActive, isActive);
        return this;
    }

    public CategoryFixtureBuilder WithShopId(string shopId)
    {
        _faker.RuleFor(c => c.ShopId, shopId);
        return this;
    }

    public CategoryCreateDto Build() => _faker.Generate();
}