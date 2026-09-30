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
            HandleResultResponse(await Mediator.Send(new CustomerCreateCommand(dto)));

        /// <summary>
        /// Gets customers in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true when shop information should be included with each customer.
        /// </remarks>
        [HttpGet]
        public async Task<ActionResult<PagedListNew<CustomerDto>>> GetAll(
            [FromQuery] CustomerQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new CustomerQuery(new EntityDropdown<CustomerQueryCriteria>
            {
                Criteria = criteria,
                Columns = columns,
                PageNumber = pageNumber,
                PageSize = pageSize
            }), cancellationToken);
        }

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerDto>> Update(
            string id,
            CustomerCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new CustomerUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a customer.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new CustomerDeleteCommand(id)));
    }
}