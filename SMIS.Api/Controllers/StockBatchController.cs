using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Features.StockBatches.Commands;
using SMIS.Application.Features.StockBatches.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockBatchController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<StockBatchDto>> Create(StockBatchCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new StockBatchCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<StockBatchDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25) =>
            HandleResultResponse(await Mediator.Send(new StockBatchGetListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<StockBatchDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new StockBatchGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<StockBatchDto>> Update(string id, StockBatchCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new StockBatchUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new StockBatchDeleteCommand(id)));
    }
}