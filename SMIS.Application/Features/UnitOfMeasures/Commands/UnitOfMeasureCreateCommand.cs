using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Features.UnitOfMeasures;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UnitOfMeasureCreateCommand(UnitOfMeasureCreateDto UnitOfMeasureCreateDto)
        : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class UnitOfMeasureCreateCommandHandler
        : IRequestHandler<UnitOfMeasureCreateCommand, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;

        public UnitOfMeasureCreateCommandHandler(
            IApplicationDbContext db,
            IUnitOfMeasureRepository unitOfMeasureRepository
        ) => (_db, _unitOfMeasureRepository) = (db, unitOfMeasureRepository);

        public async Task<Result<UnitOfMeasureDto>> Handle(
            UnitOfMeasureCreateCommand request,
            CancellationToken cancellationToken)
        {
            var dto = request.UnitOfMeasureCreateDto;
            var entity = UnitOfMeasureCommandRules.Create(dto.Name, dto.Symbol, dto.Description);
            await _unitOfMeasureRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result<UnitOfMeasureDto>.Success(UnitOfMeasureMapping.ToDto(entity));
        }
    }
}
