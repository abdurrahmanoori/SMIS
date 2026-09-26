using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Localization.Commands;
using SMIS.Application.Features.Localization.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages the languages available for translated system content.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : BaseApiController
    {
        /// <summary>
        /// Creates a new language.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<LanguageDto>> Create(
            LanguageCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LanguageCreateCommand(dto)));

        /// <summary>
        /// Gets languages in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<LanguageDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LanguageGetListQuery(pageNumber, pageSize)));

        /// <summary>
        /// Gets one language by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<LanguageDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LanguageGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing language.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<LanguageDto>> Update(
            string id,
            LanguageCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LanguageUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a language.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LanguageDeleteCommand(id)));
    }
}