using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Commands
{
    public record DeleteShopCommand(string PublicId) : IRequest<Result<Unit>>;

    internal sealed class DeleteShopCommandHandler : IRequestHandler<DeleteShopCommand, Result<Unit>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteShopCommandHandler(IUnitOfWork unitOfWork, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _shopRepository = shopRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteShopCommand request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.GetByIdAsync(request.PublicId);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.PublicId);
            }

            await _shopRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
