using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Laboratory;

namespace SMIS.Application.Features.Laboratory.LabTests.Commands
{
    public record DeleteLabTestCommand(int Id) : IRequest<Result<Unit>>;

    internal sealed class DeleteLabTestCommandHandler : IRequestHandler<DeleteLabTestCommand, Result<Unit>>
    {
        private readonly ILabTestRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteLabTestCommandHandler(IUnitOfWork unitOfWork, ILabTestRepository repo)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
        }

        public async Task<Result<Unit>> Handle(DeleteLabTestCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByIdAsync(request.Id);
            if (entity is null)
            {
                return Result<Unit>.NotFoundResult(request.Id);
            }

            await _repo.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
