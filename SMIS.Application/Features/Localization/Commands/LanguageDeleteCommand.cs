using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Commands
{
    public record LanguageDeleteCommand(string Id) : IRequest<Result>
    {
    }

    internal sealed class LanguageDeleteCommandHandler : IRequestHandler<LanguageDeleteCommand, Result>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LanguageDeleteCommandHandler(
            IUnitOfWork unitOfWork,
            ILanguageRepository languageRepository
        )
        {
            _unitOfWork = unitOfWork;
            _languageRepository = languageRepository;
        }

        public async Task<Result> Handle(
            LanguageDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _languageRepository.GetByIdAsync(request.Id);
            if (entity is null)
            {
                return Result.NotFound(request.Id);
            }

            await _languageRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result.Success();
        }
    }
}