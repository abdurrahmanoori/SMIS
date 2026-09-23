using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Features.Translations.Commands;
using SMIS.Application.Features.Translations.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages translated values stored for system translation keys.
    /// </summary>
    /// <remarks>
    /// Translation keys define what text is being translated. Translation records store the value for a language.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : BaseApiController
    {
        /// <summary>
        /// Creates a translated value.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<TranslationEntityDto>> Create(
            TranslationEntityCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationCreateCommand(dto)));

        /// <summary>
        /// Gets translated values in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<TranslationEntityDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new TranslationGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Gets one translated value by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<TranslationEntityDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing translated value.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<TranslationEntityDto>> Update(
            string id,
            TranslationEntityCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a translated value.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationDeleteCommand(id)));
    }
}