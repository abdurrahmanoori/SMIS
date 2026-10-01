using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Authorization;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.Common.Contants;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Features.Districts.Commands;
using SMIS.Application.Features.Districts.Queries;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages districts used in addresses and location data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [HasCurrentRole(SD.Role_Super_Admin)]
    public class DistrictController : BaseApiController
    {
        /// <summary>
        /// Creates a new district.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<DistrictDto>> Create(
            DistrictCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictCreateCommand(dto)));

        /// <summary>
        /// Gets districts with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<DistrictDto>>> GetAll(
            [FromQuery] DistrictQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new DistrictQuery(
                new EntityDropdown<DistrictQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing district.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<DistrictDto>> Update(
            string id,
            DistrictCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a district.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new DistrictDeleteCommand(id)));
    }
}