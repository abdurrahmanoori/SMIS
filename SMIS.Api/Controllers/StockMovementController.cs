using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements.Commands;
using SMIS.Application.Features.StockMovements.Queries;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers;

/// <summary>
/// Provides the inventory movement history used as the stock ledger.
/// </summary>
/// <remarks>
/// Stock movements are not edited or deleted after posting. If a supported movement is wrong, the system records an opposite reversal movement so the original history remains visible.
/// </remarks>
[Route("api/[controller]")]
[ApiController]
public sealed class StockMovementController : BaseApiController
{
    /// <summary>
    /// Reverses a posted stock movement by creating opposite movement entries.
    /// </summary>
    /// <remarks>
    /// The original movement stays unchanged. If the movement belongs to a grouped inventory operation, the whole operation is reversed together.
    /// Business workflows such as sales, purchase receipts, customer returns, and supplier returns must be corrected through their own workflow instead of this generic reversal endpoint.
    /// </remarks>
    /// <param name="id">The stock movement ID to reverse.</param>
    [HttpPost("{id}/reverse")]
    [HasPermission(ApplicationComponentKeys.Inventory, PermissionAction.Update)]
    [HasTaskPermission(ApplicationTaskKeys.ReverseStockMovement)]
    public async Task<ActionResult<List<StockMovementDto>>> Reverse(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementReverseCommand(id)));

    /// <summary>
    /// Gets stock movements with flexible filtering, optional returned columns, and pagination.
    /// </summary>
    [HttpGet]
    [HasPermission(ApplicationComponentKeys.Inventory, PermissionAction.Read)]
    public async Task<ActionResult<PagedListNew<StockMovementDto>>> GetAll(
        [FromQuery] StockMovementQueryCriteria criteria,
        [FromQuery] string[]? columns,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    ) => await HandleRequest(new StockMovementQuery(
        new EntityDropdown<StockMovementQueryCriteria>
        {
            Criteria = criteria,
            Columns = columns,
            PageNumber = pageNumber,
            PageSize = pageSize
        }), cancellationToken);
}