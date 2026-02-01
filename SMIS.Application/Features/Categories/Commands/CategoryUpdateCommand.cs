using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryUpdateCommand(string Id, CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<CategoryDto>> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto.Id));
            }

            await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.CategoryCreateDto, entity);
            
            // Update existing entity using domain methods
            entity.SetName(request.CategoryCreateDto.Name);
            entity.SetShopId(request.CategoryCreateDto.ShopId);
            entity.SetCode(request.CategoryCreateDto.Code);
            entity.SetDescription(request.CategoryCreateDto.Description);
            if (request.CategoryCreateDto.IsActive) entity.Activate(); else entity.Deactivate();
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<CategoryDto>(entity);
            return Result<CategoryDto>.SuccessResult(dto);
        }
    }
}