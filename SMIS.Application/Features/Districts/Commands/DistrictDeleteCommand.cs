using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictDeleteCommand(string Id) : IRequest<Result>;

    internal sealed class DistrictDeleteCommandHandler : IRequestHandler<DistrictDeleteCommand, Result>
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

        public async Task<Result> Handle(
            DistrictDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                return Result.NotFound(request?.Id);
            }

            await _districtRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result.Success();
        }
    }
}