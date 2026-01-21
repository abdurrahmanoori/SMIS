using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Queries
{
    public record GetLanguageByIdQuery(string Id) : IRequest<Result<LanguageDto>>;

    internal sealed class GetLanguageByIdQueryHandler : IRequestHandler<GetLanguageByIdQuery, Result<LanguageDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public GetLanguageByIdQueryHandler(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public async Task<Result<LanguageDto>> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _languageRepository.GetByIdAsync(request.Id);
            if (entity is null)
            {
                return Result<LanguageDto>.NotFoundResult(request.Id);
            }

            var dto = _mapper.Map<LanguageDto>(entity);
            return Result<LanguageDto>.SuccessResult(dto);
        }
    }
}
