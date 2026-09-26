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
    /// Manages customers.
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
        /// Deletes a customer.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new CustomerDeleteCommand(id)));

    }
}