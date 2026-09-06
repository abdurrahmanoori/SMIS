using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
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
        [HttpPost]
        public async Task<ActionResult<ShopDto>> Create(ShopCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopCreateCommand(dto)));

        [HttpPost("sync")]
        public async Task<ActionResult<ShopDto>> SyncCreate(ShopSyncCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<ShopDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new ShopGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShopDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new ShopGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<ShopDto>> Update(string id, ShopUpdateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopUpdateCommand(id, dto)));

        [HttpPut("{id}/sync")]
        public async Task<ActionResult<ShopDto>> SyncUpdate(string id, ShopSyncUpdateDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new ShopDeleteCommand(id)));

        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<ShopDto>> SyncDelete(string id, ShopSyncDeleteDto dto) =>
            HandleResultResponse(await Mediator.Send(new ShopSyncDeleteCommand(id, dto)));

        [HttpGet("pull")]
        public async Task<ActionResult<List<ShopDto>>> Pull([FromQuery] DateTime changedSince) =>
            HandleResultResponse(await Mediator.Send(new ShopPullQuery(changedSince)));
    }
}

