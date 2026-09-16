using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements.Commands;
using SMIS.Application.Features.StockMovements.Queries;

namespace SMIS.Api.Controllers;

// Inventory ledger API. Normal update/delete endpoints are intentionally absent;
// corrections are represented by posting a compensating reversal movement.

[Route("api/[controller]")]
[ApiController]
public sealed class StockMovementController : BaseApiController
{
    [HttpPost("{id}/reverse")]
    public async Task<ActionResult<List<StockMovementDto>>> Reverse(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementReverseCommand(id)));

    [HttpGet]
    public async Task<ActionResult<PagedList<StockMovementDto>>> GetAll(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementGetListQuery(pageNumber, pageSize)));

    [HttpGet("{id}")]
    public async Task<ActionResult<StockMovementDto>> GetById(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new StockMovementGetByIdQuery(id)));
}