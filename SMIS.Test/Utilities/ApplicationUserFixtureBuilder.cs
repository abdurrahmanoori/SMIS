using Bogus;
using SMIS.Application.DTO.Users;

namespace SMIS.Test.Utilities;

public class ApplicationUserFixtureBuilder
{
    private readonly Faker<UserCreateDto> _faker;
    private string? _shopId;

    public ApplicationUserFixtureBuilder()
    {
        _faker = new Faker<UserCreateDto>()
            .RuleFor(u => u.UserName, f => f.Internet.UserName() + Guid.NewGuid().ToString("N")[..8])
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("+###########"))
            .RuleFor(u => u.Password, f => f.Internet.Password(8, false, "", "Aa1!"))
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.LanguageId, "1")
            .RuleFor(u => u.Roles, f => new[] { "User" });
    }

    public ApplicationUserFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public ApplicationUserFixtureBuilder WithDependencies(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public ApplicationUserFixtureBuilder WithUserName(string userName)
    {
        _faker.RuleFor(u => u.UserName, userName);
        return this;
    }

    public ApplicationUserFixtureBuilder WithEmail(string email)
    {
        _faker.RuleFor(u => u.Email, email);
        return this;
    }

    public ApplicationUserFixtureBuilder WithPhoneNumber(string? phoneNumber)
    {
        _faker.RuleFor(u => u.PhoneNumber, phoneNumber);
        return this;
    }

    public ApplicationUserFixtureBuilder WithPassword(string password)
    {
        _faker.RuleFor(u => u.Password, password);
        return this;
    }

    public ApplicationUserFixtureBuilder WithFirstName(string? firstName)
    {
        _faker.RuleFor(u => u.FirstName, firstName);
        return this;
    }

    public ApplicationUserFixtureBuilder WithLastName(string? lastName)
    {
        _faker.RuleFor(u => u.LastName, lastName);
        return this;
    }

    public ApplicationUserFixtureBuilder WithRoles(IEnumerable<string>? roles)
    {
        _faker.RuleFor(u => u.Roles, roles);
        return this;
    }

    public ApplicationUserFixtureBuilder WithLanguageId(string? languageId)
    {
        _faker.RuleFor(u => u.LanguageId, languageId);
        return this;
    }

    public UserCreateDto Build()
    {
        var user = _faker.Generate();
        user.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        return user;
    }
}