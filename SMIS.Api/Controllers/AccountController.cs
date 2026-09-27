using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Users;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Application.Features.Identity.Users.Queries;
using SMIS.Application.Features.Auth.Commands;
using SMIS.Application.Common.Contants;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Handles sign-in, user accounts, passwords, and user roles.
    /// </summary>
    /// <remarks>
    /// Login and registration can be used without being signed in. Other endpoints require authentication through the API's normal authorization rules.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        /// <summary>
        /// Gets the currently signed-in user.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true when the response should also include the user's shop information.
        /// </remarks>
        [HttpGet("me")]
        public async Task<ActionResult<UserDto>> GetCurrentUser(
            [FromQuery] bool includeShop = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserGetCurrentQuery(includeShop)));

        /// <summary>
        /// Signs in a user and returns the login response.
        /// </summary>
        /// <remarks>
        /// This endpoint is available without authentication and is used to obtain the information needed for later authenticated requests.
        /// </remarks>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponseDto>> Login(
            LoginDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new LoginCommand(dto)));

        /// <summary>
        /// Changes the active shop context for a SuperAdmin and returns a fresh
        /// access token whose ShopId claim is the selected shop.
        /// </summary>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpPost("switch-shop")]
        public async Task<ActionResult<LoginResponseDto>> SwitchShop(
            SwitchShopDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new SwitchShopCommand(dto.ShopId)));

        /// <summary>
        /// Reissues the current session so user profile changes such as language
        /// preference are reflected in JWT claims immediately.
        /// </summary>
        [Authorize]
        [HttpPost("refresh-session")]
        public async Task<ActionResult<LoginResponseDto>> RefreshSession() =>
            HandleResultResponseOld(await Mediator.Send(new RefreshSessionCommand()));

        /// <summary>
        /// Creates a new user account.
        /// </summary>
        /// <remarks>
        /// This endpoint is currently available without authentication.
        /// </remarks>
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> Create(
            UserCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserCreateCommand(dto)));

        /// <summary>
        /// Gets users in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true when shop information should be included with each user.
        /// </remarks>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpGet]
        public async Task<ActionResult<PagedList<UserDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeShop = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserGetListQuery(pageNumber, pageSize, includeShop)));

        /// <summary>
        /// Gets one user by its ID.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true to include the related shop information.
        /// </remarks>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(
            string id,
            [FromQuery] bool includeShop = false
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserGetByIdQuery(id, includeShop)));

        /// <summary>
        /// Updates an existing user account.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(
            string id,
            UserUpdateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a user account.
        /// </summary>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserDeleteCommand(id)));

        /// <summary>
        /// Changes a user's password.
        /// </summary>
        /// <remarks>
        /// The request contains the current password and the new password. The current password must be valid before the change is accepted.
        /// </remarks>
        [HttpPost("{id}/change-password")]
        public async Task<ActionResult<Unit>> ChangePassword(
            string id,
            ChangePasswordDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserChangePasswordCommand(id, dto)));

        /// <summary>
        /// Replaces the complete role list for a user.
        /// </summary>
        /// <remarks>
        /// This is not an "add one role" endpoint. Roles missing from the submitted list are removed, and new names in the list are added.
        /// If a submitted role name does not already exist, the current implementation creates that role before assigning it.
        /// </remarks>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpPost("{id}/roles")]
        public async Task<ActionResult<Unit>> AssignRoles(
            string id,
            [FromBody] IEnumerable<string> roles
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserAssignRolesCommand(id, roles)));

        /// <summary>
        /// Gets all roles currently assigned to a user.
        /// </summary>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpGet("{id}/roles")]
        public async Task<ActionResult<IList<string>>> GetUserRoles(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserGetRolesQuery(id)));

        /// <summary>
        /// Removes one role from a user.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <param name="role">The role name to remove.</param>
        [Authorize(Roles = SD.Role_Super_Admin)]
        [HttpDelete("{id}/roles/{role}")]
        public async Task<ActionResult<Unit>> RemoveRole(
            string id,
            string role
        ) =>
            HandleResultResponseOld(await Mediator.Send(new UserRemoveRoleCommand(id, role)));
    }
}