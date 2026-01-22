using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces.Commands;
using SMIS.Application.Features.Provinces.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : BaseApiController
    {
        private readonly IMediator _mediator;
        public ProvinceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("test")]
        public IActionResult Get()
            {
            throw new Exception("test data from provice controller.");

            }
        [HttpPost]
        public async Task<ActionResult<ProvinceCreateDto>> Create(ProvinceCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new ProvinceCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProvinceDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await _mediator.Send(new ProvinceGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceDto>> GetById(string id) =>
            HandleResultResponse(await _mediator.Send(new ProvinceGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceDto>> Update(string id, ProvinceCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new ProvinceUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await _mediator.Send(new ProvinceDeleteCommand(id)));
    }
}
