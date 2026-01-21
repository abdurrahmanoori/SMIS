using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SMIS.Application.Identity.IServices
{
    public interface IUserService
    {
        Task<Result<string>> CreateUserAsync(UserCreateDto input);
        Task<Result<UserDto>> UpdateUserAsync(string userId, UserUpdateDto input);
        Task<Result<Unit>> DeleteUserAsync(string userId);
        Task<Result<UserDto>> GetByIdAsync(string userId);
        Task<Result<List<UserDto>>> GetListAsync();
        Task<Result<Unit>> ChangePasswordAsync(string userId, ChangePasswordDto input);
        Task<Result<Unit>> AssignRolesAsync(string userId, IEnumerable<string> roles);
    }
}
