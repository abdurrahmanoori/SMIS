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
        public async Task<ActionResult<string>> Create(UserCreateDto dto)
        {
            return HandleResultResponse<string>(await Mediator.Send(new UserCreateCommand(dto)));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(string id, UserUpdateDto dto)
        {
            return HandleResultResponse<UserDto>(await Mediator.Send(new UserUpdateCommand(id, dto)));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new UserDeleteCommand(id)));
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetAll()
        {
            return HandleResultResponse<List<UserDto>>(await Mediator.Send(new UserGetListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(string id)
        {
            return HandleResultResponse<UserDto>(await Mediator.Send(new UserGetByIdQuery(id)));
        }

        [HttpPost("{id}/change-password")]
        public async Task<ActionResult<Unit>> ChangePassword(string id, ChangePasswordDto dto)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new UserChangePasswordCommand(id, dto)));
        }

        [HttpPost("{id}/roles")]
        public async Task<ActionResult<Unit>> AssignRoles(string id, [FromBody] IEnumerable<string> roles)
        {
            return HandleResultResponse<Unit>(await Mediator.Send(new UserAssignRolesCommand(id, roles)));
        }
    }
}
