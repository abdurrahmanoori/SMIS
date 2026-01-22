using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record DeleteProductUnitCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class DeleteProductUnitCommandHandler : IRequestHandler<DeleteProductUnitCommand, Result<Unit>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductUnitCommandHandler(IUnitOfWork unitOfWork, IProductUnitRepository productUnitRepository)
        {
            _unitOfWork = unitOfWork;
            _productUnitRepository = productUnitRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteProductUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _productUnitRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}