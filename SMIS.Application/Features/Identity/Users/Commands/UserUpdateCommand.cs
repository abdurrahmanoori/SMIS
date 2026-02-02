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
    public record UserUpdateCommand(string UserId, UserCreateDto UserCreateDto) : IRequest<Result<UserDto>>;

    public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, Result<UserDto>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IShopRepository _shopRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserUpdateCommandHandler(
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

        public async Task<Result<UserDto>> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<UserDto>.NotFoundResult(request.UserId);

            await _translationKeyRepository.AddTranslationKeysForEntity(request.UserCreateDto, _unitOfWork);

            if (!string.IsNullOrWhiteSpace(request.UserCreateDto.Email)) user.SetEmail(request.UserCreateDto.Email);
            if (!string.IsNullOrWhiteSpace(request.UserCreateDto.PhoneNumber)) user.SetPhoneNumber(request.UserCreateDto.PhoneNumber);
            if (!string.IsNullOrWhiteSpace(request.UserCreateDto.FirstName)) user.SetFirstName(request.UserCreateDto.FirstName);
            if (!string.IsNullOrWhiteSpace(request.UserCreateDto.LastName)) user.SetLastName(request.UserCreateDto.LastName);
            if (!string.IsNullOrWhiteSpace(request.UserCreateDto.ShopId)) user.SetShopId(request.UserCreateDto.ShopId);

            // Update shop name
            var shop = await _shopRepository.GetByIdAsync(user.ShopId);
            user.ShopName = shop?.Name;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                return Result<UserDto>.WithErrors(updateResult.Errors.Select(e => new ValidationError
                {
                    Code = e.Code,
                    Description = e.Description
                }).ToList());
            }

            if (request.UserCreateDto.Roles != null)
            {
                var currentRoles = await _userManager.GetRolesAsync(user);
                var toRemove = currentRoles.Except(request.UserCreateDto.Roles).ToArray();
                var toAdd = request.UserCreateDto.Roles.Except(currentRoles).ToArray();
                
                if (toRemove.Length > 0)
                {
                    var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                    if (!removeResult.Succeeded)
                        return Result<UserDto>.WithErrors(removeResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());
                }
                
                if (toAdd.Length > 0)
                {
                    foreach (var role in toAdd)
                    {
                        if (!await _roleManager.RoleExistsAsync(role))
                            await _roleManager.CreateAsync(new ApplicationRole { Name = role });
                    }
                    var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                    if (!addResult.Succeeded)
                        return Result<UserDto>.WithErrors(addResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());
                }
            }

            return Result<UserDto>.SuccessResult(_mapper.Map<UserDto>(user));
        }
    }
}
