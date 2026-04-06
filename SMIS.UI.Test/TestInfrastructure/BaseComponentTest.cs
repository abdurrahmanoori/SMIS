using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SMIS.UI.Shared.Services.Interfaces;
using Syncfusion.Blazor;
using Xunit.Abstractions;

namespace SMIS.UI.Test.TestInfrastructure;

/// <summary>
/// Base for Blazor component tests using bUnit.
/// Registers mocked service interfaces so components can be rendered in isolation.
/// ITestOutputHelper is injected for diagnostic output, mirroring BaseIntegrationTest.
/// </summary>
public abstract class BaseComponentTest : TestContext
{
    protected readonly Mock<ICategoryService> CategoryServiceMock = new();
    protected readonly Mock<ISyncFacade> SyncFacadeMock = new();
    protected readonly ITestOutputHelper Output;

    protected BaseComponentTest(ITestOutputHelper output)
    {
        Output = output;

        // Register mocks into the bUnit DI container
        Services.AddSingleton(CategoryServiceMock.Object);
        Services.AddSingleton(SyncFacadeMock.Object);

        // Syncfusion components require SyncfusionBlazorService to be registered
        Services.AddSyncfusionBlazor();

        // Syncfusion components rely on JS interop — stub it out so tests don't throw
        JSInterop.Mode = JSRuntimeMode.Loose;
    }

    /// <summary>
    /// Logs a diagnostic message to the test output, mirroring LogIfError in BaseIntegrationTest.
    /// </summary>
    protected void Log(string message) => Output.WriteLine(message);
}
