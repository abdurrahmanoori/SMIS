using FluentAssertions;
using SMIS.Infrastructure.Mobile.Services;
using Xunit;

namespace SMIS.Infra.M.Test.Services;

public class MobilePublicIdGeneratorTests
{
    private readonly MobilePublicIdGenerator _sut = new();

    [Fact]
    public void Generate_InDebugMode_ReturnsEmptyString()
    {
        // In DEBUG builds the generator returns empty string so EntityPKInterceptor
        // assigns sequential numeric IDs — this is the expected dev-mode behaviour.
#if DEBUG
        var result = _sut.Generate();
        result.Should().BeEmpty();
#else
        // In release mode it returns a GUID — skip the empty-string assertion.
        Assert.True(true);
#endif
    }

    [Fact]
    public void Generate_InReleaseMode_ReturnsValidGuid()
    {
#if !DEBUG
        var result = _sut.Generate();
        Guid.TryParse(result, out _).Should().BeTrue("production IDs must be GUIDs for offline-first conflict avoidance");
#else
        // In debug mode the generator intentionally returns empty string — skip GUID assertion.
        Assert.True(true);
#endif
    }

    [Fact]
    public void Generate_CalledMultipleTimes_ReturnsConsistentBehaviour()
    {
        // Regardless of mode, Generate() must never throw and must return a non-null string.
        for (var i = 0; i < 10; i++)
        {
            var result = _sut.Generate();
            result.Should().NotBeNull();
        }
    }
}
