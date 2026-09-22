using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Queries;

public record UnitOfMeasurePullQuery(DateTime ChangedSince) : IRequest<Result<List<UnitOfMeasureDto>>>;

internal sealed class
    UnitOfMeasurePullQueryHandler : IRequestHandler<UnitOfMeasurePullQuery, Result<List<UnitOfMeasureDto>>>
{
    private readonly IUnitOfMeasureRepository _repository;
    private readonly IMapper _mapper;

    public UnitOfMeasurePullQueryHandler(
        IUnitOfMeasureRepository repository,
        IMapper mapper
    ) => (_repository, _mapper) = (repository, mapper);

    public async Task<Result<List<UnitOfMeasureDto>>> Handle(
        UnitOfMeasurePullQuery request,
        CancellationToken cancellationToken
    )
    {
        var since = DateTimeService.NormalizeUtc(request.ChangedSince);
        var units = await _repository.GetAllAsync(u => u.LastModifiedUtc > since, ignoreQueryFilters: true);
        return Result<List<UnitOfMeasureDto>>.SuccessResult(_mapper.Map<List<UnitOfMeasureDto>>(units));
    }
}