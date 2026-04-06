using Bogus;
using SMIS.Application.DTO.Categories;

namespace SMIS.UI.Test.Utilities;

/// <summary>
/// Fluent builder for CategoryDto test data using Bogus.
/// Mirrors CategoryFixtureBuilder in SMIS.Test for consistency.
/// </summary>
public class CategoryDtoFixtureBuilder
{
    private readonly Faker<CategoryDto> _faker;

    public CategoryDtoFixtureBuilder()
    {
        _faker = new Faker<CategoryDto>()
            .RuleFor(c => c.Id, f => f.Random.Guid().ToString())
            .RuleFor(c => c.Name, f => f.Commerce.Department())
            .RuleFor(c => c.Code, f => f.Commerce.Categories(1)[0].ToUpper().Replace(" ", ""))
            .RuleFor(c => c.Description, f => f.Lorem.Sentence())
            .RuleFor(c => c.IsActive, true);
    }

    public CategoryDtoFixtureBuilder WithId(string id)
    {
        _faker.RuleFor(c => c.Id, id);
        return this;
    }

    public CategoryDtoFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(c => c.Name, name);
        return this;
    }

    public CategoryDtoFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(c => c.IsActive, isActive);
        return this;
    }

    public CategoryDto Build() => _faker.Generate();

    public List<CategoryDto> BuildMany(int count) => _faker.Generate(count);
}
