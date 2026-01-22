using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryCreateCommand(CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<CategoryDto>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.CategoryCreateDto, _unitOfWork);

            var entity = _mapper.Map<Category>(request.CategoryCreateDto);
            await _categoryRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(entity));
        }
    }
}