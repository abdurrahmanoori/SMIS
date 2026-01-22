using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictUpdateCommand(string Id, DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictUpdateCommandHandler : IRequestHandler<DistrictUpdateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DistrictUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IDistrictRepository districtRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<DistrictDto>> Handle(DistrictUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto.Id));
            }

            _mapper.Map(request.DistrictCreateDto, entity);

            //// Update TranslationKey name
            //if (!string.IsNullOrEmpty(entity.TranslationKeyId))
            //{
            //    var translationKey = await _translationKeyRepository.GetByIdAsync(entity.TranslationKeyId);
            //    if (translationKey != null)
            //    {
            //        translationKey.Name = request.DistrictCreateDto.Name;
            //        await _translationKeyRepository.UpdateAsync(translationKey);
            //    }
            //}

            //await _districtRepository.UpdateAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<DistrictDto>(entity);
            return Result<DistrictDto>.SuccessResult(dto);
        }
    }
}