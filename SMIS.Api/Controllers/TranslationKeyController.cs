using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Features.TranslationKeys.Commands;
using SMIS.Application.Features.TranslationKeys.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages translation keys used to identify translatable system text.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationKeyController : BaseApiController
    {
        /// <summary>
        /// Creates a new translation key.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<TranslationKeyDto>> Create(
            TranslationKeyCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationKeyCreateCommand(dto)));

        /// <summary>
        /// Gets translation keys in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeTranslations</c> to true when the response should also contain the values translated for each key.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<PagedList<TranslationKeyDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeTranslations = false
        )
        {
            return HandleResultResponseOld(
                await Mediator.Send(new TranslationKeyGetListQuery(pageNumber, pageSize, includeTranslations)));
        }

        /// <summary>
        /// Gets one translation key by its ID.
        /// </summary>
        /// <remarks>
        /// Set <c>includeTranslations</c> to true to include its translated values.
        /// </remarks>
        [HttpGet("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> GetById(
            string id,
            [FromQuery] bool includeTranslations = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationKeyGetByIdQuery(id, includeTranslations)));

        /// <summary>
        /// Updates an existing translation key.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<TranslationKeyDto>> Update(
            string id,
            TranslationKeyCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationKeyUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a translation key.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new TranslationKeyDeleteCommand(id)));
    }
}