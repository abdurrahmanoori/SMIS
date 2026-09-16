using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Features.StockBatches.Commands;
using SMIS.Application.Features.StockBatches.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    // Batch endpoints describe physical receipts and batch metadata. Inventory balance
    // itself is changed through StockMovement workflows rather than arbitrary batch edits.
    [Route("api/[controller]")]
    [ApiController]
    public class StockBatchController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<StockBatchDto>> Create(
            StockBatchCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<StockBatchDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchGetListQuery(pageNumber, pageSize)));

        [HttpGet("{id}")]
        public async Task<ActionResult<StockBatchDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<StockBatchDto>> Update(
            string id,
            StockBatchUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new StockBatchUpdateCommand(id, dto)));
    }
}