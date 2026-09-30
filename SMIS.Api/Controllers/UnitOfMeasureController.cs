using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Features.UnitOfMeasures.Commands;
using SMIS.Application.Features.UnitOfMeasures.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

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
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Create)]
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
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Create)]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncCreate(
            UnitOfMeasureSyncCreateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncCreateCommand(dto)));

        /// <summary>
        /// Gets units of measure with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<UnitOfMeasureDto>>> GetAll(
            [FromQuery] UnitOfMeasureQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new UnitOfMeasureQuery(
                new EntityDropdown<UnitOfMeasureQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing unit of measure.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Update)]
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
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Update)]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncUpdate(
            string id,
            UnitOfMeasureSyncUpdateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a unit of measure.
        /// </summary>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Delete)]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureDeleteCommand(id)));

        /// <summary>
        /// Applies a unit-of-measure delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.UnitsOfMeasure, PermissionAction.Delete)]
        public async Task<ActionResult<UnitOfMeasureDto>> SyncDelete(
            string id,
            UnitOfMeasureSyncDeleteDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new UnitOfMeasureSyncDeleteCommand(id, dto)));
    }
}