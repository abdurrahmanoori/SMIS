
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Users;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Application.Features.Identity.Users.Queries;
using SMIS.Application.Features.Auth.Commands;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        [HttpGet("me")]
        public async Task<ActionResult<UserDto>> GetCurrentUser([FromQuery] bool includeShop = false) =>
            HandleResultResponse(await Mediator.Send(new UserGetCurrentQuery(includeShop)));

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponseDto>> Login(LoginDto dto) =>
            HandleResultResponse(await Mediator.Send(new LoginCommand(dto)));
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> Create(UserCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UserCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<UserDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25, [FromQuery] bool includeShop = false) =>
            HandleResultResponse(await Mediator.Send(new UserGetListQuery(pageNumber, pageSize, includeShop)));

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(string id, [FromQuery] bool includeShop = false) =>
            HandleResultResponse(await Mediator.Send(new UserGetByIdQuery(id, includeShop)));

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(string id, UserCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new UserUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new UserDeleteCommand(id)));

        [HttpPost("{id}/change-password")]
        public async Task<ActionResult<Unit>> ChangePassword(string id, ChangePasswordDto dto) =>
            HandleResultResponse(await Mediator.Send(new UserChangePasswordCommand(id, dto)));

        [HttpPost("{id}/roles")]
        public async Task<ActionResult<Unit>> AssignRoles(string id, [FromBody] IEnumerable<string> roles) =>
            HandleResultResponse(await Mediator.Send(new UserAssignRolesCommand(id, roles)));

        [HttpGet("{id}/roles")]
        public async Task<ActionResult<IList<string>>> GetUserRoles(string id) =>
            HandleResultResponse(await Mediator.Send(new UserGetRolesQuery(id)));

        [HttpDelete("{id}/roles/{role}")]
        public async Task<ActionResult<Unit>> RemoveRole(string id, string role) =>
            HandleResultResponse(await Mediator.Send(new UserRemoveRoleCommand(id, role)));
    }
}
