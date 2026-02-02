using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserCreateCommand(UserCreateDto UserCreateDto) : IRequest<Result<UserDto>>;

    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, Result<UserDto>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IShopRepository _shopRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserCreateCommandHandler(
            ITranslationKeyRepository translationKeyRepository,
            IShopRepository shopRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _translationKeyRepository = translationKeyRepository;
            _shopRepository = shopRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<UserDto>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.UserCreateDto, _unitOfWork);

            var entity = _mapper.Map<ApplicationUser>(request.UserCreateDto);
            
            // Populate shop name
            var shop = await _shopRepository.GetByIdAsync(request.UserCreateDto.ShopId);
            entity.ShopName = shop?.Name;

            var createResult = await _userManager.CreateAsync(entity, request.UserCreateDto.Password);
            if (!createResult.Succeeded)
            {
                return Result<UserDto>.WithErrors(createResult.Errors.Select(e => new ValidationError
                {
                    Code = e.Code,
                    Description = e.Description
                }).ToList());
            }

            if (request.UserCreateDto.Roles != null)
            {
                foreach (var role in request.UserCreateDto.Roles.Distinct())
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                    {
                        await _roleManager.CreateAsync(new ApplicationRole { Name = role });
                    }
                }
                var addToRoles = await _userManager.AddToRolesAsync(entity, request.UserCreateDto.Roles.Distinct());
                if (!addToRoles.Succeeded)
                {
                    return Result<UserDto>.WithErrors(addToRoles.Errors.Select(e => new ValidationError
                    {
                        Code = e.Code,
                        Description = e.Description
                    }).ToList());
                }
            }

            return Result<UserDto>.SuccessResult(_mapper.Map<UserDto>(entity));
        }
    }
}
