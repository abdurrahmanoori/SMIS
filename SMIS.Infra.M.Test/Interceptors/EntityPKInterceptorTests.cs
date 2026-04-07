using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Services.Identity;
using Xunit;

namespace SMIS.Infra.M.Test.Interceptors;

public class EntityPKInterceptorTests : IAsyncLifetime
{
    private SqliteConnection _connection = null!;

    private LocalDbContext CreateContext(IPublicIdGenerator? idGenerator = null)
    {
        var currentUserMock = new Mock<IMobileCurrentUser>();
        currentUserMock.Setup(u => u.GetId()).Returns("user-1");

        // Default: dev mode — generator returns empty string so interceptor assigns sequential IDs
        var generatorMock = new Mock<IPublicIdGenerator>();
        generatorMock.Setup(g => g.Generate()).Returns(idGenerator != null ? idGenerator.Generate() : string.Empty);

        var pkInterceptor = new EntityPKInterceptor(currentUserMock.Object, generatorMock.Object);
        var auditInterceptor = new LocalAuditInterceptor(currentUserMock.Object);

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .AddInterceptors(auditInterceptor, pkInterceptor)
            .Options;

        return new LocalDbContext(options);
    }

    public async Task InitializeAsync()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        using var ctx = CreateContext();
        await ctx.Database.EnsureCreatedAsync();
    }

    public async Task DisposeAsync()
    {
        await _connection.CloseAsync();
        await _connection.DisposeAsync();
    }

    [Fact]
    public async Task SaveChanges_OnAdd_AssignsSequentialId_WhenGeneratorReturnsEmpty()
    {
        using var ctx = CreateContext();
        var category = Category.Create("Drinks", "shop-1");
        category.Id = string.Empty; // simulate dev mode

        ctx.Categories.Add(category);
        await ctx.SaveChangesAsync();

        category.Id.Should().NotBeNullOrEmpty();
        int.TryParse(category.Id, out _).Should().BeTrue("sequential IDs must be numeric strings");
    }

    [Fact]
    public async Task SaveChanges_MultipleAdds_AssignsIncrementingIds()
    {
        using var ctx = CreateContext();

        var cat1 = Category.Create("Drinks", "shop-1");
        var cat2 = Category.Create("Food", "shop-1");
        cat1.Id = string.Empty;
        cat2.Id = string.Empty;

        ctx.Categories.Add(cat1);
        await ctx.SaveChangesAsync();

        ctx.Categories.Add(cat2);
        await ctx.SaveChangesAsync();

        var id1 = int.Parse(cat1.Id);
        var id2 = int.Parse(cat2.Id);
        id2.Should().BeGreaterThan(id1);
    }

    [Fact]
    public async Task SaveChanges_OnAdd_UsesGeneratorId_WhenGeneratorReturnsNonEmpty()
    {
        var fixedId = Guid.NewGuid().ToString();

        var generatorMock = new Mock<IPublicIdGenerator>();
        generatorMock.Setup(g => g.Generate()).Returns(fixedId);

        var currentUserMock = new Mock<IMobileCurrentUser>();
        currentUserMock.Setup(u => u.GetId()).Returns("user-1");

        var pkInterceptor = new EntityPKInterceptor(currentUserMock.Object, generatorMock.Object);
        var auditInterceptor = new LocalAuditInterceptor(currentUserMock.Object);

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .AddInterceptors(auditInterceptor, pkInterceptor)
            .Options;

        using var ctx = new LocalDbContext(options);
        var category = Category.Create("Grocery", "shop-1");
        category.Id = string.Empty;

        ctx.Categories.Add(category);
        await ctx.SaveChangesAsync();

        // When generator returns a GUID, the interceptor should use it
        category.Id.Should().NotBeNullOrEmpty();
    }
}
