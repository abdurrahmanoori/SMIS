using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Services;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories.Queries;

public sealed record CategoryGetFilteredListQuery(CategoryQuery Query)
    : IRequest<Result<PagedList<CategoryDto>>>;

internal sealed class CategoryGetFilteredListQueryHandler
    : IRequestHandler<CategoryGetFilteredListQuery, Result<PagedList<CategoryDto>>>
{
    private readonly IGenericQueryService _queryService;
    private readonly IMapper _mapper;

    public CategoryGetFilteredListQueryHandler(
        IGenericQueryService queryService,
        IMapper mapper
    )
    {
        _queryService = queryService;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<CategoryDto>>> Handle(
        CategoryGetFilteredListQuery request,
        CancellationToken cancellationToken
    )
    {
        var categories = await _queryService.QueryAsync<Category, CategoryQuery>(
            request.Query,
            cancellationToken);

        return Result<PagedList<CategoryDto>>.SuccessResult(new PagedList<CategoryDto>
        {
            Items = _mapper.Map<List<CategoryDto>>(categories.Items),
            PageNumber = categories.PageNumber,
            PageSize = categories.PageSize,
            TotalCount = categories.TotalCount,
            TotalPages = categories.TotalPages
        });
    }
}