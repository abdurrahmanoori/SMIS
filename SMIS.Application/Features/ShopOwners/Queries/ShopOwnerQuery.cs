using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Services;

namespace SMIS.Application.Features.ShopOwners.Queries;

public sealed record ShopOwnerQuery(EntityDropdown<ShopOwnerQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ShopOwnerDto>>>;

internal sealed class ShopOwnerQueryHandler
    : IRequestHandler<ShopOwnerQuery, Result<PagedListNew<ShopOwnerDto>>>
{
    private readonly IApplicationDbContext _context;

    public ShopOwnerQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<ShopOwnerDto>>> Handle(
        ShopOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.ShopOwners
            .OrderBy(owner => owner.FirstName)
            .ThenBy(owner => owner.LastName)
            .Select(owner => new ShopOwnerDto
            {
                Id = owner.Id,
                ApplicationUserId = owner.ApplicationUserId,
                ShopId = owner.ShopId,
                ShopName = owner.ShopName,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                NationalIdCardNumber = owner.NationalIdCardNumber,
                PhoneNumber = owner.PhoneNumber,
                Email = owner.Email,
                Address = owner.Address,
                OwnershipPercentage = owner.OwnershipPercentage,
                StartDate = owner.StartDate,
                EndDate = owner.EndDate,
                IsActive = owner.IsActive,
                ProvinceId = owner.ProvinceId,
                DistrictId = owner.DistrictId
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ShopOwnerDto>>.Success(page);
    }
}