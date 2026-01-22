using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.TranslationKeys.Commands
{
    public record TranslationKeyDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class TranslationKeyDeleteCommandHandler : IRequestHandler<TranslationKeyDeleteCommand, Result<Unit>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TranslationKeyDeleteCommandHandler(IUnitOfWork unitOfWork, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<Unit>> Handle(TranslationKeyDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _translationKeyRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _translationKeyRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}