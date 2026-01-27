using AutoFixture;
using SMIS.Application.DTO.Localization;

namespace SMIS.Test.TestDataBuilders
{
    public class LanguageFixtureBuilder
    {
        private readonly Fixture _fixture;
        private LanguageCreateDto _dto;

        public LanguageFixtureBuilder()
        {
            _fixture = new Fixture();
            _fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _dto = _fixture.Build<LanguageCreateDto>()
                .With(x => x.Name, $"Language_{Guid.NewGuid():N}")
                .With(x => x.Code, $"LC_{Guid.NewGuid():N}")
                .With(x => x.IsActive, true)
                .Create();
        }

        public LanguageFixtureBuilder WithName(string name)
        {
            _dto.Name = name;
            return this;
        }

        public LanguageFixtureBuilder WithCode(string? code)
        {
            _dto.Code = code;
            return this;
        }

        public LanguageFixtureBuilder WithIsActive(bool isActive)
        {
            _dto.IsActive = isActive;
            return this;
        }

        public LanguageCreateDto Build()
        {
            return _dto;
        }
    }
}