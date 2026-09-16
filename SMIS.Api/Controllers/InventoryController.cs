using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.DTO.Inventory;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.Inventory.Commands;
using SMIS.Application.Features.Inventory.Queries;
using SMIS.Application.Features.StockBatches.Commands;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers;

/// <summary>
/// Handles stock receipts, returns, damage, expiration, adjustments, transfers, stock counts, and inventory reports.
/// </summary>
/// <remarks>
/// Stock-changing endpoints record inventory movements instead of directly editing batch balances. This keeps a history of why stock moved in or out.
/// Some endpoints change inventory only, while sale and purchase-order endpoints also update their related business records.
/// </remarks>
[Route("api/inventory")]
[ApiController]
public sealed class InventoryController : BaseApiController
{
    /// <summary>
    /// Receives stock directly and creates a new stock batch.
    /// </summary>
    /// <remarks>
    /// This is a direct inventory receipt. If the stock is being received against a purchase order, use
    /// <c>POST /api/PurchaseOrder/{id}/receipts</c> so the purchase-order quantities and status are also updated.
    /// </remarks>
    [HttpPost("purchase-receipts")]
    public async Task<ActionResult<StockBatchDto>> ReceivePurchase(
        StockBatchCreateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockBatchCreateCommand(dto)));

    /// <summary>
    /// Adds returned stock back into a specific batch without updating a sale.
    /// </summary>
    /// <remarks>
    /// This endpoint records an inventory customer-return movement only. For a return that belongs to an existing sale,
    /// use <c>POST /api/Sale/{id}/returns</c> so the sale totals, returnable quantities, refunds, and credit balance are also updated.
    /// </remarks>
    [HttpPost("customer-returns")]
    public async Task<ActionResult<StockMovementDto>> CustomerReturn(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.In,
            StockMovementReason.CustomerReturn)));

    /// <summary>
    /// Removes stock from a specific batch as a supplier return without updating a purchase order.
    /// </summary>
    /// <remarks>
    /// This endpoint changes inventory only. If the return belongs to a purchase order, use
    /// <c>POST /api/PurchaseOrder/{id}/supplier-returns</c> so the purchase-order line is also updated and validated.
    /// </remarks>
    [HttpPost("supplier-returns")]
    public async Task<ActionResult<StockMovementDto>> SupplierReturn(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.SupplierReturn)));

    /// <summary>
    /// Removes damaged quantity from a stock batch.
    /// </summary>
    /// <remarks>
    /// The quantity is recorded as an outgoing damage movement, leaving an audit trail of the stock loss.
    /// </remarks>
    [HttpPost("damaged-stock")]
    public async Task<ActionResult<StockMovementDto>> Damage(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.Damage)));

    /// <summary>
    /// Removes expired quantity from a stock batch.
    /// </summary>
    /// <remarks>
    /// This posts an outgoing expiration movement. The expired-stock report only identifies expired stock; it does not automatically post this movement.
    /// </remarks>
    [HttpPost("expired-stock")]
    public async Task<ActionResult<StockMovementDto>> Expire(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.Expiration)));

    /// <summary>
    /// Manually increases or decreases stock in a specific batch.
    /// </summary>
    /// <remarks>
    /// Use adjustments for controlled corrections when the real stock balance must be changed outside a normal sale, receipt, return, or transfer workflow.
    /// The request direction decides whether stock moves in or out.
    /// </remarks>
    [HttpPost("adjustments")]
    public async Task<ActionResult<StockMovementDto>> Adjust(
        InventoryAdjustmentDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            dto.Direction,
            StockMovementReason.Adjustment)));

    /// <summary>
    /// Transfers stock from one shop or batch location to another.
    /// </summary>
    /// <remarks>
    /// A transfer records both sides of the move as one operation: stock leaves the source and enters the destination.
    /// The destination keeps the same product, cost, batch number, and expiration information needed to trace the transferred stock.
    /// </remarks>
    [HttpPost("transfers")]
    public async Task<ActionResult<List<StockMovementDto>>> Transfer(
        InventoryTransferDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryTransferCommand(dto)));

    /// <summary>
    /// Checks whether each stored batch balance matches the balance calculated from its movement history.
    /// </summary>
    /// <remarks>
    /// The stock batch stores a current remaining quantity for fast reads, while stock movements are the history of all changes.
    /// Reconciliation compares the two. Use <c>onlyMismatches=true</c> to return only batches where the values do not agree.
    /// </remarks>
    /// <param name="stockBatchId">Optional batch ID. Leave empty to check all visible batches.</param>
    /// <param name="onlyMismatches">When true, returns only batches with a balance difference.</param>
    [HttpGet("reconciliation")]
    public async Task<ActionResult<List<InventoryReconciliationDto>>> Reconcile(
        [FromQuery] string? stockBatchId = null,
        [FromQuery] bool onlyMismatches = false
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryReconciliationQuery(stockBatchId, onlyMismatches)));

    /// <summary>
    /// Starts a physical stock count and saves the expected quantity for each selected batch.
    /// </summary>
    /// <remarks>
    /// The saved quantities form a snapshot. You can count all available batches or provide specific batch IDs.
    /// No stock is changed when the count is started.
    /// </remarks>
    [HttpPost("stock-counts")]
    public async Task<ActionResult<StockCountSessionDto>> StartStockCount(
        StockCountStartDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountStartCommand(dto)));

    /// <summary>
    /// Completes a physical stock count and posts adjustments for any differences.
    /// </summary>
    /// <remarks>
    /// Every batch from the original count must be submitted exactly once. Before posting adjustments, the system checks that stock did not change after the count started.
    /// If a batch changed during the count, completion is rejected so the user can restart or recount instead of applying an unsafe adjustment.
    /// An idempotency key can protect against processing the same completion twice.
    /// </remarks>
    [HttpPost("stock-counts/{id}/complete")]
    public async Task<ActionResult<StockCountSessionDto>> CompleteStockCount(
        string id,
        StockCountCompleteDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountCompleteCommand(id, dto)));

    /// <summary>
    /// Gets one physical stock-count session and its batch lines.
    /// </summary>
    [HttpGet("stock-counts/{id}")]
    public async Task<ActionResult<StockCountSessionDto>> GetStockCount(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountGetByIdQuery(id)));

    /// <summary>
    /// Cancels a physical stock count without posting quantity adjustments.
    /// </summary>
    [HttpPost("stock-counts/{id}/cancel")]
    public async Task<ActionResult<StockCountSessionDto>> CancelStockCount(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountCancelCommand(id)));

    /// <summary>
    /// Gets the current stock position for products visible to the current user.
    /// </summary>
    /// <remarks>
    /// The report shows total quantity, available quantity, unavailable quantity, batch count, inventory value, and reorder settings.
    /// Available quantity excludes cancelled, inactive, and expired stock. If no threshold is supplied, each product's reorder point is used to decide whether it is low stock.
    /// </remarks>
    /// <param name="lowStockThresholdBase">Optional threshold that replaces each product's reorder point for this report.</param>
    /// <param name="includePresentationUnits">When true, also shows equivalent quantities in configured product units.</param>
    [HttpGet("reports/current-stock")]
    public async Task<ActionResult<List<CurrentStockReportDto>>> CurrentStock(
        [FromQuery] decimal? lowStockThresholdBase = null,
        [FromQuery] bool includePresentationUnits = true
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryCurrentStockQuery(lowStockThresholdBase, false, includePresentationUnits)));

    /// <summary>
    /// Gets only products whose available stock is at or below the low-stock threshold.
    /// </summary>
    /// <remarks>
    /// If <c>thresholdBase</c> is not supplied, each product uses its own reorder point. Available stock excludes expired and unavailable batches.
    /// </remarks>
    /// <param name="thresholdBase">Optional threshold to use for every product instead of its configured reorder point.</param>
    /// <param name="includePresentationUnits">When true, also shows equivalent quantities in configured product units.</param>
    [HttpGet("reports/low-stock")]
    public async Task<ActionResult<List<CurrentStockReportDto>>> LowStock(
        [FromQuery] decimal? thresholdBase = null,
        [FromQuery] bool includePresentationUnits = true
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryCurrentStockQuery(thresholdBase, true, includePresentationUnits)));

    /// <summary>
    /// Gets stock that will expire within the requested number of days.
    /// </summary>
    /// <remarks>
    /// This report returns stock that is not yet expired, starting from now through the requested future date.
    /// Already expired stock is returned by the separate expired report.
    /// </remarks>
    /// <param name="daysAhead">How many days into the future to check. Default is 30.</param>
    [HttpGet("reports/expiring")]
    public async Task<ActionResult<List<ExpiringStockReportDto>>> Expiring(
        [FromQuery] int daysAhead = 30
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryExpirationReportQuery(daysAhead, false)));

    /// <summary>
    /// Gets stock batches that are already expired and still have quantity remaining.
    /// </summary>
    /// <remarks>
    /// This is a report only. It does not automatically remove expired stock; use the expired-stock operation when the quantity should be posted out of inventory.
    /// </remarks>
    [HttpGet("reports/expired")]
    public async Task<ActionResult<List<ExpiringStockReportDto>>> Expired() =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryExpirationReportQuery(0, true)));

    /// <summary>
    /// Gets the current inventory value based on remaining batch quantities and their stored unit costs.
    /// </summary>
    /// <remarks>
    /// Valuation is calculated in base units so display conversions such as boxes or cartons do not change the inventory cost calculation.
    /// </remarks>
    [HttpGet("reports/valuation")]
    public async Task<ActionResult<InventoryValuationReportDto>> Valuation() =>
        HandleResultResponseOld(await Mediator.Send(new InventoryValuationQuery()));

    /// <summary>
    /// Gets recent inventory movement history with optional filters.
    /// </summary>
    /// <remarks>
    /// Results can be filtered by product, date range, movement reason, and direction. The newest movements are returned first.
    /// The requested limit is kept between 1 and 1000 records.
    /// </remarks>
    /// <param name="productId">Optional product ID.</param>
    /// <param name="fromUtc">Optional earliest movement time.</param>
    /// <param name="toUtc">Optional latest movement time.</param>
    /// <param name="reason">Optional reason such as sale, adjustment, damage, or receipt.</param>
    /// <param name="direction">Optional stock direction: in or out.</param>
    /// <param name="limit">Maximum number of movements to return. Default is 250 and the server caps it at 1000.</param>
    [HttpGet("reports/movements")]
    public async Task<ActionResult<List<InventoryMovementHistoryDto>>> MovementHistory(
        [FromQuery] string? productId = null,
        [FromQuery] DateTime? fromUtc = null,
        [FromQuery] DateTime? toUtc = null,
        [FromQuery] StockMovementReason? reason = null,
        [FromQuery] StockMovementDirection? direction = null,
        [FromQuery] int limit = 250
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryMovementHistoryQuery(
            productId,
            fromUtc,
            toUtc,
            reason,
            direction,
            limit)));
}