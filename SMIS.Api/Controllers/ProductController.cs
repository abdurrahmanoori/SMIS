using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.Features.Products.Commands;
using SMIS.Application.Features.Products.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<ProductDto>> Create(ProductCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProductCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProductDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeCategory = false)
        {
            return HandleResultResponse(await Mediator.Send(new ProductGetListQuery(pageNumber, pageSize, includeCategory)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetById(string id, [FromQuery] bool includeCategory = false) =>
            HandleResultResponse(await Mediator.Send(new ProductGetByIdQuery(id, includeCategory)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDto>> Update(string id, ProductCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ProductUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new ProductDeleteCommand(id)));
    }
}