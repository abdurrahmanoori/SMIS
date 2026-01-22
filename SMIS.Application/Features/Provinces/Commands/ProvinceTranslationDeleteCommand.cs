using MediatR;
using SMIS.Application.Repositories.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.DTO.Common.Response;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceTranslationDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class ProvinceTranslationDeleteCommandHandler : IRequestHandler<ProvinceTranslationDeleteCommand, Result<Unit>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IUnitOfWork _uow;

        public ProvinceTranslationDeleteCommandHandler(IProvinceRepository repo, IUnitOfWork uow)
        {
            _repo = repo; _uow = uow;
        }

        public async Task<Result<Unit>> Handle(ProvinceTranslationDeleteCommand request, CancellationToken cancellationToken)
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Translations.Any(t => t.Id == request.Id), includeProperties: nameof(Province.Translations));
            if (province is null) return Result<Unit>.NotFoundResult(request.Id);

            var trans = province.Translations.FirstOrDefault(t => t.Id == request.Id);
            if (trans is null) return Result<Unit>.NotFoundResult(request.Id);

            province.Translations.Remove(trans);
            await _uow.SaveChanges(cancellationToken);

            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
