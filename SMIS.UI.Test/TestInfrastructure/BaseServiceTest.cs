using MediatR;
using Moq;
using SMIS.Application.Common.Response;

namespace SMIS.UI.Test.TestInfrastructure;

/// <summary>
/// Base for service unit tests. Provides a shared IMediator mock
/// and a helper to set up MediatR Send responses without repeating boilerplate.
/// </summary>
public abstract class BaseServiceTest
{
    protected readonly Mock<IMediator> MediatorMock = new();

    /// <summary>
    /// Configures the mediator mock to return the given result for any request of type TRequest.
    /// </summary>
    protected void SetupSend<TRequest, TResponse>(TResponse response)
        where TRequest : IRequest<Result<TResponse>>
    {
        MediatorMock
            .Setup(m => m.Send(It.IsAny<TRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Result<TResponse>.SuccessResult(response));
    }

    /// <summary>
    /// Configures the mediator mock to return a failure result for any request of type TRequest.
    /// </summary>
    protected void SetupSendFailure<TRequest, TResponse>(string message)
        where TRequest : IRequest<Result<TResponse>>
    {
        MediatorMock
            .Setup(m => m.Send(It.IsAny<TRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Result<TResponse>.FailureResult(message));
    }
}
