using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common.Response;
using System.Text.RegularExpressions;

namespace SMIS.Api.Controllers.Base
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;
        public IActionResult HandleResult<T>(Result<T> response)
        {
            try
            {
                if (response.Success && response.Response == null)
                {
                    return NotFound();
                }
                else if (response.Success && response.Response != null)
                {
                    return Ok(response.Response);
                }
                else if (!response.Success && response.Errors != null)
                {
                    return BadRequest(response.Errors);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        public ActionResult<T> HandleResultResponse<T>(Result<T> response)
        {
            try
            {
                if (response.Success && response.Response == null)
                {
                    return NotFound();
                }
                else if (response.Success && response.Response != null)
                {
                    return Ok(response.Response);
                }
                else if (!response.Success && response.Errors != null)
                {
                    return BadRequest(new { Errors = response.Errors });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                //if (ex.InnerException is OracleException oracleException)
                //{
                //    var error = new ValidationError()
                //    {
                //        Code = $"ORA-{oracleException.Number:D4}",
                //        Description = oracleException.Message
                //    };
                //    if (oracleException.Number == 1)
                //    {
                //        var utilService = HttpContext.RequestServices.GetRequiredService<IPCK_UTIL>();
                //        var match = Regex.Match(oracleException.Message, @"\(([^)]*)\)");
                //        if (match.Success)
                //        {
                //            var constraintName = match.Groups[1].Value.Split('.')[1];
                //            var details = utilService.GetConstraintError(constraintName).GetAwaiter().GetResult();
                //            error.Property = details?.ColumnsName;

                //            return BadRequest(new { Errors = details });
                //        }
                //    }
                //    else if (oracleException.Number is > 0 and < 1000 or >= 20000 and <= 20999)
                //    {
                //        return BadRequest(new { Errors = new List<ValidationError>() { error } });
                //    }
                // }

                return BadRequest(/*ex.Message*/);
            }
        }

        public async Task<ActionResult<T>> HandleRequest<T>(IRequest<Result<T>> result)
        {
            return HandleResultResponse(await Mediator.Send(result));
        }

        //public ActionResult<T> HandleResultResponse<T>(Result<T> response)
        //{
        //    try
        //    {
        //        if (response.Success && response.Response == null)
        //        {
        //            return NotFound(response.Errors);
        //        }
        //        else if (!response.Success && response.Errors != null && response.Errors.Any(x => x.Code == DeclareMessage.Duplicate.Code))
        //        {
        //            return Conflict(response.Errors);
        //        }
        //        else if (response.Success && response.Response != null)
        //        {
        //            return Ok(response.Response);
        //        }
        //        else if (!response.Success && response.Errors != null)
        //        {
        //            return BadRequest(response.Errors);
        //        }

        //        else
        //        {
        //            return NotFound(response);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //}

    }
}
