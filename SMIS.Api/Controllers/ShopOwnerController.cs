using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Features.ShopOwners.Commands;
using SMIS.Application.Features.ShopOwners.Queries;
using SMIS.Api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopOwnerController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<ShopOwnerDto>> Create(ShopOwnerCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerCreateCommand(dto)));

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<PagedList<ShopOwnerDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerGetListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<ShopOwnerDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ShopOwnerDto>> Update(string id, ShopOwnerCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerDeleteCommand(id)));
    }
}