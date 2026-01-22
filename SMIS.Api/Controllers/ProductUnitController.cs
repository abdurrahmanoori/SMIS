using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Features.ProductUnits.Commands;
using SMIS.Application.Features.ProductUnits.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductUnitController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<ProductUnitCreateDto>> Create(ProductUnitCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CreateProductUnitCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProductUnitDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new GetProductUnitListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductUnitDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new GetProductUnitByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductUnitDto>> Update(string id, ProductUnitCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UpdateProductUnitCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new DeleteProductUnitCommand(id)));
    }
}