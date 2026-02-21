using Microsoft.Extensions.DependencyInjection;
using SMIS.Infrastructure.Server.Context;
using SMIS.Test.TestInfrastructure;

namespace SMIS.Test.Extensions;

public static class TestCleanupExtensions
{
    public static async Task CleanupDatabaseAsync(this CustomWebApplicationFactory factory)
    {
        using var scope = factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
    }

    public static async Task<T> ExecuteInScopeAsync<T>(this CustomWebApplicationFactory factory, Func<IServiceProvider, Task<T>> operation)
    {
        using var scope = factory.Services.CreateScope();
        return await operation(scope.ServiceProvider);
    }

    public static async Task ExecuteInScopeAsync(this CustomWebApplicationFactory factory, Func<IServiceProvider, Task> operation)
    {
        using var scope = factory.Services.CreateScope();
        await operation(scope.ServiceProvider);
    }
}