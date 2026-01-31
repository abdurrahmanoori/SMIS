using Bogus;
using SMIS.Application.DTO.UnitOfMeasures;

namespace SMIS.Test.Utilities;

public class UnitOfMeasureFixtureBuilder
{
    private readonly Faker<UnitOfMeasureCreateDto> _faker;

    public UnitOfMeasureFixtureBuilder()
    {
        _faker = new Faker<UnitOfMeasureCreateDto>()
            .RuleFor(u => u.Name, f => f.Commerce.ProductMaterial())
            .RuleFor(u => u.Symbol, f => f.Random.String2(2, 5).ToLower())
            .RuleFor(u => u.Description, f => f.Lorem.Sentence());
    }

    public UnitOfMeasureFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(u => u.Name, name);
        return this;
    }

    public UnitOfMeasureFixtureBuilder WithSymbol(string symbol)
    {
        _faker.RuleFor(u => u.Symbol, symbol);
        return this;
    }

    public UnitOfMeasureFixtureBuilder WithDescription(string? description)
    {
        _faker.RuleFor(u => u.Description, description);
        return this;
    }

    public UnitOfMeasureCreateDto Build()
    {
        return _faker.Generate();
    }
}
