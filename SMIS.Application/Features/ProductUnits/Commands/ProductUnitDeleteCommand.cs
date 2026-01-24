using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class ProductUnitDeleteCommandHandler : IRequestHandler<ProductUnitDeleteCommand, Result<Unit>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductUnitDeleteCommandHandler(IUnitOfWork unitOfWork, IProductUnitRepository productUnitRepository)
        {
            _unitOfWork = unitOfWork;
            _productUnitRepository = productUnitRepository;
        }

        public async Task<Result<Unit>> Handle(ProductUnitDeleteCommand request, CancellationToken cancellationToken)
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