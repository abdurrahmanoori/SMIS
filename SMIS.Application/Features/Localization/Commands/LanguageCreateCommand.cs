using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Localization.Commands
{
    public record LanguageCreateCommand(LanguageCreateDto LanguageCreateDto) : IRequest<Result<LanguageDto>> { }

    internal sealed class LanguageCreateCommandHandler : IRequestHandler<LanguageCreateCommand, Result<LanguageDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LanguageCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILanguageRepository languageRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<Result<LanguageDto>> Handle(LanguageCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Language>(request.LanguageCreateDto);
            await _languageRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            var dto = _mapper.Map<LanguageDto>(entity);
            return Result<LanguageDto>.SuccessResult(dto);
        }
    }
}
