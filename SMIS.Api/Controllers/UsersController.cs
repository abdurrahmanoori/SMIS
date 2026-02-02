using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Users;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Application.Features.Identity.Users.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseApiController
    {
        [HttpPost]
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
    }
}
