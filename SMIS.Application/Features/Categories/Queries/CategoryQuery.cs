using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Services;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories.Queries;

public record CategoryQuery(EntityDropdown<CategoryQuery> query) : IRequest<Result<PagedListNew<CategoryDto>>>
{
}

internal record CategoryQueryHandler : IRequestHandler<CategoryQuery, Result<PagedListNew<CategoryDto>>>
{
    private readonly IGenericQueryService _queryService;
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CategoryQueryHandler(
        IGenericQueryService queryService,
        IApplicationDbContext context,
        IMapper mapper
    )
    {
        _queryService = queryService;
        _mapper = mapper;
    }

    public async Task<Result<PagedListNew<CategoryDto>>> Handle(
        CategoryQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Categories.Select(x => new CategoryDto
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            Description = x.Description,
            IsActive = x.IsActive,
            ShopId = x.ShopId,
            CreatedDate = x.CreatedDate,
            CreatedBy = x.CreatedBy,
            UpdatedDate = x.UpdatedDate,
            UpdatedBy = x.UpdatedBy,
            ClientCreatedDate = x.ClientCreatedDate,
            ClientCreatedBy = x.ClientCreatedBy,
            ClientModifiedDate = x.ClientModifiedDate,
            ClientModifiedBy = x.ClientModifiedBy,
            LastModifiedUtc = x.LastModifiedUtc,
            IsDeleted = x.IsDeleted,
        }).OrderBy(x => x.Name);

        var pagedList = query.Filter(request.query.Criteria).Select(request.query.Columns).ToPagedList(
            (int)request.query.PageNumber!,
            (int)request.query.PageSize!);
        return default;

        //
        //
        // var categories = object;// await _queryService.QueryAsync<Category, CategoryQuery>(default(CategoryQuery), cancellationToken);
        //
        // return Result<PagedList<CategoryDto>>.SuccessResult(new PagedList<CategoryDto>
        // {
        //     Items = _mapper.Map<List<CategoryDto>>(categories.Items),
        //     PageNumber = categories.PageNumber,
        //     PageSize = categories.PageSize,
        //     TotalCount = categories.TotalCount,
        //     TotalPages = categories.TotalPages
        // });
    }
}