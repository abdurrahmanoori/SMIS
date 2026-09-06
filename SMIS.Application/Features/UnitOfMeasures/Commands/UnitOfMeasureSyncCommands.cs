using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands;

public record UnitOfMeasureSyncCreateCommand(UnitOfMeasureSyncCreateDto Dto) : IRequest<Result<UnitOfMeasureDto>>;
public record UnitOfMeasureSyncUpdateCommand(string Id, UnitOfMeasureSyncUpdateDto Dto) : IRequest<Result<UnitOfMeasureDto>>;
public record UnitOfMeasureSyncDeleteCommand(string Id, UnitOfMeasureSyncDeleteDto Dto) : IRequest<Result<UnitOfMeasureDto>>;

internal sealed class UnitOfMeasureSyncCreateCommandHandler : IRequestHandler<UnitOfMeasureSyncCreateCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository; private readonly IUnitOfWork _unitOfWork; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public UnitOfMeasureSyncCreateCommandHandler(IUnitOfMeasureRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);
    public async Task<Result<UnitOfMeasureDto>> Handle(UnitOfMeasureSyncCreateCommand request, CancellationToken cancellationToken)
    {
        var id = UnitOfMeasureSyncRules.Id(request.Dto.Id); if (!UnitOfMeasureSyncRules.User(request.Dto.ClientCreatedBy, _currentUser) || !UnitOfMeasureSyncRules.User(request.Dto.ClientModifiedBy, _currentUser)) return UnitOfMeasureSyncRules.InvalidUser();
        var unit = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken); var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (unit is not null) { if (!UnitOfMeasureSyncRules.Access(unit, _currentUser)) return UnitOfMeasureSyncRules.Forbidden(); if (modified <= unit.GetConflictModifiedUtc()) return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); UnitOfMeasureSyncRules.Apply(unit, request.Dto); unit.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy); unit.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); unit.Restore(); await _unitOfWork.SaveChanges(cancellationToken); return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); }
        unit = UnitOfMeasure.Create(request.Dto.Name, request.Dto.Symbol, _currentUser.GetShopId(), request.Dto.Description); unit.Id = id; unit.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy); unit.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); await _repository.AddAsync(unit); await _unitOfWork.SaveChanges(cancellationToken); return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit));
    }
}
internal sealed class UnitOfMeasureSyncUpdateCommandHandler : IRequestHandler<UnitOfMeasureSyncUpdateCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository; private readonly IUnitOfWork _unitOfWork; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public UnitOfMeasureSyncUpdateCommandHandler(IUnitOfMeasureRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);
    public async Task<Result<UnitOfMeasureDto>> Handle(UnitOfMeasureSyncUpdateCommand request, CancellationToken cancellationToken)
    { if (!UnitOfMeasureSyncRules.User(request.Dto.ClientModifiedBy, _currentUser)) return UnitOfMeasureSyncRules.InvalidUser(); var unit = await _repository.GetByIdIncludingDeletedAsync(UnitOfMeasureSyncRules.Id(request.Id), cancellationToken); if (unit is null) return Result<UnitOfMeasureDto>.NotFoundResult(request.Id); if (!UnitOfMeasureSyncRules.Access(unit, _currentUser)) return UnitOfMeasureSyncRules.Forbidden(); var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate); if (modified <= unit.GetConflictModifiedUtc()) return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); UnitOfMeasureSyncRules.Apply(unit, request.Dto); unit.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); unit.Restore(); await _unitOfWork.SaveChanges(cancellationToken); return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); }
}
internal sealed class UnitOfMeasureSyncDeleteCommandHandler : IRequestHandler<UnitOfMeasureSyncDeleteCommand, Result<UnitOfMeasureDto>>
{
    private readonly IUnitOfMeasureRepository _repository; private readonly IUnitOfWork _unitOfWork; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public UnitOfMeasureSyncDeleteCommandHandler(IUnitOfMeasureRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);
    public async Task<Result<UnitOfMeasureDto>> Handle(UnitOfMeasureSyncDeleteCommand request, CancellationToken cancellationToken)
    { if (!UnitOfMeasureSyncRules.User(request.Dto.ClientModifiedBy, _currentUser)) return UnitOfMeasureSyncRules.InvalidUser(); var unit = await _repository.GetByIdIncludingDeletedAsync(UnitOfMeasureSyncRules.Id(request.Id), cancellationToken); if (unit is null) return Result<UnitOfMeasureDto>.NotFoundResult(request.Id); if (!UnitOfMeasureSyncRules.Access(unit, _currentUser)) return UnitOfMeasureSyncRules.Forbidden(); var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate); if (modified <= unit.GetConflictModifiedUtc()) return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); unit.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); await _repository.RemoveAsync(unit); await _unitOfWork.SaveChanges(cancellationToken); return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(unit)); }
}
internal static class UnitOfMeasureSyncRules
{
    public static string Id(string value) => Guid.Parse(value).ToString("D"); public static bool User(string? value, ICurrentUser user) => string.IsNullOrWhiteSpace(value) || string.Equals(value.Trim(), user.GetId(), StringComparison.Ordinal); public static bool Access(UnitOfMeasure unit, ICurrentUser user) => user.IsSuperAdmin() || unit.ShopId == user.GetShopId();
    public static void Apply(UnitOfMeasure unit, UnitOfMeasureSyncUpdateDto dto) { unit.SetName(dto.Name); unit.SetSymbol(dto.Symbol); unit.SetDescription(dto.Description); }
    public static Result<UnitOfMeasureDto> InvalidUser() => Result<UnitOfMeasureDto>.FailureResult("InvalidClientUser", "Client user metadata must match the authenticated user."); public static Result<UnitOfMeasureDto> Forbidden() => Result<UnitOfMeasureDto>.FailureResult("Forbidden", "You can only synchronize units from your own shop.");
}
