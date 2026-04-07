using FluentAssertions;
using SMIS.Domain.Entities;
using SMIS.Infra.M.Test.TestInfrastructure;
using SMIS.Infra.M.Test.Utilities;
using SMIS.Infrastructure.Mobile.Repositories.Categories;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Infra.M.Test.Repositories;

public class LocalCategoryRepositoryTests : BaseLocalDbTest
{
    public LocalCategoryRepositoryTests(LocalDbContextFactory dbFactory, ITestOutputHelper output)
        : base(dbFactory, output) { }

    private async Task<Category> SeedCategoryAsync(CategoryFixtureBuilder? builder = null)
    {
        using var ctx = CreateContext();
        var category = (builder ?? new CategoryFixtureBuilder()).Build();
        var repo = new LocalCategoryRepository(ctx);
        await repo.AddAsync(category);
        await ctx.SaveChangesAsync();
        return category;
    }

    [Fact]
    public async Task AddAsync_ValidCategory_PersistsToDatabase()
    {
        using var ctx = CreateContext();
        var category = new CategoryFixtureBuilder().WithName("Drinks").Build();
        var repo = new LocalCategoryRepository(ctx);

        await repo.AddAsync(category);
        await ctx.SaveChangesAsync();

        var saved = await repo.GetByIdAsync(category.Id);
        saved.Should().NotBeNull();
        saved!.Name.Should().Be("Drinks");
    }

    [Fact]
    public async Task GetByIdAsync_ExistingId_ReturnsCategory()
    {
        var seeded = await SeedCategoryAsync();

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var result = await repo.GetByIdAsync(seeded.Id);

        result.Should().NotBeNull();
        result!.Id.Should().Be(seeded.Id);
        result.Name.Should().Be(seeded.Name);
    }

    [Fact]
    public async Task GetByIdAsync_NonExistingId_ReturnsNull()
    {
        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var result = await repo.GetByIdAsync("non-existing-id");

        result.Should().BeNull();
    }

    [Fact]
    public async Task GetAllAsync_ReturnsAllCategories()
    {
        await SeedCategoryAsync(new CategoryFixtureBuilder().WithName("Cat-A"));
        await SeedCategoryAsync(new CategoryFixtureBuilder().WithName("Cat-B"));

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var all = await repo.GetAllAsync();

        // Seed data from CategorySeed + our 2 = at least 2
        all.Should().NotBeEmpty();
    }

    [Fact]
    public async Task UpdateAsync_ChangesName_PersistsUpdate()
    {
        var seeded = await SeedCategoryAsync(new CategoryFixtureBuilder().WithName("Original"));

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);
        var tracked = await repo.GetByIdAsync(seeded.Id);
        tracked!.SetName("Updated");
        await repo.UpdateAsync(tracked);
        await ctx.SaveChangesAsync();

        using var verifyCtx = CreateContext();
        var verifyRepo = new LocalCategoryRepository(verifyCtx);
        var result = await verifyRepo.GetByIdAsync(seeded.Id);
        result!.Name.Should().Be("Updated");
    }

    [Fact]
    public async Task RemoveAsync_ExistingCategory_DeletesFromDatabase()
    {
        var seeded = await SeedCategoryAsync();

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);
        var tracked = await repo.GetByIdAsync(seeded.Id);
        await repo.RemoveAsync(tracked!);
        await ctx.SaveChangesAsync();

        using var verifyCtx = CreateContext();
        var verifyRepo = new LocalCategoryRepository(verifyCtx);
        var result = await verifyRepo.GetByIdAsync(seeded.Id);
        result.Should().BeNull();
    }

    [Fact]
    public async Task ExistsAsync_ExistingId_ReturnsTrue()
    {
        var seeded = await SeedCategoryAsync();

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var exists = await repo.ExistsAsync(seeded.Id);

        exists.Should().BeTrue();
    }

    [Fact]
    public async Task ExistsAsync_NonExistingId_ReturnsFalse()
    {
        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var exists = await repo.ExistsAsync("ghost-id");

        exists.Should().BeFalse();
    }

    [Fact]
    public async Task GetFirstOrDefaultAsync_WithMatchingFilter_ReturnsEntity()
    {
        var seeded = await SeedCategoryAsync(new CategoryFixtureBuilder().WithName("UniqueNameXYZ"));

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var result = await repo.GetFirstOrDefaultAsync(c => c.Name == "UniqueNameXYZ");

        result.Should().NotBeNull();
        result!.Id.Should().Be(seeded.Id);
    }

    [Fact]
    public async Task GetFirstOrDefaultAsync_WithNoMatch_ReturnsNull()
    {
        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var result = await repo.GetFirstOrDefaultAsync(c => c.Name == "DoesNotExist");

        result.Should().BeNull();
    }

    [Fact]
    public async Task AnyAsync_WhenMatchExists_ReturnsTrue()
    {
        var seeded = await SeedCategoryAsync(new CategoryFixtureBuilder().WithShopId("shop-99"));

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var any = await repo.AnyAsync(c => c.ShopId == "shop-99");

        any.Should().BeTrue();
    }

    [Fact]
    public async Task AnyAsync_WhenNoMatch_ReturnsFalse()
    {
        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var any = await repo.AnyAsync(c => c.ShopId == "shop-does-not-exist");

        any.Should().BeFalse();
    }

    [Fact]
    public async Task GetAllAsync_WithFilter_ReturnsOnlyMatchingEntities()
    {
        await SeedCategoryAsync(new CategoryFixtureBuilder().WithShopId("shop-filter").WithName("FilterA"));
        await SeedCategoryAsync(new CategoryFixtureBuilder().WithShopId("shop-filter").WithName("FilterB"));
        await SeedCategoryAsync(new CategoryFixtureBuilder().WithShopId("shop-other").WithName("Other"));

        using var ctx = CreateContext();
        var repo = new LocalCategoryRepository(ctx);

        var results = await repo.GetAllAsync(c => c.ShopId == "shop-filter");

        results.Should().HaveCount(2);
        results.Should().OnlyContain(c => c.ShopId == "shop-filter");
    }
}
