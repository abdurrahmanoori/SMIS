using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Application.Features.Purchasing.Queries;
using SMIS.Api.Authorization;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Enums;

namespace SMIS.Api.Controllers;

/// <summary>
/// Manages suppliers used when creating and receiving purchase orders.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public sealed class SupplierController : BaseApiController
{
    /// <summary>
    /// Creates a supplier for a shop.
    /// </summary>
    /// <remarks>
    /// The supplier name must be unique inside the shop, and regular users can create suppliers only for their own shop.
    /// </remarks>
    [HttpPost]
    [HasPermission(ApplicationComponentKeys.Suppliers, PermissionAction.Create)]
    public async Task<ActionResult<SupplierDto>> Create(
        SupplierCreateDto dto,
        CancellationToken cancellationToken
    ) =>
        await HandleRequest(new SupplierCreateCommand(dto), cancellationToken);

    /// <summary>
    /// Gets the suppliers visible to the current user.
    /// </summary>
    [HttpGet]
    [HasPermission(ApplicationComponentKeys.Suppliers, PermissionAction.Read)]
    public async Task<ActionResult<PagedListNew<SupplierDto>>> GetAll(
        [FromQuery] SupplierQueryCriteria criteria,
        [FromQuery] string[]? columns,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 25,
        CancellationToken cancellationToken = default
    )
    {
        return await HandleRequest(new SupplierQuery(new EntityDropdown<SupplierQueryCriteria>
        {
            Criteria = criteria,
            Columns = columns,
            PageNumber = pageNumber,
            PageSize = pageSize
        }), cancellationToken);
    }
}