using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Features.Districts.Commands;
using SMIS.Application.Features.Districts.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages districts used in addresses and location data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : BaseApiController
    {
        /// <summary>
        /// Creates a new district.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<DistrictDto>> Create(
            DistrictCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new DistrictCreateCommand(dto)));

        /// <summary>
        /// Gets districts in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<DistrictDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new DistrictGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Gets one district by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<DistrictDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new DistrictGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing district.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<DistrictDto>> Update(
            string id,
            DistrictCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new DistrictUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a district.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new DistrictDeleteCommand(id)));
    }
}