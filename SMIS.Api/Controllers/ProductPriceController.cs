using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Features.ProductPrices.Commands;
using SMIS.Application.Features.ProductPrices.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductPriceController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<ProductPriceDto>> Create(ProductPriceCreateDto dto) =>
        HandleResultResponse(await Mediator.Send(new ProductPriceCreateCommand(dto)));

    [HttpGet]
    public async Task<ActionResult<PagedList<ProductPriceDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeProduct = false) =>
        HandleResultResponse(await Mediator.Send(new ProductPriceGetListQuery(pageNumber, pageSize, includeProduct)));

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductPriceDto>> GetById(string id, [FromQuery] bool includeProduct = false) =>
        HandleResultResponse(await Mediator.Send(new ProductPriceGetByIdQuery(id, includeProduct)));

    [HttpPut("{id}")]
    public async Task<ActionResult<ProductPriceDto>> Update(string id, ProductPriceCreateDto dto) =>
        HandleResultResponse(await Mediator.Send(new ProductPriceUpdateCommand(id, dto)));

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> Delete(string id) =>
        HandleResultResponse(await Mediator.Send(new ProductPriceDeleteCommand(id)));
}
