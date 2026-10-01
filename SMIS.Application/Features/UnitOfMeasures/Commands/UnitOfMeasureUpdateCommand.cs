using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Features.UnitOfMeasures;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UnitOfMeasureUpdateCommand(string Id, UnitOfMeasureCreateDto UnitOfMeasureCreateDto)
        : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class UnitOfMeasureUpdateCommandHandler
        : IRequestHandler<UnitOfMeasureUpdateCommand, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;

        public UnitOfMeasureUpdateCommandHandler(
            IApplicationDbContext db,
            IUnitOfMeasureRepository unitOfMeasureRepository
        ) => (_db, _unitOfMeasureRepository) = (db, unitOfMeasureRepository);

        public async Task<Result<UnitOfMeasureDto>> Handle(
            UnitOfMeasureUpdateCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _unitOfMeasureRepository.GetByIdAsync(request.Id);
            if (entity == null) return Result<UnitOfMeasureDto>.NotFound(nameof(UnitOfMeasureDto.Id));

            var input = request.UnitOfMeasureCreateDto;
            UnitOfMeasureCommandRules.Apply(entity, input.Name, input.Symbol, input.Description);
            entity.ClearClientModificationMetadata();
            await _db.SaveChangesAsync(cancellationToken);
            return Result<UnitOfMeasureDto>.Success(UnitOfMeasureMapping.ToDto(entity));
        }
    }
}
