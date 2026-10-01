using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Authorization;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.Common.Contants;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces.Commands;
using SMIS.Application.Features.Provinces.Queries;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages provinces used in addresses and location data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [HasCurrentRole(SD.Role_Super_Admin)]
    public class ProvinceController : BaseApiController
    {
        /// <summary>
        /// Deliberately throws an exception to test API error handling.
        /// </summary>
        /// <remarks>
        /// This is a development/testing endpoint. It does not return province data and should not be used as a normal application endpoint.
        /// </remarks>
        [HttpGet("test")]
        public IActionResult Get()
        {
            throw new Exception("test data from provice controller.");
        }

        /// <summary>
        /// Creates a new province.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProvinceDto>> Create(
            ProvinceCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceCreateCommand(dto)));

        /// <summary>
        /// Gets provinces with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<ProvinceDto>>> GetAll(
            [FromQuery] ProvinceQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ProvinceQuery(
                new EntityDropdown<ProvinceQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing province.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceDto>> Update(
            string id,
            ProvinceCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a province.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ProvinceDeleteCommand(id)));
    }
}