using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Features.TranslationKeys.Commands;
using SMIS.Application.Features.TranslationKeys.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationKeyController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<TranslationKeyDto>> Create(TranslationKeyCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<TranslationKeyDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeTranslations = false)
        {
            return HandleResultResponse(await Mediator.Send(new TranslationKeyGetListQuery(pageNumber, pageSize, includeTranslations)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> GetById(string id, [FromQuery] bool includeTranslations = false) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyGetByIdQuery(id, includeTranslations)));

        [HttpPut("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> Update(string id, TranslationKeyCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyDeleteCommand(id)));
    }
}