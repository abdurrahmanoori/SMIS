using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

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
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Create)]
        public async Task<ActionResult<CategoryDto>> Create(
            CategoryCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CategoryCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a category sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client sends its own ID and change time. If the server already has a newer version,
        /// the older client change is not allowed to overwrite it. This endpoint is meant for synchronization,
        /// not normal online category creation.
        /// </remarks>
        [HttpPost("sync")]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Create)]
        public async Task<ActionResult<CategoryDto>> SyncCreate(
            CategorySyncCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CategorySyncCreateCommand(dto)));

        /// <summary>
        /// Gets categories with flexible filtering, optional returned columns, and pagination.
        /// </summary>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<CategoryDto>>> GetAll(
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

        /// <summary>
        /// Updates an existing category.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Update)]
        public async Task<ActionResult<CategoryDto>> Update(
            string id,
            CategoryUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CategoryUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a category update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// A stale client change does not overwrite a newer server version. A successful sync can also restore
        /// a category that had been deleted if the incoming change is newer.
        /// </remarks>
        [HttpPut("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Update)]
        public async Task<ActionResult<CategoryDto>> SyncUpdate(
            string id,
            CategorySyncUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CategorySyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a category.
        /// </summary>
        /// <remarks>
        /// A category that is still used by products cannot be deleted until those products are moved to another category.
        /// </remarks>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Delete)]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new CategoryDeleteCommand(id)));

        /// <summary>
        /// Applies a category delete sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The delete is applied only when the client change is newer than the server version.
        /// The category also cannot be deleted while products still use it.
        /// </remarks>
        [HttpDelete("{id}/sync")]
        [HasPermission(ApplicationComponentKeys.Categories, PermissionAction.Delete)]
        public async Task<ActionResult<CategoryDto>> SyncDelete(
            string id,
            CategorySyncDeleteDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CategorySyncDeleteCommand(id, dto)));
    }
}