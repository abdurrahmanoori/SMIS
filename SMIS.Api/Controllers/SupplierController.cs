using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Application.Features.Purchasing.Queries;

namespace SMIS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class SupplierController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<SupplierDto>> Create(
        SupplierCreateDto dto,
        CancellationToken cancellationToken) =>
        await HandleRequest(new SupplierCreateCommand(dto), cancellationToken);

    [HttpGet]
    public async Task<ActionResult<List<SupplierDto>>> GetAll(
        CancellationToken cancellationToken) =>
        await HandleRequest(new SupplierGetListQuery(), cancellationToken);
}
