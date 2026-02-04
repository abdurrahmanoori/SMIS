using System.Net.Http.Json;
using SMIS.Test.Extensions;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.TestInfrastructure;

public abstract class BaseIntegrationTest : IClassFixture<CustomWebApplicationFactory>, IAsyncLifetime
{
    protected readonly CustomWebApplicationFactory Factory;
    protected readonly HttpClient Client;
    protected readonly ITestOutputHelper Output;
    protected readonly JwtTokenHelper TokenHelper;

    protected BaseIntegrationTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
    {
        Factory = factory;
        Client = factory.CreateClient();
        Output = output;
        TokenHelper = new JwtTokenHelper(Client);
    }

    protected async Task LogIfError(HttpResponseMessage response, string context = "")
    {
        if (response.IsSuccessStatusCode) return;
        
        var errorContent = await response.Content.ReadAsStringAsync();
        Output.WriteLine($"[{context}] Status: {(int)response.StatusCode} {response.StatusCode}");
        
        var formattedError = ExceptionFormatter.FormatApiResponseError(errorContent);
        Output.WriteLine($"[{context}] Formatted Error:\n{formattedError}");
    }

    protected async Task<T?> PostAndGetAsync<T>(string endpoint, object dto, string context = "")
    {
        var response = await Client.PostAsJsonAsync(endpoint, dto);
        await LogIfError(response, context);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }

    protected async Task<T?> GetAsync<T>(string endpoint, string context = "")
    {
        var response = await Client.GetAsync(endpoint);
        await LogIfError(response, context);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }

    protected async Task<HttpResponseMessage> PostAsJsonAsync<T>(string endpoint, T dto) =>
        await Client.PostAsJsonAsync(endpoint, dto);

    protected async Task<HttpResponseMessage> PutAsJsonAsync<T>(string endpoint, T dto) =>
        await Client.PutAsJsonAsync(endpoint, dto);

    public virtual Task InitializeAsync() => Task.CompletedTask;
    public virtual Task DisposeAsync() => Task.CompletedTask;
}