using MediatR;
using SMIS.Application.Common.Response;

namespace SMIS.UI.Shared.Services.Base;

public abstract class BaseService
{
    protected readonly IMediator Mediator;

    protected BaseService(IMediator mediator)
    {
        Mediator = mediator;
    }

    protected async Task<Result<T>> SendAsync<T>(IRequest<Result<T>> request)
        => await Mediator.Send(request);

    protected static Result<T> NotFound<T>(string id) => Result<T>.NotFoundResult(id);

    protected static Result<T> Failure<T>(string description) => Result<T>.FailureResult(description);
}
