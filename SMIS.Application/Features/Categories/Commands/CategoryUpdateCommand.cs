using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryUpdateCommand(string Id, CategoryUpdateDto CategoryUpdateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        //private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, /*ITranslationKeyRepository translationKeyRepository,*/ ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            //_translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
        {
            //request.CategoryUpdateDto.Name += request.CategoryUpdateDto.Name;
            var entity = await _categoryRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto.Id));
            }

            // Verify user can only update their own shop's categories
            var userShopId = _currentUser.GetShopId();
            if (!_currentUser.IsSuperAdmin() && entity.ShopId != userShopId)
            {
                return Result<CategoryDto>.FailureResult("You can only update categories from your own shop");
            }

            //await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.CategoryUpdateDto, entity);
            
            // Update existing entity using domain methods (ShopId remains unchanged)
            entity.SetName(request.CategoryUpdateDto.Name);
            entity.SetCode(request.CategoryUpdateDto.Code);
            entity.SetDescription(request.CategoryUpdateDto.Description);
            if (request.CategoryUpdateDto.IsActive) entity.Activate(); else entity.Deactivate();
            
            // Preserve original timestamps from mobile sync if provided
            if (request.CategoryUpdateDto.UpdatedDate.HasValue)
                entity.UpdatedDate = request.CategoryUpdateDto.UpdatedDate;
            if (!string.IsNullOrEmpty(request.CategoryUpdateDto.UpdatedBy))
                entity.UpdatedBy = request.CategoryUpdateDto.UpdatedBy;
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<CategoryDto>(entity);
            return Result<CategoryDto>.SuccessResult(dto);
        }
    }
}