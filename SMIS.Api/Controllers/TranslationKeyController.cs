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
        public async Task<ActionResult<TranslationKeyCreateDto>> Create(TranslationKeyCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<TranslationKeyDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new TranslationKeyGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> Update(string id, TranslationKeyCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new TranslationKeyDeleteCommand(id)));
    }
}