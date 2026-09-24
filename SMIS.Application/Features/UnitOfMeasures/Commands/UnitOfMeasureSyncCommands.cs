using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands;

public record UnitOfMeasureSyncCreateCommand(UnitOfMeasureSyncCreateDto Dto) : IRequest<Result<UnitOfMeasureDto>>;

public record UnitOfMeasureSyncUpdateCommand(string Id, UnitOfMeasureSyncUpdateDto Dto)
    : IRequest<Result<UnitOfMeasureDto>>;

public record UnitOfMeasureSyncDeleteCommand(string Id, UnitOfMeasureSyncDeleteDto Dto)
    : IRequest<Result<UnitOfMeasureDto>>;

internal sealed class
    UnitOfMeasureSyncCreateCommandHandler : IRequestHandler<UnitOfMeasureSyncCreateCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public UnitOfMeasureSyncCreateCommandHandler(
        IUnitOfMeasureRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _currentUser, _mapper) = (repository, db, currentUser, mapper);

    public async Task<Result<UnitOfMeasureDto>> Handle(
        UnitOfMeasureSyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = UnitOfMeasureSyncRules.Id(request.Dto.Id);
        var unit = await _db.UnitOfMeasures
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (unit is not null)
        {
            if (modified <= unit.GetConflictModifiedUtc())
                return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
            UnitOfMeasureCommandRules.Apply(unit, request.Dto.Name, request.Dto.Symbol, request.Dto.Description);
            unit.SetClientModificationMetadata(modified);
            unit.Restore();
            await _db.SaveChangesAsync(cancellationToken);
            return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
        }

        unit = UnitOfMeasureCommandRules.Create(request.Dto.Name, request.Dto.Symbol, request.Dto.Description);
        unit.Id = id;
        unit.SetClientModificationMetadata(modified);
        await _repository.AddAsync(unit);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
    }
}

internal sealed class
    UnitOfMeasureSyncUpdateCommandHandler : IRequestHandler<UnitOfMeasureSyncUpdateCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public UnitOfMeasureSyncUpdateCommandHandler(
        IUnitOfMeasureRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _currentUser, _mapper) = (repository, db, currentUser, mapper);

    public async Task<Result<UnitOfMeasureDto>> Handle(
        UnitOfMeasureSyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = UnitOfMeasureSyncRules.Id(request.Id);
        var unit = await _db.UnitOfMeasures
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (unit is null) return Result<UnitOfMeasureDto>.NotFoundResult(request.Id);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= unit.GetConflictModifiedUtc())
            return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
        UnitOfMeasureCommandRules.Apply(unit, request.Dto.Name, request.Dto.Symbol, request.Dto.Description);
        unit.SetClientModificationMetadata(modified);
        unit.Restore();
        await _db.SaveChangesAsync(cancellationToken);
        return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
    }
}

internal sealed class
    UnitOfMeasureSyncDeleteCommandHandler : IRequestHandler<UnitOfMeasureSyncDeleteCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public UnitOfMeasureSyncDeleteCommandHandler(
        IUnitOfMeasureRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _currentUser, _mapper) = (repository, db, currentUser, mapper);

    public async Task<Result<UnitOfMeasureDto>> Handle(
        UnitOfMeasureSyncDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = UnitOfMeasureSyncRules.Id(request.Id);
        var unit = await _db.UnitOfMeasures
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (unit is null) return Result<UnitOfMeasureDto>.NotFoundResult(request.Id);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified < unit.GetConflictModifiedUtc())
            return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));

        var referenceCount = await _repository.CountReferencesAsync(
            unit.Id,
            cancellationToken);
        if (referenceCount > 0)
            return Result<UnitOfMeasureDto>.FailureResult(
                "UnitOfMeasureInUse",
                $"Unit of measurement is used by {referenceCount} record(s). Reassign them before deleting the unit.");

        unit.SetClientModificationMetadata(modified);
        await _repository.RemoveAsync(unit);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
    }
}

internal static class UnitOfMeasureSyncRules
{
    public static string Id(
        string value
    ) => Guid.Parse(value).ToString("D");

}