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
            HandleResultResponse(await Mediator.Send(new CreateLanguageCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<LanguageDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25) =>
            HandleResultResponse(await Mediator.Send(new GetLanguageListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<LanguageDto>> GetById(Guid id) =>
            HandleResultResponse(await Mediator.Send(new GetLanguageByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<LanguageDto>> Update(Guid id, LanguageCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateLanguageCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id) =>
            HandleResultResponse(await Mediator.Send(new DeleteLanguageCommand(id)));
    }
}
