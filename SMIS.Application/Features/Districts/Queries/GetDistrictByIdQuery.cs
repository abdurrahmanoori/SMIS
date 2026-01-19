using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record GetDistrictByIdQuery(string PublicId) : IRequest<Result<DistrictDto>>;

    internal sealed class GetDistrictByIdQueryHandler : IRequestHandler<GetDistrictByIdQuery, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly ICurrentUser _currentUser;

        public GetDistrictByIdQueryHandler(IDistrictRepository districtRepository, ICurrentUser currentUser)
        {
            _districtRepository = districtRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<DistrictDto>> Handle(GetDistrictByIdQuery request, CancellationToken cancellationToken)
        {
            var userLangId = _currentUser.GetLangId();

            var district = await _districtRepository.GetAllQueryable()
                .Include(d => d.TranslationKey)
                .ThenInclude(tk => tk.Translations)
                .Where(d => d.PublicId == request.PublicId)
                .Select(d => new DistrictDto
                {
                    Id = d.Id,
                    PublicId = d.PublicId,
                    TranslationKeyId = d.TranslationKeyId,
                    Name = d.TranslationKey.Translations
                        .Where(t => t.LanguageNo == userLangId)
                        .Select(t => t.Name)
                        .FirstOrDefault() ?? d.Name
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (district == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto));
            }

            return Result<DistrictDto>.SuccessResult(district);
        }
    }
}