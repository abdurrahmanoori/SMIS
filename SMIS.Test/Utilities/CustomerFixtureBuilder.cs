using Bogus;
using SMIS.Application.DTO.Customers;

namespace SMIS.Test.Utilities;

public class CustomerFixtureBuilder
{
    private readonly Faker<CustomerCreateDto> _faker;
    private string? _shopId;
    private string? _provinceId;
    private string? _districtId;

    public CustomerFixtureBuilder()
    {
        _faker = new Faker<CustomerCreateDto>()
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.FatherName, f => f.Random.Bool() ? f.Name.FirstName() : null)
            .RuleFor(c => c.Email, f => f.Random.Bool() ? f.Internet.Email() : null)
            .RuleFor(c => c.PhoneNumber, f => f.Random.Bool() ? f.Phone.PhoneNumber("+855########") : null)
            .RuleFor(c => c.Address, f => f.Random.Bool() ? f.Address.FullAddress() : null)
            .RuleFor(c => c.TaxNumber, f => f.Random.Bool() ? f.Random.Replace("TAX###") : null)
            .RuleFor(c => c.IsActive, true);
    }

    public CustomerFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public CustomerFixtureBuilder WithProvinceId(string? provinceId)
    {
        _provinceId = provinceId;
        return this;
    }

    public CustomerFixtureBuilder WithDistrictId(string? districtId)
    {
        _districtId = districtId;
        return this;
    }

    public CustomerFixtureBuilder WithDependencies(string shopId, string? provinceId, string? districtId)
    {
        _shopId = shopId;
        _provinceId = provinceId;
        _districtId = districtId;
        return this;
    }

    public CustomerFixtureBuilder WithFirstName(string firstName)
    {
        _faker.RuleFor(c => c.FirstName, firstName);
        return this;
    }

    public CustomerFixtureBuilder WithLastName(string? lastName)
    {
        _faker.RuleFor(c => c.LastName, lastName);
        return this;
    }

    public CustomerFixtureBuilder WithFatherName(string? fatherName)
    {
        _faker.RuleFor(c => c.FatherName, fatherName);
        return this;
    }

    public CustomerFixtureBuilder WithEmail(string? email)
    {
        _faker.RuleFor(c => c.Email, email);
        return this;
    }

    public CustomerFixtureBuilder WithPhoneNumber(string? phoneNumber)
    {
        _faker.RuleFor(c => c.PhoneNumber, phoneNumber);
        return this;
    }

    public CustomerFixtureBuilder WithAddress(string? address)
    {
        _faker.RuleFor(c => c.Address, address);
        return this;
    }

    public CustomerFixtureBuilder WithTaxNumber(string? taxNumber)
    {
        _faker.RuleFor(c => c.TaxNumber, taxNumber);
        return this;
    }

    public CustomerFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(c => c.IsActive, isActive);
        return this;
    }

    public CustomerCreateDto Build()
    {
        var customer = _faker.Generate();
        customer.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        customer.ProvinceId = _provinceId;
        customer.DistrictId = _districtId;
        return customer;
    }
}