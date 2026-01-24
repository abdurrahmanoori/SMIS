using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
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
        public async Task<ActionResult<ProductUnitDto>> Create(ProductUnitCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProductUnitDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeProduct = false, [FromQuery] bool includeUnitOfMeasure = false)
        {
            return HandleResultResponse(await Mediator.Send(new ProductUnitGetListQuery(pageNumber, pageSize, includeProduct, includeUnitOfMeasure)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductUnitDto>> GetById(string id, [FromQuery] bool includeProduct = false, [FromQuery] bool includeUnitOfMeasure = false) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitGetByIdQuery(id, includeProduct, includeUnitOfMeasure)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductUnitDto>> Update(string id, ProductUnitCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new ProductUnitDeleteCommand(id)));
    }
}