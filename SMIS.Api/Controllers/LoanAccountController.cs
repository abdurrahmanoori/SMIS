using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Features.LoanAccounts.Commands;
using SMIS.Application.Features.LoanAccounts.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers;

/// <summary>
/// Manages customer credit balances, payments, and debt summaries.
/// </summary>
/// <remarks>
/// Loan accounts represent money a customer still owes. Paying a loan changes the debt balance only; it does not change stock because the stock was already removed when the sale happened.
/// </remarks>
[Route("api/[controller]")]
[ApiController]
public class LoanAccountController : BaseApiController
{
    /// <summary>
    /// Creates a new loan account.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<LoanAccountDto>> Create(
        LoanAccountCreateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new LoanAccountCreateCommand(dto)));

    /// <summary>
    /// Gets loan accounts in pages.
    /// </summary>
    /// <remarks>
    /// Use <c>includeCustomer</c> and <c>includeSale</c> when the response should also contain those related records.
    /// </remarks>
    [HttpGet]
    public async Task<ActionResult<PagedList<LoanAccountDto>>> GetAll(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        [FromQuery] bool includeCustomer = false,
        [FromQuery] bool includeSale = false
    ) =>
        HandleResultResponseOld(
            await Mediator.Send(new LoanAccountGetListQuery(pageNumber, pageSize, includeCustomer, includeSale)));

    /// <summary>
    /// Gets one loan account by its ID.
    /// </summary>
    /// <remarks>
    /// Customer and sale details can be included with the two query flags.
    /// </remarks>
    [HttpGet("{id}")]
    public async Task<ActionResult<LoanAccountDto>> GetById(
        string id,
        [FromQuery] bool includeCustomer = false,
        [FromQuery] bool includeSale = false
    ) =>
        HandleResultResponseOld(await Mediator.Send(new LoanAccountGetByIdQuery(id, includeCustomer, includeSale)));

    /// <summary>
    /// Updates an existing loan account.
    /// </summary>
    [HttpPut("{id}")]
    public async Task<ActionResult<LoanAccountDto>> Update(
        string id,
        LoanAccountUpdateDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new LoanAccountUpdateCommand(id, dto)));

    /// <summary>
    /// Deletes a loan account.
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> Delete(
        string id
    ) =>
        HandleResultResponseOld(await Mediator.Send(new LoanAccountDeleteCommand(id)));

    /// <summary>
    /// Applies one customer payment across that customer's unpaid loan accounts.
    /// </summary>
    /// <remarks>
    /// The payment is allocated across unpaid loans in FIFO order. For example, if the customer owes several older balances,
    /// the older balance is paid first before money is applied to the next one. The payment cannot be greater than the customer's total unpaid debt.
    /// The response shows how much was applied to each loan and what remains after the payment.
    /// </remarks>
    [HttpPost("process-payment")]
    public async Task<ActionResult<PaymentAllocationResultDto>> ProcessPayment(
        CustomerPaymentDto dto
    ) =>
        HandleResultResponseOld(await Mediator.Send(new ProcessCustomerPaymentCommand
        {
            CustomerId = dto.CustomerId,
            PaymentAmount = dto.PaymentAmount,
            PaymentDate = dto.PaymentDate,
            PaymentMethod = dto.PaymentMethod,
            Notes = dto.Notes
        }));

    /// <summary>
    /// Gets a summary of a customer's current debt.
    /// </summary>
    /// <remarks>
    /// Use this endpoint when the client needs the customer's overall credit position instead of opening each loan account separately.
    /// </remarks>
    /// <param name="customerId">The customer ID.</param>
    [HttpGet("customer/{customerId}/debt-summary")]
    public async Task<ActionResult<CustomerDebtSummaryDto>> GetCustomerDebtSummary(
        string customerId
    ) =>
        HandleResultResponseOld(await Mediator.Send(new GetCustomerDebtSummaryQuery { CustomerId = customerId }));
}