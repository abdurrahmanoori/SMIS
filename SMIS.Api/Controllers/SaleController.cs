using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Features.Sales.Commands;
using SMIS.Application.Features.Sales.Queries;

namespace SMIS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class SaleController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<SaleDto>> Create(
        SaleCreateDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleCreateCommand(dto), cancellationToken);

    [HttpGet]
    public async Task<ActionResult<PagedList<SaleDto>>> GetAll(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    ) =>
        await HandleRequest(new SaleGetListQuery(pageNumber, pageSize), cancellationToken);

    [HttpGet("{id}")]
    public async Task<ActionResult<SaleDto>> GetById(
        string id,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleGetByIdQuery(id), cancellationToken);

    [HttpPost("{id}/returns")]
    public async Task<ActionResult<SaleReturnResultDto>> Return(
        string id,
        SaleReturnDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new SaleReturnCommand(id, dto), cancellationToken);

    [HttpPost("{id}/void")]
    public async Task<ActionResult<SaleReturnResultDto>> Void(
        string id,
        SaleVoidDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new SaleVoidCommand(id, dto), cancellationToken);
}