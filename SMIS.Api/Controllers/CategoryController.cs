using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages product categories and category synchronization for offline clients.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseApiController
    {
        /// <summary>
        /// Creates a new product category.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> Create(
            CategoryCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a category sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client sends its own ID and change time. If the server already has a newer version,
        /// the older client change is not allowed to overwrite it. This endpoint is meant for synchronization,
        /// not normal online category creation.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<CategoryDto>> SyncCreate(
            CategorySyncCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncCreateCommand(dto)));

        /// <summary>
        /// Gets categories in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<CategoryDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new CategoryGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Searches categories using flexible filters and optional returned columns.
        /// </summary>
        /// <remarks>
        /// Use this endpoint when the normal category list is not enough. The criteria object controls filtering,
        /// while <c>columns</c> can limit which fields are returned for dropdowns or lightweight screens.
        /// </remarks>
        [HttpGet("query")]
        public async Task<ActionResult<PagedListNew<CategoryDto>>> Query(
            [FromQuery] CategoryQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new CategoryQuery(
                new EntityDropdown<CategoryQueryCriteria>
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
        /// <summary>
        /// Gets one category by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing category.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDto>> Update(
            string id,
            CategoryUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a category update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale client change does not overwrite a newer server version. A successful sync can also restore
        /// a category that had been deleted if the incoming change is newer.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<CategoryDto>> SyncUpdate(
            string id,
            CategorySyncUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a category.
        /// </summary>
        /// <remarks>
        /// A category that is still used by products cannot be deleted until those products are moved to another category.
        /// </remarks>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategoryDeleteCommand(id)));

        /// <summary>
        /// Applies a category delete sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The delete is applied only when the client change is newer than the server version.
        /// The category also cannot be deleted while products still use it.
        /// </remarks>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<CategoryDto>> SyncDelete(
            string id,
            CategorySyncDeleteDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CategorySyncDeleteCommand(id, dto)));

    }
}