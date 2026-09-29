using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Features.ProductPrices.Commands;
using SMIS.Application.Features.ProductPrices.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers;

/// <summary>
/// Manages selling prices for product units, including prices with effective and end dates.
/// </summary>
/// <remarks>
/// A product can have different prices for different units, such as a piece, box, or carton.
/// This controller also supports offline synchronization of price changes.
/// </remarks>
[Route("api/[controller]")]
[ApiController]
public class ProductPriceController : BaseApiController
{
    /// <summary>
    /// Creates a selling price for a product unit.
    /// </summary>
    [HttpPost]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Create)]
    public async Task<ActionResult<ProductPriceDto>> Create(
        ProductPriceCreateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new ProductPriceCreateCommand(dto)));

    /// <summary>
    /// Creates or updates a product price sent by an offline client.
    /// </summary>
    /// <remarks>
    /// The synchronization version uses the client's ID and change time. Older client data does not overwrite a newer server version.
    /// </remarks>
    [HttpPost("sync")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Create)]
    public async Task<ActionResult<ProductPriceDto>> SyncCreate(
        ProductPriceSyncCreateDto dto
    ) => HandleResultResponseOld(await Mediator.Send(new ProductPriceSyncCreateCommand(dto)));

    /// <summary>
    /// Searches product prices using flexible filters and optional returned columns.
    /// </summary>
    [HttpGet("query")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Read)]
    public async Task<ActionResult<PagedListNew<ProductPriceDto>>> Query(
        [FromQuery] ProductPriceQueryCriteria criteria,
        [FromQuery] string[]? columns,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    )
    {
        return await HandleRequest(new ProductPriceQuery(
            new EntityDropdown<ProductPriceQueryCriteria>
            {
                Criteria = criteria,
                Columns = columns,
                PageNumber = pageNumber,
                PageSize = pageSize
            }), cancellationToken);
    }

    /// <summary>
    /// Updates an existing product price.
    /// </summary>
    [HttpPut("{id}")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Update)]
    public async Task<ActionResult<ProductPriceDto>> Update(
        string id,
        ProductPriceCreateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new ProductPriceUpdateCommand(id, dto)));

    /// <summary>
    /// Applies a product-price update sent by an offline client.
    /// </summary>
    /// <remarks>
    /// A stale offline change is ignored instead of replacing newer server data.
    /// </remarks>
    [HttpPut("{id}/sync")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Update)]
    public async Task<ActionResult<ProductPriceDto>> SyncUpdate(
        string id,
        ProductPriceSyncUpdateDto dto
    ) => HandleResultResponseOld(await Mediator.Send(new ProductPriceSyncUpdateCommand(id, dto)));

    /// <summary>
    /// Deletes a product price.
    /// </summary>
    [HttpDelete("{id}")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Delete)]
    public async Task<ActionResult<Unit>> Delete(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new ProductPriceDeleteCommand(id)));

    /// <summary>
    /// Applies a product-price delete sent by an offline client.
    /// </summary>
    [HttpDelete("{id}/sync")]
    [HasPermission(ApplicationComponentKeys.ProductPrices, PermissionAction.Delete)]
    public async Task<ActionResult<ProductPriceDto>> SyncDelete(
        string id,
        ProductPriceSyncDeleteDto dto
    ) => HandleResultResponseOld(await Mediator.Send(new ProductPriceSyncDeleteCommand(id, dto)));

}