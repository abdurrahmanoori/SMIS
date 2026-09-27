using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.Features.Products.Commands;
using SMIS.Application.Features.Products.Queries;
using SMIS.Api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<ActionResult<ProductDto>> Create(
            ProductCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a product sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client sends its own ID and change time. Older client changes do not overwrite a newer server version.
        /// This endpoint is intended for synchronization, not normal online product creation.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<ProductDto>> SyncCreate(
            ProductSyncCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductSyncCreateCommand(dto)));

        /// <summary>
        /// Gets products in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeCategory</c> to true when category information should be returned with each product.
        /// </remarks>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<PagedList<ProductDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeCategory = false
        )
        {
            return HandleResultResponseOld(
                await Mediator.Send(new ProductGetListQuery(pageNumber, pageSize, includeCategory)));
        }

        /// <summary>
        /// Gets one product by its ID.
        /// </summary>
        /// <remarks>
        /// Set <c>includeCategory</c> to true to include the related category information.
        /// </remarks>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetById(
            string id,
            [FromQuery] bool includeCategory = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductGetByIdQuery(id, includeCategory)));

        /// <summary>
        /// Gets pricing information used when a product is sold on credit.
        /// </summary>
        /// <remarks>
        /// The response gives the product's base unit, the current sell price converted to the base unit,
        /// and the cost from the latest received stock batch. It also tells whether an active sell price exists.
        /// This endpoint only reads pricing and stock information; it does not create a loan or change stock.
        /// </remarks>
        [HttpGet("{id}/loan-info")]
        public async Task<ActionResult<ProductLoanInfoDto>> GetLoanInfo(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductGetLoanInfoQuery(id)));

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDto>> Update(
            string id,
            ProductCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a product update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale offline change is ignored instead of replacing newer server data.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<ProductDto>> SyncUpdate(
            string id,
            ProductSyncUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a product.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductDeleteCommand(id)));

        /// <summary>
        /// Applies a product delete sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client change time is used so an older offline delete does not overwrite newer server data.
        /// </remarks>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<ProductDto>> SyncDelete(
            string id,
            ProductSyncDeleteDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProductSyncDeleteCommand(id, dto)));

    }
}