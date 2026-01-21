using MediatR;
using SMIS.Application.Repositories.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;
using SMIS.Application.DTO.Common.Response;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record DeleteProvinceTranslationCommand(string PublicId) : IRequest<Result<Unit>>;

    internal sealed class DeleteProvinceTranslationCommandHandler : IRequestHandler<DeleteProvinceTranslationCommand, Result<Unit>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteProvinceTranslationCommandHandler(IProvinceRepository repo, IUnitOfWork uow)
        {
            _repo = repo; _uow = uow;
        }

        public async Task<Result<Unit>> Handle(DeleteProvinceTranslationCommand request, CancellationToken cancellationToken)
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Translations.Any(t => t.PublicId == request.PublicId), includeProperties: nameof(Province.Translations));
            if (province is null) return Result<Unit>.NotFoundResult(request.PublicId);

            var trans = province.Translations.FirstOrDefault(t => t.PublicId == request.PublicId);
            if (trans is null) return Result<Unit>.NotFoundResult(request.PublicId);

            province.Translations.Remove(trans);
            await _uow.SaveChanges(cancellationToken);

            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
