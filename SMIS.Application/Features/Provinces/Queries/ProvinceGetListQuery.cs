using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Queries
{
    public record ProvinceGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<ProvinceDto>>>;

    internal sealed class ProvinceGetListQueryHandler : IRequestHandler<ProvinceGetListQuery, Result<PagedList<ProvinceDto>>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICurrentUser _currentUser;

        public ProvinceGetListQueryHandler(IProvinceRepository provinceRepository, ICurrentUser currentUser)
        {
            _provinceRepository = provinceRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<PagedList<ProvinceDto>>> Handle(ProvinceGetListQuery request, CancellationToken cancellationToken)
        {
            var userLangId = _currentUser.GetLangId();
            var query = _provinceRepository.GetAllQueryable(includeProperties: nameof(Province.Translations))
                .Select(p => new
                {
                    Province = p,
                    Translation = p.Translations.FirstOrDefault(t => t.LanguageId == userLangId) ??
                                 p.Translations.FirstOrDefault(t => t.IsDefault)
                });

            var pagedEntities = await query.ToPagedList(request.PageNumber, request.PageSize);
            if (pagedEntities.Items.Count == 0)
            {
                return Result<PagedList<ProvinceDto>>.EmptyResult(nameof(ProvinceDto));
            }

            var dtoItems = pagedEntities.Items.Select(item => new ProvinceDto
            {
                Id = item.Province.Id,
                Name = item.Translation?.Name ?? string.Empty
            }).ToList();

            var pagedDto = new PagedList<ProvinceDto>
            {
                PageNumber = pagedEntities.PageNumber,
                PageSize = pagedEntities.PageSize,
                TotalCount = pagedEntities.TotalCount,
                TotalPages = pagedEntities.TotalPages,
                Items = dtoItems
            };

            return Result<PagedList<ProvinceDto>>.SuccessResult(pagedDto);
        }
    }
}
