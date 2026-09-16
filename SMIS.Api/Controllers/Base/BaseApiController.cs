using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Controllers.Base;

[ApiController]
/// <summary>
/// Shared controller plumbing for MediatR dispatch and conversion of application
/// Result objects into HTTP responses. Feature controllers should stay thin and
/// delegate business behavior to their command/query handlers.
/// </summary>
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator =>
        // Resolve lazily so controllers do not repeat an IMediator constructor dependency.
        _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();


    private ActionResult<T> HandleResultResponse<T>(
        Result<T> response
    )
    {
        if (response.Success && response.Response == null)
        {
            return NotFound();
        }

        if (response.Success && response.Response != null)
        {
            // if (response.HasMessages)
            // {
            //     response.Messages.ForEach(x => x.SetType(MessageTypeEnum.Warning));
            //     return Ok(new { response.Response, response.Messages });
            // }

            return Ok(response.Response);
        }

        if (!response.Success)
        {
            return BadRequest(new { response.Message });
        }

        return NotFound();
    }

    public async Task<ActionResult<T>> HandleRequest<T>(
        IRequest<Result<T>> result
    )
    {
        return HandleResultResponse(await Mediator.Send(result));
    }

    public async Task<ActionResult<T>> HandleRequest<T>(
        IRequest<Result<T>> result,
        CancellationToken cancellationToken
    )
    {
        return HandleResultResponse(await Mediator.Send(result, cancellationToken));
    }


    protected ActionResult<T> HandleResultResponseOld<T>(
        Result<T> result
    )
    {
        // Legacy response adapter retained for existing controllers. Unlike the newer
        // handler above, it preserves structured validation errors and maps duplicate
        // errors to HTTP 409 Conflict.
        try
        {
            if (result.Success)
            {
                return result.Response is null
                    ? NotFound(result.Errors)
                    : Ok(result.Response);
            }

            if (result.Errors?.Any(error => error.Code == DeclareMessage.Duplicate.Code) == true)
            {
                return Conflict(result.Errors);
            }

            return result.Errors is not null
                ? BadRequest(result.Errors)
                : NotFound(result);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}