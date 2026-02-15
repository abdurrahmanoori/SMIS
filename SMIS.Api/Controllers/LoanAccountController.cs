using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Features.LoanAccounts.Commands;
using SMIS.Application.Features.LoanAccounts.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoanAccountController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<LoanAccountDto>> Create(LoanAccountCreateDto dto) =>
        HandleResultResponse(await Mediator.Send(new LoanAccountCreateCommand(dto)));

    [HttpGet]
    public async Task<ActionResult<PagedList<LoanAccountDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeCustomer = false, [FromQuery] bool includeProduct = false) =>
        HandleResultResponse(await Mediator.Send(new LoanAccountGetListQuery(pageNumber, pageSize, includeCustomer, includeProduct)));

    [HttpGet("{id}")]
    public async Task<ActionResult<LoanAccountDto>> GetById(string id, [FromQuery] bool includeCustomer = false, [FromQuery] bool includeProduct = false) =>
        HandleResultResponse(await Mediator.Send(new LoanAccountGetByIdQuery(id, includeCustomer, includeProduct)));

    [HttpPut("{id}")]
    public async Task<ActionResult<LoanAccountDto>> Update(string id, LoanAccountCreateDto dto) =>
        HandleResultResponse(await Mediator.Send(new LoanAccountUpdateCommand(id, dto)));

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> Delete(string id) =>
        HandleResultResponse(await Mediator.Send(new LoanAccountDeleteCommand(id)));

    [HttpPost("process-payment")]
    public async Task<ActionResult<PaymentAllocationResultDto>> ProcessPayment(CustomerPaymentDto dto) =>
        HandleResultResponse(await Mediator.Send(new ProcessCustomerPaymentCommand
        {
            CustomerId = dto.CustomerId,
            PaymentAmount = dto.PaymentAmount,
            PaymentDate = dto.PaymentDate,
            PaymentMethod = dto.PaymentMethod,
            Notes = dto.Notes
        }));

    [HttpGet("customer/{customerId}/debt-summary")]
    public async Task<ActionResult<CustomerDebtSummaryDto>> GetCustomerDebtSummary(string customerId) =>
        HandleResultResponse(await Mediator.Send(new GetCustomerDebtSummaryQuery { CustomerId = customerId }));
}
