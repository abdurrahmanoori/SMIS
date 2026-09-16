using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Application.Features.Purchasing.Queries;

namespace SMIS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class PurchaseOrderController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<PurchaseOrderDto>> Create(
        PurchaseOrderCreateDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderCreateCommand(dto), cancellationToken);

    [HttpGet]
    public async Task<ActionResult<List<PurchaseOrderDto>>> GetAll(
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderGetListQuery(), cancellationToken);

    [HttpGet("{id}")]
    public async Task<ActionResult<PurchaseOrderDto>> GetById(
        string id,
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderGetByIdQuery(id), cancellationToken);

    [HttpPost("{id}/receipts")]
    public async Task<ActionResult<PurchaseOrderDto>> Receive(
        string id,
        PurchaseOrderReceiveDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderReceiveCommand(id, dto), cancellationToken);

    [HttpPost("{id}/supplier-returns")]
    public async Task<ActionResult<PurchaseOrderDto>> SupplierReturn(
        string id,
        PurchaseOrderSupplierReturnDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderSupplierReturnCommand(id, dto), cancellationToken);

    [HttpPost("{id}/cancel")]
    public async Task<ActionResult<PurchaseOrderDto>> Cancel(
        string id,
        CancellationToken cancellationToken) =>
        await HandleRequest(new PurchaseOrderCancelCommand(id), cancellationToken);
}
