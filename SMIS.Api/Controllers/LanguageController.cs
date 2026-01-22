using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Localization.Commands;
using SMIS.Application.Features.Localization.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<LanguageDto>> Create(LanguageCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new LanguageCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<LanguageDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25) =>
            HandleResultResponse(await Mediator.Send(new LanguageGetListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<LanguageDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new LanguageGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<LanguageDto>> Update(string id, LanguageCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new LanguageUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new LanguageDeleteCommand(id)));
    }
}
