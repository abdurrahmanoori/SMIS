using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Localization.Commands;
using SMIS.Application.Features.Localization.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Application.Common.Contants;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages the languages available for translated system content.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [HasCurrentRole(SD.Role_Super_Admin)]
    public class LanguageController : BaseApiController
    {
        /// <summary>
        /// Creates a new language.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<LanguageDto>> Create(
            LanguageCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new LanguageCreateCommand(dto)));

        /// <summary>
        /// Gets languages with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<LanguageDto>>> GetAll(
            [FromQuery] LanguageQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        ) => await HandleRequest(new LanguageQuery(
            new EntityDropdown<LanguageQueryCriteria>
            {
                Criteria = criteria,
                Columns = columns,
                PageNumber = pageNumber,
                PageSize = pageSize
            }), cancellationToken);

        /// <summary>
        /// Updates an existing language.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<LanguageDto>> Update(
            string id,
            LanguageCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new LanguageUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a language.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new LanguageDeleteCommand(id)));
    }
}