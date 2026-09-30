using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Features.StockBatches.Commands;
using SMIS.Application.Features.StockBatches.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages physical stock batches, including received quantity, cost, batch number, expiration date, and status.
    /// </summary>
    /// <remarks>
    /// Creating a batch is a stock receipt and increases inventory. Later quantity changes are recorded through inventory movements,
    /// not by directly editing the batch balance.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class StockBatchController : BaseApiController
    {
        /// <summary>
        /// Receives stock and creates a new stock batch.
        /// </summary>
        /// <remarks>
        /// The request records the received unit, quantity, cost, batch number, and optional expiration information.
        /// The batch and its opening purchase-receipt movement are saved together. An idempotency key can be used to avoid creating the same receipt twice after a retry.
        /// </remarks>
        [HttpPost]
        [HasPermission(ApplicationComponentKeys.Inventory, PermissionAction.Create)]
        [HasTaskPermission(ApplicationTaskKeys.ReceiveStock)]
        public async Task<ActionResult<StockBatchDto>> Create(
            StockBatchCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchCreateCommand(dto)));

        /// <summary>
        /// Gets stock batches with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.Inventory, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<StockBatchDto>>> GetAll(
            [FromQuery] StockBatchQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        ) => await HandleRequest(new StockBatchQuery(
            new EntityDropdown<StockBatchQueryCriteria>
            {
                Criteria = criteria,
                Columns = columns,
                PageNumber = pageNumber,
                PageSize = pageSize
            }), cancellationToken);

        /// <summary>
        /// Updates stock-batch details or status without directly changing its quantity.
        /// </summary>
        /// <remarks>
        /// Quantity must be changed through inventory movements so the stock history remains traceable.
        /// Batch status rules also prevent invalid changes such as reactivating a cancelled batch.
        /// </remarks>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.Inventory, PermissionAction.Update)]
        public async Task<ActionResult<StockBatchDto>> Update(
            string id,
            StockBatchUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchUpdateCommand(id, dto)));
    }
}