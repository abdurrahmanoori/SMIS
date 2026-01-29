using Bogus;
using SMIS.Application.DTO.Localization;

namespace SMIS.Test.TestDataBuilders
{
    public class LanguageFixtureBuilder
    {
        private readonly Faker<LanguageCreateDto> _faker;

        public LanguageFixtureBuilder()
        {
            _faker = new Faker<LanguageCreateDto>()
                .RuleFor(l => l.Name, f => f.Address.Country())
                .RuleFor(l => l.Code, f => f.Address.CountryCode())
                .RuleFor(l => l.IsActive, true);
        }

        public LanguageFixtureBuilder WithName(string name)
        {
            _faker.RuleFor(l => l.Name, name);
            return this;
        }

        public LanguageFixtureBuilder WithCode(string? code)
        {
            _faker.RuleFor(l => l.Code, code);
            return this;
        }

        public LanguageFixtureBuilder WithIsActive(bool isActive)
        {
            _faker.RuleFor(l => l.IsActive, isActive);
            return this;
        }

        public LanguageCreateDto Build() => _faker.Generate();
    }
}