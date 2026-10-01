using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Errors;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Controllers.Base;

[ApiController]
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator =>
        _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();

    protected ActionResult<T> HandleResultResponse<T>(
        Result<T> result
    )
    {
        if (result.IsSuccess)
            return result.Value is null ? NotFound() : Ok(result.Value);

        return CreateProblemResult<T>(result.Errors);
    }

    protected IActionResult HandleResultResponse(
        Result result
    )
    {
        if (result.IsSuccess)
            return NoContent();

        return CreateProblemResult(result.Errors);
    }

    public async Task<ActionResult<T>> HandleRequest<T>(
        IRequest<Result<T>> request,
        CancellationToken cancellationToken = default
    )
    {
        return HandleResultResponse(await Mediator.Send(request, cancellationToken));
    }

    public async Task<IActionResult> HandleRequest(
        IRequest<Result> request,
        CancellationToken cancellationToken = default
    )
    {
        return HandleResultResponse(await Mediator.Send(request, cancellationToken));
    }

    private ActionResult<T> CreateProblemResult<T>(
        IReadOnlyList<Error> errors
    )
    {
        var problem = ApiProblemDetailsFactory.Create(HttpContext, errors);
        return StatusCode(problem.Status ?? StatusCodes.Status400BadRequest, problem);
    }

    private IActionResult CreateProblemResult(
        IReadOnlyList<Error> errors
    )
    {
        var problem = ApiProblemDetailsFactory.Create(HttpContext, errors);
        return StatusCode(problem.Status ?? StatusCodes.Status400BadRequest, problem);
    }
}