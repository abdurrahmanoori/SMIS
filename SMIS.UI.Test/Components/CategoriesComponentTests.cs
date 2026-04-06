using Bunit;
using FluentAssertions;
using Moq;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.UI.Shared.Components.Pages;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.UI.Test.TestInfrastructure;
using SMIS.UI.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.UI.Test.Components;

public class CategoriesComponentTests : BaseComponentTest
{
    private readonly CategoryDtoFixtureBuilder _builder = new();

    public CategoriesComponentTests(ITestOutputHelper output) : base(output) { }

    // ── helpers ──────────────────────────────────────────────────────────────

    private void SetupGetAll(List<CategoryDto>? items = null)
    {
        var list = items ?? _builder.BuildMany(2);
        var paged = new PagedList<CategoryDto>
        {
            Items = list,
            TotalCount = list.Count,
            PageNumber = 1,
            PageSize = 10
        };

        CategoryServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<CategoryDto>>.SuccessResult(paged));

        CategoryServiceMock
            .Setup(s => s.GetPendingCountAsync())
            .ReturnsAsync(0);
    }

    // ── tests ─────────────────────────────────────────────────────────────────

    [Fact]
    public void Render_OnInitialized_CallsGetAllAndGetPendingCount()
    {
        SetupGetAll();

        RenderComponent<Categories>();

        // Both service calls must happen on init — mirrors the API test pattern of
        // verifying the full flow is triggered, not just that the component renders
        CategoryServiceMock.Verify(s => s.GetAllAsync(1, 10, null), Times.Once);
        CategoryServiceMock.Verify(s => s.GetPendingCountAsync(), Times.Once);
    }

    [Fact]
    public void Render_WhenGetAllFails_DoesNotThrow()
    {
        CategoryServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<CategoryDto>>.FailureResult("Server error"));

        CategoryServiceMock
            .Setup(s => s.GetPendingCountAsync())
            .ReturnsAsync(0);

        var act = () => RenderComponent<Categories>();

        act.Should().NotThrow();
        Log("Component rendered without throwing on service failure");
    }

    [Fact]
    public async Task Delete_WhenConfirmed_CallsDeleteAsync()
    {
        // Arrange
        var category = _builder.WithId("cat-1").Build();
        SetupGetAll([category]);

        CategoryServiceMock
            .Setup(s => s.DeleteAsync("cat-1"))
            .ReturnsAsync(Result<MediatR.Unit>.SuccessResult(MediatR.Unit.Value));

        // Also set up the reload after delete
        CategoryServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<CategoryDto>>.SuccessResult(
                new PagedList<CategoryDto> { Items = [], TotalCount = 0, PageNumber = 1, PageSize = 10 }));

        var cut = RenderComponent<Categories>();

        // Act — Syncfusion SfGrid renders row templates outside bUnit's static DOM,
        // so we invoke the component's @code methods directly via the component instance.
        // This is the correct bUnit pattern for Syncfusion-heavy components.
        await cut.InvokeAsync(() => cut.Instance.OpenDeleteConfirmPublic(category));
        await cut.InvokeAsync(() => cut.Instance.ConfirmDeletePublic());

        // Assert
        CategoryServiceMock.Verify(s => s.DeleteAsync("cat-1"), Times.Once);
        Log($"DeleteAsync called once for category '{category.Name}'");
    }

    [Fact]
    public async Task Sync_WhenTriggered_CallsSyncAsync()
    {
        // Arrange
        SetupGetAll();

        CategoryServiceMock
            .Setup(s => s.SyncAsync())
            .ReturnsAsync(new SyncResult { Success = true, Message = "Synced", SyncedCount = 2 });

        var cut = RenderComponent<Categories>();

        // Act — invoke SyncData directly since the Sync button is inside SfCard
        // which Syncfusion renders via JS interop outside bUnit's static DOM
        await cut.InvokeAsync(() => cut.Instance.SyncDataPublic());

        // Assert
        CategoryServiceMock.Verify(s => s.SyncAsync(), Times.Once);
        Log("SyncAsync called once after SyncData invocation");
    }

    [Fact]
    public async Task Create_WhenSaved_CallsCreateAsync()
    {
        // Arrange
        var newCategory = _builder.Build();
        SetupGetAll();

        CategoryServiceMock
            .Setup(s => s.CreateAsync(It.IsAny<CategoryCreateDto>()))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(newCategory));

        var cut = RenderComponent<Categories>();

        // Act — open add dialog then save
        await cut.InvokeAsync(() => cut.Instance.OpenAddDialogPublic());
        await cut.InvokeAsync(() => cut.Instance.SaveCategoryPublic());

        // Assert
        CategoryServiceMock.Verify(s => s.CreateAsync(It.IsAny<CategoryCreateDto>()), Times.Once);
        Log($"CreateAsync called once for category '{newCategory.Name}'");
    }
}
