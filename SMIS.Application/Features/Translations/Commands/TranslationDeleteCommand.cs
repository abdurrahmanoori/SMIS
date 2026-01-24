using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Commands
{
    public record TranslationDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class TranslationDeleteCommandHandler : IRequestHandler<TranslationDeleteCommand, Result<Unit>>
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TranslationDeleteCommandHandler(IUnitOfWork unitOfWork, ITranslationRepository translationRepository)
        {
            _unitOfWork = unitOfWork;
            _translationRepository = translationRepository;
        }

        public async Task<Result<Unit>> Handle(TranslationDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _translationRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _translationRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}