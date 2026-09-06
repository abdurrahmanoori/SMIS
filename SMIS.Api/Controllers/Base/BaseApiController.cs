using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Controllers.Base;

[ApiController]
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator =>
        _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();

    protected ActionResult<T> HandleResultResponse<T>(Result<T> result)
    {
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
