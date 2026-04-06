using FluentAssertions;
using MediatR;
using Moq;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Queries;
using SMIS.UI.Shared.Services.Base;
using SMIS.UI.Test.TestInfrastructure;
using Xunit;

namespace SMIS.UI.Test.Services;

public class BaseServiceTests : BaseServiceTest
{
    /// <summary>
    /// Concrete stub that exposes BaseService protected members for testing.
    /// Nested private so it stays scoped to this test class.
    /// </summary>
    private sealed class StubService : BaseService
    {
        public StubService(IMediator mediator) : base(mediator) { }

        public Task<Result<T>> Send<T>(IRequest<Result<T>> request) => SendAsync(request);

        public Result<T> GetNotFound<T>(string id) => NotFound<T>(id);
        public Result<T> GetFailure<T>(string description) => Failure<T>(description);
    }

    private readonly StubService _sut;

    public BaseServiceTests()
    {
        _sut = new StubService(MediatorMock.Object);
    }

    [Fact]
    public async Task SendAsync_WhenMediatorReturnsSuccess_ReturnsSuccessResult()
    {
        // Arrange
        var expected = new CategoryDto { Id = "1", Name = "Drinks" };
        var query = new CategoryGetByIdQuery("1");

        MediatorMock
            .Setup(m => m.Send(It.IsAny<CategoryGetByIdQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(expected));

        // Act
        var result = await _sut.Send(query);

        // Assert
        result.Success.Should().BeTrue();
        result.Response.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public async Task SendAsync_WhenMediatorReturnsFailure_ReturnsFailureResult()
    {
        // Arrange
        var query = new CategoryGetByIdQuery("999");

        MediatorMock
            .Setup(m => m.Send(It.IsAny<CategoryGetByIdQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Result<CategoryDto>.FailureResult("Category not found"));

        // Act
        var result = await _sut.Send(query);

        // Assert
        result.Success.Should().BeFalse();
        result.Errors.Should().ContainSingle(e => e.Description == "Category not found");
    }

    [Fact]
    public void NotFound_ReturnsFailureResultWithNotFoundMessage()
    {
        var result = _sut.GetNotFound<CategoryDto>("abc-123");

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("abc-123");
    }

    [Fact]
    public void Failure_ReturnsFailureResultWithDescription()
    {
        var result = _sut.GetFailure<CategoryDto>("Something went wrong");

        result.Success.Should().BeFalse();
        result.Errors.Should().ContainSingle(e => e.Description == "Something went wrong");
    }
}
