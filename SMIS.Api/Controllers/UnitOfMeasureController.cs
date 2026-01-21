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

        [HttpGet("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new GetUnitOfMeasureByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> Update(string id, UnitOfMeasureCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateUnitOfMeasureCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new DeleteUnitOfMeasureCommand(id)));
    }
}
