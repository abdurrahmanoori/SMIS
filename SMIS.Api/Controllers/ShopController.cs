using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Application.Features.Shops.Queries;
using SMIS.Api.Controllers.Base;

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
        public async Task<ActionResult<ShopDto>> Create(
            ShopCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a shop sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The synchronization version uses the client's ID and change time so older offline data does not replace newer server data.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<ShopDto>> SyncCreate(
            ShopSyncCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopSyncCreateCommand(dto)));

        /// <summary>
        /// Gets shops in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<ShopDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new ShopGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Gets one shop by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing shop.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ShopDto>> Update(
            string id,
            ShopUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a shop update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale client update is ignored instead of overwriting a newer server version.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<ShopDto>> SyncUpdate(
            string id,
            ShopSyncUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a shop.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopDeleteCommand(id)));

        /// <summary>
        /// Applies a shop delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<ShopDto>> SyncDelete(
            string id,
            ShopSyncDeleteDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopSyncDeleteCommand(id, dto)));

    }
}