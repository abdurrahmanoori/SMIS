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
    public record CreateCategoryCommand(CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryCreateDto>>;

    internal sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Result<CategoryCreateDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<CategoryCreateDto>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.CategoryCreateDto, _unitOfWork);

            var entity = _mapper.Map<Category>(request.CategoryCreateDto);
            await _categoryRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CategoryCreateDto>.SuccessResult(request.CategoryCreateDto);
        }
    }
}