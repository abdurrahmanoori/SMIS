using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Repositories;
using SMIS.Infrastructure.Mobile.Repositories.Base;
using SMIS.Infrastructure.Mobile.Repositories.Localization;
using SMIS.Infrastructure.Mobile.Services;
using Xunit;

namespace SMIS.Infra.M.Test.Services;

public class MobileTranslationServiceTests : IAsyncLifetime
{
    private SqliteConnection _connection = null!;

    private (MobileTranslationService Service, LocalDbContext Context) CreateSut()
    {
        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .Options;

        var ctx = new LocalDbContext(options);
        var translationKeyRepo = new LocalTranslationKeyRepository(ctx);
        var translationRepo = new LocalGenericRepository<Translation>(ctx);
        var unitOfWork = new LocalUnitOfWork(ctx);

        var service = new MobileTranslationService(translationKeyRepo, translationRepo, unitOfWork);
        return (service, ctx);
    }

    public async Task InitializeAsync()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        var options = new DbContextOptionsBuilder<LocalDbContext>().UseSqlite(_connection).Options;
        using var ctx = new LocalDbContext(options);
        await ctx.Database.EnsureCreatedAsync();
    }

    public async Task DisposeAsync()
    {
        await _connection.CloseAsync();
        await _connection.DisposeAsync();
    }

    [Fact]
    public async Task CreateTranslationKeyAsync_NewKey_CreatesAndReturnsKey()
    {
        var (sut, _) = CreateSut();

        var key = await sut.CreateTranslationKeyAsync("category.drinks");

        key.Should().NotBeNull();
        key.Name.Should().Be("category.drinks");
        key.IsActive.Should().BeTrue();
    }

    [Fact]
    public async Task CreateTranslationKeyAsync_DuplicateKey_ReturnsExistingKey()
    {
        var (sut, _) = CreateSut();

        var first = await sut.CreateTranslationKeyAsync("category.food");
        var second = await sut.CreateTranslationKeyAsync("category.food");

        second.Id.Should().Be(first.Id);
    }

    [Fact]
    public async Task AddTranslationAsync_NewTranslation_CreatesTranslation()
    {
        var (sut, ctx) = CreateSut();

        var translation = await sut.AddTranslationAsync("category.drinks", "en", "Drinks");

        translation.Should().NotBeNull();
        translation.Name.Should().Be("Drinks");
        translation.LanguageNo.Should().Be("en");
    }

    [Fact]
    public async Task AddTranslationAsync_ExistingTranslation_UpdatesValue()
    {
        var (sut, _) = CreateSut();

        await sut.AddTranslationAsync("category.drinks", "en", "Drinks");
        var updated = await sut.AddTranslationAsync("category.drinks", "en", "Beverages");

        updated.Name.Should().Be("Beverages");
    }

    [Fact]
    public async Task GetTranslationAsync_ExistingKeyAndLanguage_ReturnsTranslatedValue()
    {
        var (sut, _) = CreateSut();
        await sut.AddTranslationAsync("category.food", "fa", "خوراکی");

        var result = await sut.GetTranslationAsync("category.food", "fa");

        result.Should().Be("خوراکی");
    }

    [Fact]
    public async Task GetTranslationAsync_MissingTranslation_ReturnsFallbackKeyValue()
    {
        var (sut, _) = CreateSut();

        // No translation seeded — service must fall back to the key itself
        var result = await sut.GetTranslationAsync("category.unknown", "en");

        result.Should().Be("category.unknown");
    }

    [Fact]
    public async Task AddTranslationAsync_DifferentLanguages_StoresSeparately()
    {
        var (sut, _) = CreateSut();

        await sut.AddTranslationAsync("category.drinks", "en", "Drinks");
        await sut.AddTranslationAsync("category.drinks", "fa", "نوشیدنی");

        var en = await sut.GetTranslationAsync("category.drinks", "en");
        var fa = await sut.GetTranslationAsync("category.drinks", "fa");

        en.Should().Be("Drinks");
        fa.Should().Be("نوشیدنی");
    }
}
