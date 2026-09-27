using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class DistrictDeleteCommandHandler : IRequestHandler<DistrictDeleteCommand, Result<Unit>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DistrictDeleteCommandHandler(
            IUnitOfWork unitOfWork,
            IDistrictRepository districtRepository
        )
        {
            _unitOfWork = unitOfWork;
            _districtRepository = districtRepository;
        }

        public async Task<Result<Unit>> Handle(
            DistrictDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _districtRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}