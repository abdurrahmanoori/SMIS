using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
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
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.CategoryCreateDto, _unitOfWork);

            // Get ShopId from authenticated user (secure)
            var shopId = _currentUser.GetShopId();

            var entity = Category.Create(
                request.CategoryCreateDto.Name,
                shopId,
                request.CategoryCreateDto.Code,
                request.CategoryCreateDto.Description,
                request.CategoryCreateDto.IsActive
            );

            // Use client-provided Id if available (offline sync scenario)
            if (!string.IsNullOrEmpty(request.CategoryCreateDto.Id))
            {
                // Check if already exists (idempotent)
                var existing = await _categoryRepository.GetByIdAsync(request.CategoryCreateDto.Id);
                if (existing != null)
                    return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(existing));

                entity.Id = request.CategoryCreateDto.Id;
            }

            await _categoryRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(entity));
        }
    }
}
