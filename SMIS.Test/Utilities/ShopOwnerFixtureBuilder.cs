using Bogus;
using SMIS.Application.DTO.ShopOwners;

namespace SMIS.Test.Utilities;

public class ShopOwnerFixtureBuilder
{
    private readonly Faker<ShopOwnerCreateDto> _faker;
    private string? _shopId;
    private string? _userId;

    public ShopOwnerFixtureBuilder()
    {
        _faker = new Faker<ShopOwnerCreateDto>()
            .RuleFor(so => so.FirstName, f => f.Name.FirstName())
            .RuleFor(so => so.LastName, f => f.Name.LastName())
            .RuleFor(so => so.NationalIdCardNumber, f => f.Random.Replace("########"))
            .RuleFor(so => so.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(so => so.Email, f => f.Internet.Email())
            .RuleFor(so => so.Address, f => f.Address.FullAddress())
            .RuleFor(so => so.OwnershipPercentage, f => f.Random.Decimal(1, 100))
            .RuleFor(so => so.IsActive, true)
            .RuleFor(so => so.ProvinceId, f => f.Random.Bool() ? f.Random.Guid().ToString() : null)
            .RuleFor(so => so.DistrictId, f => f.Random.Bool() ? f.Random.Guid().ToString() : null);
    }

    public ShopOwnerFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public ShopOwnerFixtureBuilder WithUserId(string userId)
    {
        _userId = userId;
        return this;
    }

    public ShopOwnerFixtureBuilder WithDependencies(string shopId, string userId)
    {
        _shopId = shopId;
        _userId = userId;
        return this;
    }

    public ShopOwnerFixtureBuilder WithFirstName(string? firstName)
    {
        _faker.RuleFor(so => so.FirstName, firstName);
        return this;
    }

    public ShopOwnerFixtureBuilder WithLastName(string? lastName)
    {
        _faker.RuleFor(so => so.LastName, lastName);
        return this;
    }

    public ShopOwnerFixtureBuilder WithNationalIdCardNumber(string? nationalIdCardNumber)
    {
        _faker.RuleFor(so => so.NationalIdCardNumber, nationalIdCardNumber);
        return this;
    }

    public ShopOwnerFixtureBuilder WithPhoneNumber(string? phoneNumber)
    {
        _faker.RuleFor(so => so.PhoneNumber, phoneNumber);
        return this;
    }

    public ShopOwnerFixtureBuilder WithEmail(string? email)
    {
        _faker.RuleFor(so => so.Email, email);
        return this;
    }

    public ShopOwnerFixtureBuilder WithAddress(string? address)
    {
        _faker.RuleFor(so => so.Address, address);
        return this;
    }

    public ShopOwnerFixtureBuilder WithOwnershipPercentage(decimal ownershipPercentage)
    {
        _faker.RuleFor(so => so.OwnershipPercentage, ownershipPercentage);
        return this;
    }

    public ShopOwnerFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(so => so.IsActive, isActive);
        return this;
    }

    public ShopOwnerFixtureBuilder WithProvinceId(string? provinceId)
    {
        _faker.RuleFor(so => so.ProvinceId, provinceId);
        return this;
    }

    public ShopOwnerFixtureBuilder WithDistrictId(string? districtId)
    {
        _faker.RuleFor(so => so.DistrictId, districtId);
        return this;
    }

    public ShopOwnerCreateDto Build()
    {
        var shopOwner = _faker.Generate();
        shopOwner.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        shopOwner.ApplicationUserId = _userId ?? throw new InvalidOperationException("ApplicationUserId is required");
        return shopOwner;
    }
}