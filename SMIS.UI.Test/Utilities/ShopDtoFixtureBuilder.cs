using Bogus;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Enums;

namespace SMIS.UI.Test.Utilities;

/// <summary>
/// Fluent builder for ShopDto test data using Bogus.
/// Mirrors ShopFixtureBuilder in SMIS.Test for consistency.
/// </summary>
public class ShopDtoFixtureBuilder
{
    private readonly Faker<ShopDto> _faker;

    public ShopDtoFixtureBuilder()
    {
        _faker = new Faker<ShopDto>()
            .RuleFor(c => c.Id, f => f.Random.Guid().ToString())
            .RuleFor(c => c.Name, f => f.Company.CompanyName())
            .RuleFor(c => c.ShopType, f => f.PickRandom<ShopType>())
            .RuleFor(c => c.Address, f => f.Address.StreetAddress())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.TaxNumber, f => $"TAX{f.Random.Number(100, 999)}")
            .RuleFor(c => c.IsActive, true);
    }

    public ShopDtoFixtureBuilder WithId(string id)
    {
        _faker.RuleFor(c => c.Id, id);
        return this;
    }

    public ShopDtoFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(c => c.Name, name);
        return this;
    }

    public ShopDtoFixtureBuilder WithShopType(ShopType shopType)
    {
        _faker.RuleFor(c => c.ShopType, shopType);
        return this;
    }

    public ShopDtoFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(c => c.IsActive, isActive);
        return this;
    }

    public ShopDto Build() => _faker.Generate();

    public List<ShopDto> BuildMany(int count) => _faker.Generate(count);
}
