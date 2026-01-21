using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Application.Features.Shops.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : BaseApiController
    {
        private readonly IMediator _mediator;
        public ShopController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ShopCreateDto>> Create(ShopCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new CreateShopCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ShopDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await _mediator.Send(new GetShopListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{publicId}")]
        public async Task<ActionResult<ShopDto>> GetById(string id) =>
            HandleResultResponse(await _mediator.Send(new GetShopByIdQuery(id)));

        [HttpPut("{PublicId}")]
        public async Task<ActionResult<ShopDto>> Update(string id, ShopCreateDto dto) =>
            HandleResultResponse(await _mediator.Send(new UpdateShopCommand(id, dto)));

        [HttpDelete("{publicId}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await _mediator.Send(new DeleteShopCommand(id)));
    }
}

