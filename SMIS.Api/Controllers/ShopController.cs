using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Application.Features.Shops.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages shops and shop synchronization for offline clients.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : BaseApiController
    {
        /// <summary>
        /// Creates a new shop.
        /// </summary>
        [HttpPost]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Create)]
        public async Task<ActionResult<ShopDto>> Create(
            ShopCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a shop sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The synchronization version uses the client's ID and change time so older offline data does not replace newer server data.
        /// </remarks>
        [HttpPost("sync")]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Create)]
        public async Task<ActionResult<ShopDto>> SyncCreate(
            ShopSyncCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncCreateCommand(dto)));

        /// <summary>
        /// Gets shops with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<ShopDto>>> GetAll(
            [FromQuery] ShopQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ShopQuery(
                new EntityDropdown<ShopQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing shop.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Update)]
        public async Task<ActionResult<ShopDto>> Update(
            string id,
            ShopUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a shop update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale client update is ignored instead of overwriting a newer server version.
        /// </remarks>
        [HttpPut("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Update)]
        public async Task<ActionResult<ShopDto>> SyncUpdate(
            string id,
            ShopSyncUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a shop.
        /// </summary>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Delete)]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopDeleteCommand(id)));

        /// <summary>
        /// Applies a shop delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Shops, PermissionAction.Delete)]
        public async Task<ActionResult<ShopDto>> SyncDelete(
            string id,
            ShopSyncDeleteDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncDeleteCommand(id, dto)));
    }
}