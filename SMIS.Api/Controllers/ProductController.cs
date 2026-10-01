using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.Features.Products.Commands;
using SMIS.Application.Features.Products.Queries;
using SMIS.Api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages products and product synchronization for offline clients.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {
        /// <summary>
        /// Creates a new product.
        /// </summary>
        [HttpPost]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Create)]
        public async Task<ActionResult<ProductDto>> Create(
            ProductCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a product sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client sends its own ID and change time. Older client changes do not overwrite a newer server version.
        /// This endpoint is intended for synchronization, not normal online product creation.
        /// </remarks>
        [HttpPost("sync")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Create)]
        public async Task<ActionResult<ProductDto>> SyncCreate(
            ProductSyncCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductSyncCreateCommand(dto)));

        /// <summary>
        /// Gets products with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        /// <remarks>
        /// Set <c>includeCategory</c> to true when category information should be returned with each product.
        /// </remarks>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<ProductDto>>> GetAll(
            [FromQuery] ProductQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeCategory = false,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ProductQuery(
                new EntityDropdown<ProductQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                },
                includeCategory), cancellationToken);
        }

        /// <summary>
        /// Gets pricing information used when a product is sold on credit.
        /// </summary>
        /// <remarks>
        /// The response gives the product's base unit, the current sell price converted to the base unit,
        /// and the cost from the latest received stock batch. It also tells whether an active sell price exists.
        /// This endpoint only reads pricing and stock information; it does not create a loan or change stock.
        /// </remarks>
        [HttpGet("{id}/loan-info")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Read)]
        public async Task<ActionResult<ProductLoanInfoDto>> GetLoanInfo(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductGetLoanInfoQuery(id)));

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Update)]
        public async Task<ActionResult<ProductDto>> Update(
            string id,
            ProductCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a product update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale offline change is ignored instead of replacing newer server data.
        /// </remarks>
        [HttpPut("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Update)]
        public async Task<ActionResult<ProductDto>> SyncUpdate(
            string id,
            ProductSyncUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a product.
        /// </summary>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Delete)]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductDeleteCommand(id)));

        /// <summary>
        /// Applies a product delete sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client change time is used so an older offline delete does not overwrite newer server data.
        /// </remarks>
        [HttpDelete("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Products, PermissionAction.Delete)]
        public async Task<ActionResult<ProductDto>> SyncDelete(
            string id,
            ProductSyncDeleteDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ProductSyncDeleteCommand(id, dto)));
    }
}