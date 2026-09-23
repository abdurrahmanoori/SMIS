using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Features.UnitOfMeasures.Commands;
using SMIS.Application.Features.UnitOfMeasures.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages units of measure, such as piece, kilogram, bottle, or box.
    /// </summary>
    /// <remarks>
    /// Product-specific conversion amounts are stored in ProductUnit. This controller defines the unit names themselves
    /// and also supports offline synchronization.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureController : BaseApiController
    {
        /// <summary>
        /// Creates a new unit of measure.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<UnitOfMeasureDto>> Create(
            UnitOfMeasureCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a unit of measure sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client's ID and change time are used so stale offline data does not overwrite a newer server version.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncCreate(
            UnitOfMeasureSyncCreateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncCreateCommand(dto)));

        /// <summary>
        /// Gets units of measure in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<UnitOfMeasureDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Gets one unit of measure by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing unit of measure.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<UnitOfMeasureDto>> Update(
            string id,
            UnitOfMeasureCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a unit-of-measure update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale client update is ignored instead of replacing newer server data.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncUpdate(
            string id,
            UnitOfMeasureSyncUpdateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a unit of measure.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureDeleteCommand(id)));

        /// <summary>
        /// Applies a unit-of-measure delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncDelete(
            string id,
            UnitOfMeasureSyncDeleteDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncDeleteCommand(id, dto)));

        /// <summary>
        /// Gets unit-of-measure changes made after a given time for offline synchronization.
        /// </summary>
        /// <remarks>
        /// Deleted records can be returned so an offline client can remove them from its local data.
        /// </remarks>
        /// <param name="changedSince">Return units changed after this date and time.</param>
        [HttpGet("pull")]
        public async Task<ActionResult<List<UnitOfMeasureDto>>> Pull(
            [FromQuery] DateTime changedSince
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasurePullQuery(changedSince)));
    }
}