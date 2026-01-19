using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record GetDistrictListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<DistrictDto>>>;

    internal sealed class GetDistrictListQueryHandler : IRequestHandler<GetDistrictListQuery, Result<PagedList<DistrictDto>>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly ICurrentUser _currentUser;

        public GetDistrictListQueryHandler(IDistrictRepository districtRepository, ICurrentUser currentUser)
        {
            _districtRepository = districtRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<PagedList<DistrictDto>>> Handle(GetDistrictListQuery request, CancellationToken cancellationToken)
        {
            var userLangId =  _currentUser.GetLangId();

            var query = _districtRepository.GetAllQueryable()
                .Include(d => d.TranslationKey)
                .ThenInclude(tk => tk.Translations)
                .Select(d => new DistrictDto
                {
                    Id = d.Id,
                    PublicId = d.PublicId,
                    TranslationKeyId = d.TranslationKeyId,
                    Name = d.TranslationKey.Translations
                        .Where(t => t.LanguageNo == userLangId)
                        .Select(t => t.Name)
                        .FirstOrDefault() ?? d.Name
                });

            var pagedEntities = await query.ToPagedList(request.PageNumber, request.PageSize);
            if (pagedEntities.Items.Count == 0)
            {
                return Result<PagedList<DistrictDto>>.EmptyResult(nameof(DistrictDto));
            }

            return Result<PagedList<DistrictDto>>.SuccessResult(pagedEntities);
        }
    }
}