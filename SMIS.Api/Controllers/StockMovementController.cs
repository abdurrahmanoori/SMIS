using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements.Commands;
using SMIS.Application.Features.StockMovements.Queries;

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
    public async Task<ActionResult<List<StockMovementDto>>> Reverse(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementReverseCommand(id)));

    /// <summary>
    /// Gets stock movements in pages.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<PagedList<StockMovementDto>>> GetAll(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementGetListQuery(pageNumber, pageSize)));

    /// <summary>
    /// Gets one stock movement by its ID.
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<StockMovementDto>> GetById(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementGetByIdQuery(id)));
}