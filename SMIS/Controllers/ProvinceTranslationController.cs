using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces.Commands;
using SMIS.Application.Features.Provinces.Queries;
using SMIS.Controllers.Base;

namespace SMIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceTranslationController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<ProvinceTranslationDto>> Create(ProvinceTranslationDto dto) =>
            HandleResultResponse(await Mediator.Send(new CreateProvinceTranslationCommand(dto)));

        [HttpGet("province/{provinceId}")]
        public async Task<ActionResult<List<ProvinceTranslationDto>>> GetByProvince(int provinceId) =>
            HandleResultResponse(await Mediator.Send(new GetProvinceTranslationListQuery(provinceId)));

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> GetById(int id) =>
            HandleResultResponse(await Mediator.Send(new GetProvinceTranslationByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> Update(int id, ProvinceTranslationDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateProvinceTranslationCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id) =>
            HandleResultResponse(await Mediator.Send(new DeleteProvinceTranslationCommand(id)));
    }
}
