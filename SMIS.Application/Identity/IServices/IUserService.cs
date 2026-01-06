using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SMIS.Application.Identity.IServices
{
    public interface IUserService
    {
        Task<Result<Guid>> CreateUserAsync(UserCreateDto input);
        Task<Result<UserDto>> UpdateUserAsync(Guid userId, UserUpdateDto input);
        Task<Result<Unit>> DeleteUserAsync(Guid userId);
        Task<Result<UserDto>> GetByIdAsync(Guid userId);
        Task<Result<List<UserDto>>> GetListAsync();
        Task<Result<Unit>> ChangePasswordAsync(Guid userId, ChangePasswordDto input);
        Task<Result<Unit>> AssignRolesAsync(Guid userId, IEnumerable<string> roles);
    }
}
