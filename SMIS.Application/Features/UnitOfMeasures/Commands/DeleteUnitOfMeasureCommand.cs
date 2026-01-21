using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record DeleteUnitOfMeasureCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class DeleteUnitOfMeasureCommandHandler : IRequestHandler<DeleteUnitOfMeasureCommand, Result<Unit>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteUnitOfMeasureCommandHandler(IUnitOfWork unitOfWork, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteUnitOfMeasureCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfMeasureRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request.Id);
            }

            await _unitOfMeasureRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
