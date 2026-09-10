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
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationCreateCommand(dto)));

        [HttpGet("province/{provinceId}")]
        public async Task<ActionResult<List<ProvinceTranslationDto>>> GetByProvince(string provinceId) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationGetListQuery(provinceId)));

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> GetById(string id) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> Update(string id, ProvinceTranslationDto dto) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationDeleteCommand(id)));
    }
}
