using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Features.ShopOwners.Commands;
using SMIS.Application.Features.ShopOwners.Queries;
using SMIS.Api.Controllers.Base;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages shop-owner records.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ShopOwnerController : BaseApiController
    {
        /// <summary>
        /// Creates a new shop owner.
        /// </summary>
        [HttpPost]
        [HasPermission(ApplicationComponentKeys.ShopOwners, PermissionAction.Create)]
        public async Task<ActionResult<ShopOwnerDto>> Create(
            ShopOwnerCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerCreateCommand(dto)));

        /// <summary>
        /// Gets shop owners in pages.
        /// </summary>
        [HttpGet]
        [HasPermission(ApplicationComponentKeys.ShopOwners, PermissionAction.Read)]
        public async Task<ActionResult<PagedListNew<ShopOwnerDto>>> GetAll(
            [FromQuery] ShopOwnerQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new ShopOwnerQuery(new EntityDropdown<ShopOwnerQueryCriteria>
            {
                Criteria = criteria,
                Columns = columns,
                PageNumber = pageNumber,
                PageSize = pageSize
            }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing shop owner.
        /// </summary>
        [HttpPut("{id}")]
        [HasPermission(ApplicationComponentKeys.ShopOwners, PermissionAction.Update)]
        public async Task<ActionResult<ShopOwnerDto>> Update(
            string id,
            ShopOwnerCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a shop owner.
        /// </summary>
        [HttpDelete("{id}")]
        [HasPermission(ApplicationComponentKeys.ShopOwners, PermissionAction.Delete)]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new ShopOwnerDeleteCommand(id)));
    }
}