using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Features.UnitOfMeasures.Commands;
using SMIS.Application.Features.UnitOfMeasures.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureController : BaseApiController
    {

        [HttpPost]
        public async Task<ActionResult<UnitOfMeasureCreateDto>> Create(UnitOfMeasureCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CreateUnitOfMeasureCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<UnitOfMeasureDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new GetUnitOfMeasureListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{publicId}")]
        public async Task<ActionResult<UnitOfMeasureDto>> GetById(string publicId) =>
            HandleResultResponse(await Mediator.Send(new GetUnitOfMeasureByIdQuery(publicId)));

        [HttpPut("{publicId}")]
        public async Task<ActionResult<UnitOfMeasureDto>> Update(string publicId, UnitOfMeasureCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateUnitOfMeasureCommand(publicId, dto)));

        [HttpDelete("{publicId}")]
        public async Task<ActionResult<Unit>> Delete(string publicId) =>
            HandleResultResponse(await Mediator.Send(new DeleteUnitOfMeasureCommand(publicId)));
    }
}
