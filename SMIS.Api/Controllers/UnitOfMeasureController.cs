using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
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
        public async Task<ActionResult<UnitOfMeasureDto>> Create(UnitOfMeasureCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UnitOfMeasureCreateCommand(dto)));

        [HttpPost("sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncCreate(UnitOfMeasureSyncCreateDto dto) => HandleResultResponse(await Mediator.Send(new UnitOfMeasureSyncCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<UnitOfMeasureDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new UnitOfMeasureGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new UnitOfMeasureGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> Update(string id, UnitOfMeasureCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UnitOfMeasureUpdateCommand(id, dto)));

        [HttpPut("{id}/sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncUpdate(string id, UnitOfMeasureSyncUpdateDto dto) => HandleResultResponse(await Mediator.Send(new UnitOfMeasureSyncUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new UnitOfMeasureDeleteCommand(id)));

        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncDelete(string id, UnitOfMeasureSyncDeleteDto dto) => HandleResultResponse(await Mediator.Send(new UnitOfMeasureSyncDeleteCommand(id, dto)));

        [HttpGet("pull")]
        public async Task<ActionResult<List<UnitOfMeasureDto>>> Pull([FromQuery] DateTime changedSince) => HandleResultResponse(await Mediator.Send(new UnitOfMeasurePullQuery(changedSince)));
    }
}
