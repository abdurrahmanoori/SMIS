using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
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
        [HttpGet("test")]
        public IActionResult Get()
            {
            throw new Exception("test data from provice controller.");

            }
        [HttpPost]
        public async Task<ActionResult<ProvinceDto>> Create(ProvinceCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProvinceCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProvinceDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new ProvinceGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new ProvinceGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceDto>> Update(string id, ProvinceCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProvinceUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new ProvinceDeleteCommand(id)));
    }
}
