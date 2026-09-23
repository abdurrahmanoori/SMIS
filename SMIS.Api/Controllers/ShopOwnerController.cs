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
        public async Task<ActionResult<ShopOwnerDto>> Create(
            ShopOwnerCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopOwnerCreateCommand(dto)));

        /// <summary>
        /// Gets shop owners in pages.
        /// </summary>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<PagedList<ShopOwnerDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopOwnerGetListQuery(pageNumber, pageSize)));

        /// <summary>
        /// Gets one shop owner by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopOwnerDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopOwnerGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing shop owner.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ShopOwnerDto>> Update(
            string id,
            ShopOwnerCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopOwnerUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a shop owner.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ShopOwnerDeleteCommand(id)));
    }
}