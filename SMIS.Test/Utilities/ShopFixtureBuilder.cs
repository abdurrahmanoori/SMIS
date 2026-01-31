using Bogus;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Enums;

namespace SMIS.Test.Utilities;

public class ShopFixtureBuilder
{
    private readonly Faker<ShopCreateDto> _faker;

    public ShopFixtureBuilder()
    {
        _faker = new Faker<ShopCreateDto>()
            .RuleFor(s => s.Name, f => f.Company.CompanyName())
            .RuleFor(s => s.ShopType, f => f.PickRandom<ShopType>())
            .RuleFor(s => s.Address, f => f.Address.FullAddress())
            .RuleFor(s => s.PhoneNumber, f => f.Phone.PhoneNumber("+855##-###-####"))
            .RuleFor(s => s.Email, f => f.Internet.Email())
            .RuleFor(s => s.TaxNumber, f => f.Random.Replace("TAX-####-####"))
            .RuleFor(s => s.IsActive, true);
    }

    public ShopFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(s => s.Name, name);
        return this;
    }

    public ShopFixtureBuilder WithShopType(ShopType shopType)
    {
        _faker.RuleFor(s => s.ShopType, shopType);
        return this;
    }

    public ShopFixtureBuilder WithAddress(string address)
    {
        _faker.RuleFor(s => s.Address, address);
        return this;
    }

    public ShopFixtureBuilder WithPhoneNumber(string phoneNumber)
    {
        _faker.RuleFor(s => s.PhoneNumber, phoneNumber);
        return this;
    }

    public ShopFixtureBuilder WithEmail(string email)
    {
        _faker.RuleFor(s => s.Email, email);
        return this;
    }

    public ShopFixtureBuilder WithTaxNumber(string taxNumber)
    {
        _faker.RuleFor(s => s.TaxNumber, taxNumber);
        return this;
    }

    public ShopFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(s => s.IsActive, isActive);
        return this;
    }

    public ShopCreateDto Build()
    {
        return _faker.Generate();
    }
}
