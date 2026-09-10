using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> Create(
            CategoryCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryCreateCommand(dto)));

        [HttpPost("sync")]
        public async Task<ActionResult<CategoryDto>> SyncCreate(
            CategorySyncCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<CategoryDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new CategoryGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("query")]
        public async Task<ActionResult<PagedListNew<CategoryDto>>> Query(
            [FromQuery] CategoryQuery criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber,
            [FromQuery] int pageSize,
            CancellationToken cancellationToken
        )
        {
            return await HandleRequest(new CategoryQuery(
                new EntityDropdown<CategoryQuery>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                }), cancellationToken);
        }

        //
        // [HttpGet("query")]
        // public async Task<ActionResult<PagedList<CategoryDto>>> Query(
        //     [FromQuery] CategoryQuery query,
        //     CancellationToken cancellationToken
        // ) =>
        //     HandleResultResponseOld(await Mediator.Send(
        //         new CategoryGetFilteredListQuery(query),
        //         cancellationToken));
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDto>> Update(
            string id,
            CategoryUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryUpdateCommand(id, dto)));

        [HttpPut("{id}/sync")]
        public async Task<ActionResult<CategoryDto>> SyncUpdate(
            string id,
            CategorySyncUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryDeleteCommand(id)));

        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<CategoryDto>> SyncDelete(
            string id,
            CategorySyncDeleteDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncDeleteCommand(id, dto)));

        [HttpGet("pull")]
        public async Task<ActionResult<List<CategoryDto>>> Pull(
            [FromQuery] DateTime changedSince
        )
            => HandleResultResponseOld(await Mediator.Send(new CategoryPullQuery(changedSince)));
    }
}