using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryCreateCommand(CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        //private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ICategoryRepository categoryRepository, /*ITranslationKeyRepository translationKeyRepository,*/
            ICurrentUser currentUser
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            //_translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(
            CategoryCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            //await _translationKeyRepository.AddTranslationKeysForEntity(request.CategoryCreateDto, _unitOfWork);
            // Get ShopId from authenticated user (secure)
            var shopId = _currentUser.GetShopId();

            // PowerSync/offline clients create the entity locally first. Accepting
            // their stable ID also makes a retried POST idempotent after a lost
            // response: if the same row already exists, return it instead of
            // creating a duplicate.
            string? clientId = null;
            if (!string.IsNullOrWhiteSpace(request.CategoryCreateDto.Id))
            {
                clientId = Guid.Parse(request.CategoryCreateDto.Id).ToString("D");
                var existing = await _categoryRepository.GetByIdIncludingDeletedAsync(
                    clientId,
                    cancellationToken);

                if (existing is not null)
                {
                    if (!_currentUser.IsSuperAdmin() && existing.ShopId != shopId)
                    {
                        return Result<CategoryDto>.FailureResult(
                            "Forbidden",
                            "You can only create categories for your own shop.");
                    }

                    return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(existing));
                }
            }

            if (await _categoryRepository.NameExistsInShopAsync(
                    shopId,
                    request.CategoryCreateDto.Name,
                    cancellationToken: cancellationToken))
            {
                return Result<CategoryDto>.FailureResult(
                    "CategoryNameAlreadyExists",
                    "A category with this name already exists in this shop.");
            }

            var entity = Category.Create(
                request.CategoryCreateDto.Name,
                shopId,
                request.CategoryCreateDto.Code,
                request.CategoryCreateDto.Description,
                request.CategoryCreateDto.IsActive
            );

            if (clientId is not null)
                entity.Id = clientId;

            await _categoryRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(entity),
                "Category Created Successfully.");
        }
    }
}