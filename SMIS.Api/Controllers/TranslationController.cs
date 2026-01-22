using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Features.Translations.Commands;
using SMIS.Application.Features.Translations.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<TranslationEntityCreateDto>> Create(TranslationEntityCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<TranslationEntityDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new TranslationGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TranslationEntityDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new TranslationGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<TranslationEntityDto>> Update(string id, TranslationEntityCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new TranslationDeleteCommand(id)));
    }
}