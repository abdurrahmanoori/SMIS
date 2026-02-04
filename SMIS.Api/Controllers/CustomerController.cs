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
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> Create(CustomerCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CustomerCreateCommand(dto)));

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<PagedList<CustomerDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeShop = false)
        {
            return HandleResultResponse(await Mediator.Send(new CustomerGetListQuery(pageNumber, pageSize, includeShop)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetById(string id, [FromQuery] bool includeShop = false) =>
            HandleResultResponse(await Mediator.Send(new CustomerGetByIdQuery(id, includeShop)));

        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerDto>> Update(string id, CustomerCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CustomerUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new CustomerDeleteCommand(id)));
    }
}