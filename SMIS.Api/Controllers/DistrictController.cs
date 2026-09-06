using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
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
        [HttpPost]
        public async Task<ActionResult<DistrictDto>> Create(
            DistrictCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<DistrictDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponse(await Mediator.Send(new DistrictGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DistrictDto>> GetById(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<DistrictDto>> Update(
            string id,
            DistrictCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictDeleteCommand(id)));
    }
}