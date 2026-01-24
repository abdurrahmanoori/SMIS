using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Queries
{
    public record LanguageGetByIdQuery(string Id) : IRequest<Result<LanguageDto>>;

    internal sealed class LanguageGetByIdQueryHandler : IRequestHandler<LanguageGetByIdQuery, Result<LanguageDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public LanguageGetByIdQueryHandler(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public async Task<Result<LanguageDto>> Handle(LanguageGetByIdQuery request, CancellationToken cancellationToken)
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
