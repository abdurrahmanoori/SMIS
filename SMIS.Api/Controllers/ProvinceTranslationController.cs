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
    public class ProvinceTranslationController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<ProvinceTranslationDto>> Create(ProvinceTranslationDto dto) =>
            HandleResultResponse(await Mediator.Send(new CreateProvinceTranslationCommand(dto)));

        [HttpGet("province/{provinceId}")]
        public async Task<ActionResult<List<ProvinceTranslationDto>>> GetByProvince(Guid provinceId) =>
            HandleResultResponse(await Mediator.Send(new GetProvinceTranslationListQuery(provinceId)));

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> GetById(Guid id) =>
            HandleResultResponse(await Mediator.Send(new GetProvinceTranslationByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> Update(Guid id, ProvinceTranslationDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateProvinceTranslationCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id) =>
            HandleResultResponse(await Mediator.Send(new DeleteProvinceTranslationCommand(id)));
    }
}
