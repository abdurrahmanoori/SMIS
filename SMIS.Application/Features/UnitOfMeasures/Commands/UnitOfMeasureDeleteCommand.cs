using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UnitOfMeasureDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class UnitOfMeasureDeleteCommandHandler : IRequestHandler<UnitOfMeasureDeleteCommand, Result<Unit>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;

        public UnitOfMeasureDeleteCommandHandler(
            IApplicationDbContext db,
            IUnitOfMeasureRepository unitOfMeasureRepository
        )
        {
            _db = db;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<Unit>> Handle(
            UnitOfMeasureDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _unitOfMeasureRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request.Id);
            }

            var referenceCount = await _unitOfMeasureRepository.CountReferencesAsync(
                entity.Id,
                cancellationToken);
            if (referenceCount > 0)
                return Result<Unit>.FailureResult(
                    "UnitOfMeasureInUse",
                    $"Unit of measurement is used by {referenceCount} record(s). Reassign them before deleting the unit.");

            entity.ClearClientModificationMetadata();
            await _unitOfMeasureRepository.RemoveAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}