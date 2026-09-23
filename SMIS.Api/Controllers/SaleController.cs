using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Features.Sales.Commands;
using SMIS.Application.Features.Sales.Queries;

namespace SMIS.Api.Controllers;

/// <summary>
/// Handles sales, sale lookup, customer returns, and sale voids.
/// </summary>
/// <remarks>
/// Creating a sale removes stock, while returns and voids can add stock back.
/// Credit sales also create or reduce the customer's amount due.
/// </remarks>
[Route("api/[controller]")]
[ApiController]
public sealed class SaleController : BaseApiController
{
    /// <summary>
    /// Creates a new sale and removes the sold items from stock.
    /// </summary>
    /// <remarks>
    /// Stock is taken from usable batches, with stock that expires sooner used first when possible.
    /// A credit sale requires a customer and creates an amount due for the sale total.
    /// The sale and stock changes are saved together. An optional idempotency key can be used to avoid
    /// creating the same sale twice when a request is retried.
    /// </remarks>
    /// <param name="dto">
    /// The sale information, including shop, customer, payment type, date, notes, and sale lines.
    /// </param>
    /// <param name="cancellationToken">Stops the request if it is cancelled.</param>
    /// <returns>
    /// The created sale with its lines and credit information when applicable.
    /// </returns>
    [HttpPost]
    public async Task<ActionResult<SaleDto>> Create(
        SaleCreateDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleCreateCommand(dto), cancellationToken);

    /// <summary>
    /// Gets sales in pages.
    /// </summary>
    /// <remarks>
    /// Regular shop users see sales from their own shop. Super administrators can see sales from all shops.
    /// Results include sale lines and credit information when available.
    /// </remarks>
    /// <param name="pageNumber">The page number. Default is 1.</param>
    /// <param name="pageSize">The number of sales per page. Default is 25.</param>
    /// <param name="cancellationToken">Stops the request if it is cancelled.</param>
    /// <returns>A page of sales.</returns>
    [HttpGet]
    public async Task<ActionResult<PagedList<SaleDto>>> GetAll(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    ) =>
        await HandleRequest(new SaleGetListQuery(pageNumber, pageSize), cancellationToken);

    /// <summary>
    /// Gets one sale by its ID.
    /// </summary>
    /// <remarks>
    /// The sale is returned only if the current user is allowed to see it.
    /// The result includes sale lines and credit information when available.
    /// </remarks>
    /// <param name="id">The sale ID.</param>
    /// <param name="cancellationToken">Stops the request if it is cancelled.</param>
    /// <returns>The sale if it exists and the user can access it.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<SaleDto>> GetById(
        string id,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleGetByIdQuery(id), cancellationToken);

    /// <summary>
    /// Returns items from an existing sale.
    /// </summary>
    /// <remarks>
    /// You can return some or all of the quantity that is still returnable. Returned stock goes back to the
    /// original stock batches used by the sale. A line cannot be returned for more than the quantity that remains returnable.
    /// The sale's returned amount and status are updated automatically.
    /// For credit sales, the amount due is reduced. The response also shows any refund that should be given.
    /// An optional idempotency key can be used to avoid processing the same return twice.
    /// </remarks>
    /// <param name="id">The sale ID.</param>
    /// <param name="dto">The items and quantities to return, with an optional return time and idempotency key.</param>
    /// <param name="cancellationToken">Stops the request if it is cancelled.</param>
    /// <returns>
    /// The updated sale status, returned amount, refund amount, remaining amount due, and stock movements.
    /// </returns>
    [HttpPost("{id}/returns")]
    public async Task<ActionResult<SaleReturnResultDto>> Return(
        string id,
        SaleReturnDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleReturnCommand(id, dto), cancellationToken);

    /// <summary>
    /// Voids a sale by returning everything that can still be returned.
    /// </summary>
    /// <remarks>
    /// All quantities that are still returnable are put back into their original stock batches and the sale is marked as voided.
    /// Quantities that were already returned are not returned a second time.
    /// For credit sales, the amount due is reduced. The response shows any refund that should be given.
    /// An optional idempotency key can be used to avoid voiding the same sale twice.
    /// </remarks>
    /// <param name="id">The sale ID.</param>
    /// <param name="dto">The void time and optional idempotency key.</param>
    /// <param name="cancellationToken">Stops the request if it is cancelled.</param>
    /// <returns>
    /// The final sale status, returned amount, refund amount, remaining amount due, and stock movements.
    /// </returns>
    [HttpPost("{id}/void")]
    public async Task<ActionResult<SaleReturnResultDto>> Void(
        string id,
        SaleVoidDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SaleVoidCommand(id, dto), cancellationToken);
}