using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Features.ProductUnits.Commands;
using SMIS.Application.Features.ProductUnits.Queries;
using SMIS.Api.Controllers.Base;

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
        public async Task<ActionResult<ProductUnitDto>> Create(
            ProductUnitCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductUnitCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a product unit sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The synchronization request carries the client's ID and change time. Older client changes do not overwrite newer server data.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<ProductUnitDto>> SyncCreate(
            ProductUnitSyncCreateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new ProductUnitSyncCreateCommand(dto)));

        /// <summary>
        /// Gets product units in pages.
        /// </summary>
        /// <remarks>
        /// Use <c>includeProduct</c> and <c>includeUnitOfMeasure</c> when the response should also include those related records.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<PagedList<ProductUnitDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeProduct = false,
            [FromQuery] bool includeUnitOfMeasure = false
        )
        {
            return HandleResultResponseOld(await Mediator.Send(
                new ProductUnitGetListQuery(pageNumber, pageSize, includeProduct, includeUnitOfMeasure)));
        }

        /// <summary>
        /// Searches product units using flexible filters and optional returned columns.
        /// </summary>
        /// <remarks>
        /// This endpoint is useful for dropdowns and filtered lookups. The criteria object controls filtering,
        /// while <c>columns</c> can limit which fields are returned.
        /// </remarks>
        [HttpGet("query")]
        public async Task<ActionResult<PagedListNew<ProductUnitDto>>> Query(
            [FromQuery] ProductUnitQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        ) => await HandleRequest(
            new ProductUnitQuery(
                new EntityDropdown<ProductUnitQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                }),
            cancellationToken);

        /// <summary>
        /// Gets one product unit by its ID.
        /// </summary>
        /// <remarks>
        /// Related product and unit-of-measure information can be included with the two query flags.
        /// </remarks>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductUnitDto>> GetById(
            string id,
            [FromQuery] bool includeProduct = false,
            [FromQuery] bool includeUnitOfMeasure = false
        ) =>
            HandleResultResponseOld(
                await Mediator.Send(new ProductUnitGetByIdQuery(id, includeProduct, includeUnitOfMeasure)));

        /// <summary>
        /// Updates an existing product unit conversion.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProductUnitDto>> Update(
            string id,
            ProductUnitCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductUnitUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a product-unit update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale offline update is ignored instead of replacing newer server data.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<ProductUnitDto>> SyncUpdate(
            string id,
            ProductUnitSyncUpdateDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new ProductUnitSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a product unit.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductUnitDeleteCommand(id)));

        /// <summary>
        /// Applies a product-unit delete sent by an offline client.
        /// </summary>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<ProductUnitDto>> SyncDelete(
            string id,
            ProductUnitSyncDeleteDto dto
        ) => HandleResultResponseOld(await Mediator.Send(new ProductUnitSyncDeleteCommand(id, dto)));

        /// <summary>
        /// Gets product-unit changes made after a given time for offline synchronization.
        /// </summary>
        /// <remarks>
        /// Deleted records can be included so an offline client can remove old product-unit mappings locally.
        /// </remarks>
        /// <param name="changedSince">Return product units changed after this date and time.</param>
        [HttpGet("pull")]
        public async Task<ActionResult<List<ProductUnitDto>>> Pull(
            [FromQuery] DateTime changedSince
        ) => HandleResultResponseOld(await Mediator.Send(new ProductUnitPullQuery(changedSince)));
    }
}