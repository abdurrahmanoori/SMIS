using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Application.Features.Purchasing.Queries;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers;

/// <summary>
/// Manages purchase orders, receiving stock from suppliers, supplier returns, and cancellation.
/// </summary>
/// <remarks>
/// A purchase order starts as an order record. Stock is added only when receipt lines are posted through the receipts endpoint.
/// </remarks>
[Route("api/[controller]")]
[ApiController]
public sealed class PurchaseOrderController : BaseApiController
{
    /// <summary>
    /// Creates a new purchase order for a supplier.
    /// </summary>
    /// <remarks>
    /// The supplier and products must belong to the selected shop. Creating the order does not add stock yet.
    /// An optional idempotency key can prevent the same order from being created twice after a retry.
    /// </remarks>
    [HttpPost]
    [HasPermission(ApplicationComponentKeys.Purchasing, PermissionAction.Create)]
    public async Task<ActionResult<PurchaseOrderDto>> Create(
        PurchaseOrderCreateDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new PurchaseOrderCreateCommand(dto), cancellationToken);

    /// <summary>
    /// Gets purchase orders visible to the current user.
    /// </summary>
    [HttpGet]
    [HasPermission(ApplicationComponentKeys.Purchasing, PermissionAction.Read)]
    public async Task<ActionResult<PagedListNew<PurchaseOrderDto>>> GetAll(
        [FromQuery] PurchaseOrderQueryCriteria criteria,
        [FromQuery] string[]? columns,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    )
    {
        return await HandleRequest(new PurchaseOrderQuery(new EntityDropdown<PurchaseOrderQueryCriteria>
        {
            Criteria = criteria,
            Columns = columns,
            PageNumber = pageNumber,
            PageSize = pageSize
        }), cancellationToken);
    }

    /// <summary>
    /// Receives some or all remaining items from a purchase order into stock.
    /// </summary>
    /// <remarks>
    /// Each receipt line points to a purchase-order line and can receive up to the quantity still outstanding on that line.
    /// Receiving creates stock batches and purchase-receipt movements, then updates the received quantity and order status.
    /// A cancelled order cannot receive stock. An optional idempotency key can prevent the same receipt from being processed twice.
    /// </remarks>
    [HttpPost("{id}/receipts")]
    [HasPermission(ApplicationComponentKeys.Purchasing, PermissionAction.Update)]
    [HasTaskPermission(ApplicationTaskKeys.ReceivePurchaseOrder)]
    public async Task<ActionResult<PurchaseOrderDto>> Receive(
        string id,
        PurchaseOrderReceiveDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new PurchaseOrderReceiveCommand(id, dto), cancellationToken);

    /// <summary>
    /// Returns previously received purchase-order stock back to the supplier.
    /// </summary>
    /// <remarks>
    /// The selected batch must have been received for the specified purchase-order line. The returned quantity is removed from stock
    /// and recorded as a supplier-return movement. The return cannot exceed the line's net received quantity.
    /// </remarks>
    [HttpPost("{id}/supplier-returns")]
    [HasPermission(ApplicationComponentKeys.Purchasing, PermissionAction.Update)]
    [HasTaskPermission(ApplicationTaskKeys.ProcessPurchaseOrderSupplierReturn)]
    public async Task<ActionResult<PurchaseOrderDto>> SupplierReturn(
        string id,
        PurchaseOrderSupplierReturnDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new PurchaseOrderSupplierReturnCommand(id, dto), cancellationToken);

    /// <summary>
    /// Cancels a purchase order.
    /// </summary>
    /// <remarks>
    /// After cancellation, the order cannot receive more stock. Existing stock movements are not silently removed by cancelling the order.
    /// </remarks>
    [HttpPost("{id}/cancel")]
    [HasPermission(ApplicationComponentKeys.Purchasing, PermissionAction.Update)]
    [HasTaskPermission(ApplicationTaskKeys.CancelPurchaseOrder)]
    public async Task<ActionResult<PurchaseOrderDto>> Cancel(
        string id,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new PurchaseOrderCancelCommand(id), cancellationToken);
}