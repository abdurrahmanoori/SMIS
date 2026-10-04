using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces.Commands;
using SMIS.Application.Features.Provinces.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Application.Common.Contants;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages translated province names and other province text.
    /// </summary>
    /// <remarks>
    /// A province can have separate translation records for different languages.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    [HasCurrentRole(SD.Role_Super_Admin)]
    public class ProvinceTranslationController : BaseApiController
    {
        /// <summary>
        /// Creates a translation for a province.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProvinceTranslationDto>> Create(
            ProvinceTranslationDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceTranslationCreateCommand(dto)));

        /// <summary>
        /// Gets province translations with flexible filtering, selected columns, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<ProvinceTranslationDto>>> GetAll(
            [FromQuery] ProvinceTranslationQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ProvinceTranslationQuery(
                new EntityDropdown<ProvinceTranslationQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing province translation.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> Update(
            string id,
            ProvinceTranslationDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceTranslationUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a province translation.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceTranslationDeleteCommand(id)));
    }
}