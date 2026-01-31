using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Application.Features.StockTransactions.Commands;
using SMIS.Application.Features.StockTransactions.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTransactionController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<StockTransactionDto>> Create(StockTransactionCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new StockTransactionCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<StockTransactionDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeRelated = false)
        {
            return HandleResultResponse(await Mediator.Send(new StockTransactionGetListQuery(pageNumber, pageSize, includeRelated)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StockTransactionDto>> GetById(string id, [FromQuery] bool includeRelated = false) =>
            HandleResultResponse(await Mediator.Send(new StockTransactionGetByIdQuery(id, includeRelated)));

        [HttpPut("{id}")]
        public async Task<ActionResult<StockTransactionDto>> Update(string id, StockTransactionCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new StockTransactionUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new StockTransactionDeleteCommand(id)));
    }
}