using System.Net;
using FluentAssertions;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class CategoryQueryIntegrationTests : BaseIntegrationTest
{
    private readonly CategoryTestDataHelper _dataHelper;

    public CategoryQueryIntegrationTests(
        CustomWebApplicationFactory factory,
        ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new CategoryTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await TokenHelper.SetAuthorizationHeaderAsync();
        await _dataHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task Query_WithNoFilters_ReturnsPagedCategories()
    {
        await CreateCategoryAsync(UniqueName("No filters"), true);

        var paged = await GetQueryAsync(string.Empty);

        paged.Items.Should().NotBeEmpty();
        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(25);
    }

    [Fact]
    public async Task Query_WithPartialNameFilter_IsCaseInsensitive()
    {
        var name = UniqueName("Book");
        var created = await CreateCategoryAsync(name, true);

        var paged = await GetQueryAsync("name=bO&pageSize=100");

        paged.Items.Should().Contain(category => category.Id == created.Id);
        paged.Items.Should().OnlyContain(category =>
            category.Name.Contains("bo", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public async Task Query_WithIdFilter_ReturnsExactMatch()
    {
        var created = await CreateCategoryAsync(UniqueName("Id"), true);

        var paged = await GetQueryAsync($"id={Uri.EscapeDataString(created.Id)}");

        paged.Items.Should().ContainSingle();
        paged.Items.Single().Id.Should().Be(created.Id);
    }

    [Fact]
    public async Task Query_WithPartialId_DoesNotUseContainsMatching()
    {
        var created = await CreateCategoryAsync(UniqueName("Partial Id"), true);
        var partialId = created.Id[..Math.Min(8, created.Id.Length)];

        var paged = await GetQueryAsync($"id={Uri.EscapeDataString(partialId)}");

        paged.Items.Should().BeEmpty();
    }

    [Fact]
    public async Task Query_WithIsActiveTrue_ReturnsOnlyActiveCategories()
    {
        await CreateCategoryAsync(UniqueName("Active"), true);

        var paged = await GetQueryAsync("isActive=true&pageSize=100");

        paged.Items.Should().NotBeEmpty();
        paged.Items.Should().OnlyContain(category => category.IsActive);
    }

    [Fact]
    public async Task Query_WithIsActiveFalse_ReturnsOnlyInactiveCategories()
    {
        await CreateCategoryAsync(UniqueName("Inactive"), false);

        var paged = await GetQueryAsync("isActive=false&pageSize=100");

        paged.Items.Should().NotBeEmpty();
        paged.Items.Should().OnlyContain(category => !category.IsActive);
    }

    [Fact]
    public async Task Query_WithMultipleFilters_UsesAndSemantics()
    {
        var name = UniqueName("Multiple");
        var created = await CreateCategoryAsync(name, false);
        await CreateCategoryAsync(UniqueName("Other"), false);

        var paged = await GetQueryAsync(
            $"name={Uri.EscapeDataString(name)}&isActive=false");

        paged.Items.Should().ContainSingle();
        paged.Items.Single().Id.Should().Be(created.Id);
    }

    [Fact]
    public async Task Query_FirstPage_AppliesRequestedPageSize()
    {
        await CreateCategoriesAsync(3);

        var paged = await GetQueryAsync("pageNumber=1&pageSize=2");

        paged.PageNumber.Should().Be(1);
        paged.PageSize.Should().Be(2);
        paged.Items.Should().HaveCount(2);
    }

    [Fact]
    public async Task Query_PageGreaterThanOne_ReturnsNextDeterministicPage()
    {
        await CreateCategoriesAsync(3);

        var firstPage = await GetQueryAsync("pageNumber=1&pageSize=1");
        var secondPage = await GetQueryAsync("pageNumber=2&pageSize=1");

        firstPage.Items.Should().ContainSingle();
        secondPage.Items.Should().ContainSingle();
        secondPage.PageNumber.Should().Be(2);
        secondPage.Items.Single().Id.Should().NotBe(firstPage.Items.Single().Id);
    }

    [Fact]
    public async Task Query_WithInvalidPageNumber_ReturnsBadRequest()
    {
        var response = await Client.GetAsync(
            $"{ApiEndpoints.Category}/query?pageNumber=0&pageSize=25");
        await LogIfError(response, nameof(Query_WithInvalidPageNumber_ReturnsBadRequest));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public async Task Query_WithInvalidPageSize_ReturnsBadRequest(int pageSize)
    {
        var response = await Client.GetAsync(
            $"{ApiEndpoints.Category}/query?pageNumber=1&pageSize={pageSize}");
        await LogIfError(response, nameof(Query_WithInvalidPageSize_ReturnsBadRequest));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Query_WithNoMatchingRecords_ReturnsEmptyPage()
    {
        var missingName = UniqueName("Missing");

        var paged = await GetQueryAsync(
            $"name={Uri.EscapeDataString(missingName)}");

        paged.Items.Should().BeEmpty();
        paged.TotalCount.Should().Be(0);
        paged.TotalPages.Should().Be(0);
    }

    private async Task<PagedList<CategoryDto>> GetQueryAsync(string queryString)
    {
        var endpoint = $"{ApiEndpoints.Category}/query";
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            endpoint = $"{endpoint}?{queryString}";
        }

        var response = await Client.GetAsync(endpoint);
        await LogIfError(response, nameof(GetQueryAsync));
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        return (await response.Content.ReadFromJsonAsync<PagedList<CategoryDto>>())!;
    }

    private async Task<CategoryDto> CreateCategoryAsync(string name, bool isActive)
    {
        var dto = _dataHelper
            .CreateCategoryBuilder()
            .WithName(name)
            .WithIsActive(isActive)
            .Build();
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Category, dto);
        await LogIfError(response, nameof(CreateCategoryAsync));
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<CategoryDto>())!;
    }

    private async Task CreateCategoriesAsync(int count)
    {
        for (var index = 0; index < count; index++)
        {
            await CreateCategoryAsync(UniqueName($"Page {index}"), true);
        }
    }

    private static string UniqueName(string prefix) =>
        $"{prefix} {Guid.NewGuid():N}";
}
