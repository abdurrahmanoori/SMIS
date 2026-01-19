using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DeleteDistrictCommand(int Id) : IRequest<Result<Unit>>;

    internal sealed class DeleteDistrictCommandHandler : IRequestHandler<DeleteDistrictCommand, Result<Unit>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteDistrictCommandHandler(IUnitOfWork unitOfWork, IDistrictRepository districtRepository)
        {
            _unitOfWork = unitOfWork;
            _districtRepository = districtRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteDistrictCommand request, CancellationToken cancellationToken)
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(entity?.Id);
            }

            await _districtRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}