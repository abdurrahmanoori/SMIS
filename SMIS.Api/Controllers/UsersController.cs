using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common.Response;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Application.Features.Identity.Users.Queries;
using SMIS.Application.Identity.Models;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseApiController
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Guid>> Create(UserCreateDto dto)
        {
            return HandleResultResponse<Guid>(await Mediator.Send(new CreateUserCommand(dto)));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(Guid id, UserUpdateDto dto)
        {
            return HandleResultResponse<UserDto>(await Mediator.Send(new UpdateUserCommand(id, dto)));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new DeleteUserCommand(id)));
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetAll()
        {
            return HandleResultResponse<List<UserDto>>(await Mediator.Send(new GetUserListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(Guid id)
        {
            return HandleResultResponse<UserDto>(await Mediator.Send(new GetUserByIdQuery(id)));
        }

        [HttpPost("{id}/change-password")]
        public async Task<ActionResult<Unit>> ChangePassword(Guid id, ChangePasswordDto dto)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new ChangePasswordCommand(id, dto)));
        }

        [HttpPost("{id}/roles")]
        public async Task<ActionResult<Unit>> AssignRoles(Guid id, [FromBody] IEnumerable<string> roles)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new AssignRolesCommand(id, roles)));
        }
    }
}
