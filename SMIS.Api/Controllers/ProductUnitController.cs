using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Features.ProductUnits.Commands;
using SMIS.Application.Features.ProductUnits.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages the units a product can be sold or received in, such as pieces, boxes, or cartons.
    /// </summary>
    /// <remarks>
    /// Each product unit stores how many base units it represents. This controller also supports offline synchronization.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductUnitController : BaseApiController
    {
        /// <summary>
        /// Creates a unit conversion for a product.
        /// </summary>
        [HttpPost]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Create)]
        public async Task<ActionResult<ProductUnitDto>> Create(
            ProductUnitCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a product unit sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The synchronization request carries the client's ID and change time. Older client changes do not overwrite newer server data.
        /// </remarks>
        [HttpPost("sync")]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Create)]
        public async Task<ActionResult<ProductUnitDto>> SyncCreate(
            ProductUnitSyncCreateDto dto
        ) => HandleResultResponse(await Mediator.Send(new ProductUnitSyncCreateCommand(dto)));

        /// <summary>
        /// Gets product units with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        /// <remarks>
        /// Use <c>includeProduct</c> and <c>includeUnitOfMeasure</c> when the response should also include those related records.
        /// </remarks>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<ProductUnitDto>>> GetAll(
            [FromQuery] ProductUnitQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeProduct = false,
            [FromQuery] bool includeUnitOfMeasure = false,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ProductUnitQuery(
                new EntityDropdown<ProductUnitQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                },
                includeProduct,
                includeUnitOfMeasure), cancellationToken);
        }

        /// <summary>
        /// Updates an existing product unit conversion.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Update)]
        public async Task<ActionResult<ProductUnitDto>> Update(
            string id,
            ProductUnitCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a product-unit update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale offline update is ignored instead of replacing newer server data.
        /// </remarks>
        [HttpPut("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Update)]
        public async Task<ActionResult<ProductUnitDto>> SyncUpdate(
            string id,
            ProductUnitSyncUpdateDto dto
        ) => HandleResultResponse(await Mediator.Send(new ProductUnitSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a product unit.
        /// </summary>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Delete)]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitDeleteCommand(id)));

        /// <summary>
        /// Applies a product-unit delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.ProductUnits, PermissionAction.Delete)]
        public async Task<ActionResult<ProductUnitDto>> SyncDelete(
            string id,
            ProductUnitSyncDeleteDto dto
        ) => HandleResultResponse(await Mediator.Send(new ProductUnitSyncDeleteCommand(id, dto)));
    }
}