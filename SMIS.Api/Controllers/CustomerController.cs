using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Features.Customers.Commands;
using SMIS.Application.Features.Customers.Queries;
using SMIS.Api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages customers and customer synchronization for offline clients.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController
    {
        /// <summary>
        /// Creates a new customer.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> Create(
            CustomerCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerCreateCommand(dto)));

        /// <summary>
        /// Creates or updates a customer sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The client sends its own ID and change time. Older client changes do not overwrite a newer server version.
        /// Use the normal create endpoint for regular online requests.
        /// </remarks>
        [HttpPost("sync")]
        public async Task<ActionResult<CustomerDto>> SyncCreate(
            CustomerSyncCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerSyncCreateCommand(dto)));

        /// <summary>
        /// Gets customers in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true when shop information should be included with each customer.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<PagedList<CustomerDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeShop = false
        )
        {
            return HandleResultResponseOld(
                await Mediator.Send(new CustomerGetListQuery(pageNumber, pageSize, includeShop)));
        }

        /// <summary>
        /// Gets one customer by its ID.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true to include the related shop information.
        /// </remarks>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetById(
            string id,
            [FromQuery] bool includeShop = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerGetByIdQuery(id, includeShop)));

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerDto>> Update(
            string id,
            CustomerCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerUpdateCommand(id, dto)));

        /// <summary>
        /// Applies a customer update sent by an offline client.
        /// </summary>
        /// <remarks>
        /// If the server already has a newer change, the older client version is ignored instead of overwriting it.
        /// </remarks>
        [HttpPut("{id}/sync")]
        public async Task<ActionResult<CustomerDto>> SyncUpdate(
            string id,
            CustomerSyncUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerSyncUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a customer.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerDeleteCommand(id)));

        /// <summary>
        /// Applies a customer delete sent by an offline client.
        /// </summary>
        /// <remarks>
        /// The delete uses the client's change time so an older offline request does not replace newer server data.
        /// </remarks>
        [HttpDelete("{id}/sync")]
        public async Task<ActionResult<CustomerDto>> SyncDelete(
            string id,
            CustomerSyncDeleteDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerSyncDeleteCommand(id, dto)));

        /// <summary>
        /// Gets customer changes made after a given time for offline synchronization.
        /// </summary>
        /// <remarks>
        /// The result can include records that were deleted after the supplied time so offline clients can remove them locally.
        /// </remarks>
        /// <param name="changedSince">Return customers changed after this date and time.</param>
        [HttpGet("pull")]
        public async Task<ActionResult<List<CustomerDto>>> Pull(
            [FromQuery] DateTime changedSince
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerPullQuery(changedSince)));
    }
}