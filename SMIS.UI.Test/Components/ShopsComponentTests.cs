using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Enums;
using SMIS.UI.Shared.Components.Pages;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.UI.Test.TestInfrastructure;
using SMIS.UI.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.UI.Test.Components;

public class ShopsComponentTests : BaseComponentTest
{
    private readonly Mock<IShopService> _shopServiceMock = new();
    private readonly ShopDtoFixtureBuilder _builder = new();

    public ShopsComponentTests(ITestOutputHelper output) : base(output)
    {
        // Register ShopServiceMock into the bUnit DI container
        Services.AddSingleton(_shopServiceMock.Object);
    }

    // ── helpers ──────────────────────────────────────────────────────────────

    private void SetupGetAll(List<ShopDto>? items = null)
    {
        var list = items ?? _builder.BuildMany(2);
        var paged = new PagedList<ShopDto>
        {
            Items = list,
            TotalCount = list.Count,
            PageNumber = 1,
            PageSize = 10
        };

        _shopServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<ShopDto>>.SuccessResult(paged));

        _shopServiceMock
            .Setup(s => s.GetPendingCountAsync())
            .ReturnsAsync(0);
    }

    // ── tests ─────────────────────────────────────────────────────────────────

    [Fact]
    public void Render_OnInitialized_CallsGetAllAndGetPendingCount()
    {
        SetupGetAll();

        RenderComponent<Shops>();

        // Both service calls must happen on init
        _shopServiceMock.Verify(s => s.GetAllAsync(1, 10, null), Times.Once);
        _shopServiceMock.Verify(s => s.GetPendingCountAsync(), Times.Once);
    }

    [Fact]
    public void Render_WhenGetAllFails_DoesNotThrow()
    {
        _shopServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<ShopDto>>.FailureResult("Server error"));

        _shopServiceMock
            .Setup(s => s.GetPendingCountAsync())
            .ReturnsAsync(0);

        var act = () => RenderComponent<Shops>();

        act.Should().NotThrow();
        Log("Component rendered without throwing on service failure");
    }

    [Fact]
    public async Task Delete_WhenConfirmed_CallsDeleteAsync()
    {
        // Arrange
        var shop = _builder.WithId("shop-1").WithName("Main Store").Build();
        SetupGetAll([shop]);

        _shopServiceMock
            .Setup(s => s.DeleteAsync("shop-1"))
            .ReturnsAsync(Result<MediatR.Unit>.SuccessResult(MediatR.Unit.Value));

        // Also set up the reload after delete
        _shopServiceMock
            .Setup(s => s.GetAllAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string?>()))
            .ReturnsAsync(Result<PagedList<ShopDto>>.SuccessResult(
                new PagedList<ShopDto> { Items = [], TotalCount = 0, PageNumber = 1, PageSize = 10 }));

        var cut = RenderComponent<Shops>();

        // Act — invoke the component's @code methods directly
        await cut.InvokeAsync(() => cut.Instance.OpenDeleteConfirmPublic(shop));
        await cut.InvokeAsync(() => cut.Instance.ConfirmDeletePublic());

        // Assert
        _shopServiceMock.Verify(s => s.DeleteAsync("shop-1"), Times.Once);
        Log($"DeleteAsync called once for shop '{shop.Name}'");
    }

    [Fact]
    public async Task Sync_WhenTriggered_CallsSyncAsync()
    {
        // Arrange
        SetupGetAll();

        _shopServiceMock
            .Setup(s => s.SyncAsync())
            .ReturnsAsync(new SyncResult { Success = true, Message = "Synced", SyncedCount = 2 });

        var cut = RenderComponent<Shops>();

        // Act — invoke SyncData directly
        await cut.InvokeAsync(() => cut.Instance.SyncDataPublic());

        // Assert
        _shopServiceMock.Verify(s => s.SyncAsync(), Times.Once);
        Log("SyncAsync called once after SyncData invocation");
    }

    [Fact]
    public async Task Create_WhenSaved_CallsCreateAsync()
    {
        // Arrange
        var newShop = _builder.Build();
        SetupGetAll();

        _shopServiceMock
            .Setup(s => s.CreateAsync(It.IsAny<ShopCreateDto>()))
            .ReturnsAsync(Result<ShopDto>.SuccessResult(newShop));

        var cut = RenderComponent<Shops>();

        // Act — open add dialog then save
        await cut.InvokeAsync(() => cut.Instance.OpenAddDialogPublic());
        await cut.InvokeAsync(() => cut.Instance.SaveCategoryPublic());

        // Assert
        _shopServiceMock.Verify(s => s.CreateAsync(It.IsAny<ShopCreateDto>()), Times.Once);
        Log($"CreateAsync called once for shop '{newShop.Name}'");
    }
}
