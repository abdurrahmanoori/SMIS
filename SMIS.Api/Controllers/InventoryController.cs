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
/// Explicit inventory business workflows. Every stock-changing endpoint delegates to
/// the shared inventory workflow; none writes StockBatch.RemainingQuantityBase directly.
/// </summary>
[Route("api/inventory")]
[ApiController]
public sealed class InventoryController : BaseApiController
{
    [HttpPost("purchase-receipts")]
    public async Task<ActionResult<StockBatchDto>> ReceivePurchase(
        StockBatchCreateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockBatchCreateCommand(dto)));

    [HttpPost("customer-returns")]
    public async Task<ActionResult<StockMovementDto>> CustomerReturn(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.In,
            StockMovementReason.CustomerReturn)));

    [HttpPost("supplier-returns")]
    public async Task<ActionResult<StockMovementDto>> SupplierReturn(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.SupplierReturn)));

    [HttpPost("damaged-stock")]
    public async Task<ActionResult<StockMovementDto>> Damage(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.Damage)));

    [HttpPost("expired-stock")]
    public async Task<ActionResult<StockMovementDto>> Expire(
        InventoryBatchOperationDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            StockMovementDirection.Out,
            StockMovementReason.Expiration)));

    [HttpPost("adjustments")]
    public async Task<ActionResult<StockMovementDto>> Adjust(
        InventoryAdjustmentDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryBatchOperationCommand(
            dto,
            dto.Direction,
            StockMovementReason.Adjustment)));

    [HttpPost("transfers")]
    public async Task<ActionResult<List<StockMovementDto>>> Transfer(
        InventoryTransferDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new InventoryTransferCommand(dto)));

    [HttpGet("reconciliation")]
    public async Task<ActionResult<List<InventoryReconciliationDto>>> Reconcile(
        [FromQuery] string? stockBatchId = null,
        [FromQuery] bool onlyMismatches = false
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryReconciliationQuery(stockBatchId, onlyMismatches)));

    [HttpPost("stock-counts")]
    public async Task<ActionResult<StockCountSessionDto>> StartStockCount(
        StockCountStartDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountStartCommand(dto)));

    [HttpPost("stock-counts/{id}/complete")]
    public async Task<ActionResult<StockCountSessionDto>> CompleteStockCount(
        string id,
        StockCountCompleteDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountCompleteCommand(id, dto)));

    [HttpGet("stock-counts/{id}")]
    public async Task<ActionResult<StockCountSessionDto>> GetStockCount(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountGetByIdQuery(id)));

    [HttpPost("stock-counts/{id}/cancel")]
    public async Task<ActionResult<StockCountSessionDto>> CancelStockCount(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockCountCancelCommand(id)));

    [HttpGet("reports/current-stock")]
    public async Task<ActionResult<List<CurrentStockReportDto>>> CurrentStock(
        [FromQuery] decimal? lowStockThresholdBase = null,
        [FromQuery] bool includePresentationUnits = true
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryCurrentStockQuery(lowStockThresholdBase, false, includePresentationUnits)));

    [HttpGet("reports/low-stock")]
    public async Task<ActionResult<List<CurrentStockReportDto>>> LowStock(
        [FromQuery] decimal? thresholdBase = null,
        [FromQuery] bool includePresentationUnits = true
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryCurrentStockQuery(thresholdBase, true, includePresentationUnits)));

    [HttpGet("reports/expiring")]
    public async Task<ActionResult<List<ExpiringStockReportDto>>> Expiring(
        [FromQuery] int daysAhead = 30
    ) =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryExpirationReportQuery(daysAhead, false)));

    [HttpGet("reports/expired")]
    public async Task<ActionResult<List<ExpiringStockReportDto>>> Expired() =>
        HandleResultResponseOld(await Mediator.Send(
            new InventoryExpirationReportQuery(0, true)));

    [HttpGet("reports/valuation")]
    public async Task<ActionResult<InventoryValuationReportDto>> Valuation() =>
        HandleResultResponseOld(await Mediator.Send(new InventoryValuationQuery()));

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