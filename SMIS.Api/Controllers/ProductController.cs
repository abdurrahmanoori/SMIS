using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
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
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ProductCreateDto>> Create(ProductCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new CreateProductCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ProductDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await _mediator.Send(new GetProductListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{publicId}")]
        public async Task<ActionResult<ProductDto>> GetById(string id) =>
            HandleResultResponse(await _mediator.Send(new GetProductByIdQuery(id)));

        [HttpPut("{PublicId}")]
        public async Task<ActionResult<ProductDto>> Update(string id, ProductCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new UpdateProductCommand(id, dto)));

        [HttpDelete("{publicId}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await _mediator.Send(new DeleteProductCommand(id)));
    }
}