using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.ProductUnits;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceDeleteCommand(string Id) : IRequest<Result<Unit>>;

internal sealed class ProductPriceDeleteCommandHandler : IRequestHandler<ProductPriceDeleteCommand, Result<Unit>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;

    public ProductPriceDeleteCommandHandler(
        IUnitOfWork unitOfWork,
        IProductPriceRepository productPriceRepository,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser)
    {
        _unitOfWork = unitOfWork;
        _productPriceRepository = productPriceRepository;
        _productUnitRepository = productUnitRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<Unit>> Handle(ProductPriceDeleteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _productPriceRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            return Result<Unit>.NotFoundResult(request?.Id);
        }

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            entity.ProductUnitId,
            _productUnitRepository,
            _currentUser);
        if (productUnit is null)
        {
            return Result<Unit>.FailureResult(
                "Forbidden",
                "You cannot delete pricing history for another shop.");
        }

        entity.ClearClientModificationMetadata();
        await _productPriceRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<Unit>.SuccessResult(Unit.Value);
    }
}
