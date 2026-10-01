using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Customers.Queries;

public sealed record CustomerQuery(EntityDropdown<CustomerQueryCriteria> Query)
    : IRequest<Result<PagedListNew<CustomerDto>>>;

internal sealed class CustomerQueryHandler
    : IRequestHandler<CustomerQuery, Result<PagedListNew<CustomerDto>>>
{
    private readonly IApplicationDbContext _context;

    public CustomerQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<CustomerDto>>> Handle(
        CustomerQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Customers
            .OrderBy(customer => customer.FirstName)
            .ThenBy(customer => customer.LastName)
            .Select(customer => new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                ShopId = customer.ShopId,
                ShopName = customer.ShopName,
                CustomerType = customer.CustomerType,
                FatherName = customer.FatherName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                TaxNumber = customer.TaxNumber,
                ProvinceId = customer.ProvinceId,
                DistrictId = customer.DistrictId,
                IsActive = customer.IsActive,
                CreatedDate = customer.CreatedDate,
                CreatedBy = customer.CreatedBy,
                UpdatedDate = customer.UpdatedDate,
                UpdatedBy = customer.UpdatedBy,
                LastModifiedUtc = customer.LastModifiedUtc,
                IsDeleted = customer.IsDeleted
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<CustomerDto>>.Success(page);
    }
}