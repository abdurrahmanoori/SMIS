using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Laboratory;
using SMIS.Application.Features.LabTestGroups.Commands;
using SMIS.Application.Features.LabTestGroups.Queries;
using SMIS.Controllers.Base;

namespace SMIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabTestGroupController : BaseApiController
    {
        private readonly IMediator _mediator;
        public LabTestGroupController(IMediator mediator) { _mediator = mediator; }

        [HttpPost]
        public async Task<ActionResult<LabTestGroupCreateDto>> Create(LabTestGroupCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new CreateLabTestGroupCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<LabTestGroupDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25) =>
            HandleResultResponse(await _mediator.Send(new GetLabTestGroupListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<LabTestGroupDto>> GetById(int id) =>
            HandleResultResponse(await _mediator.Send(new GetLabTestGroupByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<LabTestGroupDto>> Update(int id, LabTestGroupCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new UpdateLabTestGroupCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id) =>
            HandleResultResponse(await _mediator.Send(new DeleteLabTestGroupCommand(id)));
    }
}
