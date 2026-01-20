using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Features.Districts.Commands;
using SMIS.Application.Features.Districts.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : BaseApiController
    {
        private readonly IMediator _mediator;
        public DistrictController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<DistrictCreateDto>> Create(DistrictCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new CreateDistrictCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<DistrictDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await _mediator.Send(new GetDistrictListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{publicId}")]
        public async Task<ActionResult<DistrictDto>> GetById(string publicId) =>
            HandleResultResponse(await _mediator.Send(new GetDistrictByIdQuery(publicId)));

        [HttpPut("{PublicId}")]
        public async Task<ActionResult<DistrictDto>> Update(string PublicId, DistrictCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new UpdateDistrictCommand(PublicId, dto)));

        [HttpDelete("{publicId}")]
        public async Task<ActionResult<Unit>> Delete(string publicId) =>
            HandleResultResponse(await _mediator.Send(new DeleteDistrictCommand(publicId)));
    }
}