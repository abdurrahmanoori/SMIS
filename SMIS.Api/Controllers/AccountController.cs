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
using SMIS.Api.Authorization;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Handles sign-in, user accounts, passwords, and user roles.
    /// </summary>
    /// <remarks>
    /// Login is public. User administration requires a current SuperAdmin role from the database.
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
            HandleResultResponse(await Mediator.Send(new UserGetCurrentQuery(includeShop)));

        /// <summary>
        /// Gets the current user's effective component permissions.
        /// </summary>
        [Authorize]
        [HttpGet("me/permissions")]
        public async Task<ActionResult<IReadOnlyList<ComponentPermissionDto>>> GetCurrentUserPermissions() =>
            HandleResultResponse(await Mediator.Send(new UserGetPermissionsQuery()));

        /// <summary>
        /// Gets the current user's effective task privileges.
        /// </summary>
        [Authorize]
        [HttpGet("me/task-permissions")]
        public async Task<ActionResult<IReadOnlyList<string>>> GetCurrentUserTaskPermissions() =>
            HandleResultResponse(await Mediator.Send(new UserGetTaskPermissionsQuery()));

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
            HandleResultResponse(await Mediator.Send(new LoginCommand(dto)));

        /// <summary>
        /// Changes the active shop context for a SuperAdmin and returns a fresh
        /// access token whose ShopId claim is the selected shop.
        /// </summary>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpPost("switch-shop")]
        public async Task<ActionResult<LoginResponseDto>> SwitchShop(
            SwitchShopDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new SwitchShopCommand(dto.ShopId)));

        /// <summary>
        /// Reissues the current session so user profile changes such as language
        /// preference are reflected in JWT claims immediately.
        /// </summary>
        [Authorize]
        [HttpPost("refresh-session")]
        public async Task<ActionResult<LoginResponseDto>> RefreshSession() =>
            HandleResultResponse(await Mediator.Send(new RefreshSessionCommand()));

        /// <summary>
        /// Creates a new user account.
        /// </summary>
        [HttpPost("register")]
        [HasCurrentRole(SD.Role_Super_Admin)]
        public async Task<ActionResult<UserDto>> Create(
            UserCreateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new UserCreateCommand(dto)));

        /// <summary>
        /// Gets users in pages.
        /// </summary>
        /// <remarks>
        /// Set <c>includeShop</c> to true when shop information should be included with each user.
        /// </remarks>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpGet]
        public async Task<ActionResult<PagedListNew<UserDto>>> GetAll(
            [FromQuery] UserQueryCriteria criteria,
            [FromQuery] string[]? columns,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25,
            [FromQuery] bool includeShop = false,
            CancellationToken cancellationToken = default
        )
        {
            return await HandleRequest(new UserQuery(
                new EntityDropdown<UserQueryCriteria>
                {
                    Criteria = criteria,
                    Columns = columns,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                },
                includeShop), cancellationToken);
        }

        /// <summary>
        /// Updates an existing user account.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(
            string id,
            UserUpdateDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new UserUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a user account.
        /// </summary>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new UserDeleteCommand(id)));

        /// <summary>
        /// Changes a user's password.
        /// </summary>
        /// <remarks>
        /// The request contains the current password and the new password. The current password must be valid before the change is accepted.
        /// </remarks>
        [HttpPost("{id}/change-password")]
        public async Task<IActionResult> ChangePassword(
            string id,
            ChangePasswordDto dto
        ) =>
            HandleResultResponse(await Mediator.Send(new UserChangePasswordCommand(id, dto)));

        /// <summary>
        /// Resets a managed user's password to the user's current username.
        /// </summary>
        /// <remarks>
        /// A SuperAdmin can reset any user's password. A ShopAdmin can reset passwords only
        /// for users assigned to the same shop. The client does not supply a password;
        /// the server always sets the new password to the target user's current username.
        /// This operation is server-authoritative and does not expose the generated Identity reset token.
        /// </remarks>
        [Authorize]
        [HttpPost("{id}/reset-password")]
        public async Task<IActionResult> ResetPassword(
            string id,
            CancellationToken cancellationToken
        ) =>
            HandleResultResponse(await Mediator.Send(
                new UserAdminResetPasswordCommand(id),
                cancellationToken));

        /// <summary>
        /// Locks a managed user account.
        /// </summary>
        [Authorize]
        [HttpPost("{id}/lock")]
        public async Task<IActionResult> Lock(
            string id,
            CancellationToken cancellationToken
        ) =>
            HandleResultResponse(await Mediator.Send(
                new UserSetLockoutCommand(id, true),
                cancellationToken));

        /// <summary>
        /// Unlocks a managed user account and clears failed sign-in attempts.
        /// </summary>
        [Authorize]
        [HttpPost("{id}/unlock")]
        public async Task<IActionResult> Unlock(
            string id,
            CancellationToken cancellationToken
        ) =>
            HandleResultResponse(await Mediator.Send(
                new UserSetLockoutCommand(id, false),
                cancellationToken));

        /// <summary>
        /// Replaces the complete role list for a user.
        /// </summary>
        /// <remarks>
        /// This is not an "add one role" endpoint. Roles missing from the submitted list are removed, and new names in the list are added.
        /// Submitted roles must be one of the application's configured roles.
        /// </remarks>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpPost("{id}/roles")]
        public async Task<IActionResult> AssignRoles(
            string id,
            [FromBody] IEnumerable<string> roles
        ) =>
            HandleResultResponse(await Mediator.Send(new UserAssignRolesCommand(id, roles)));

        /// <summary>
        /// Gets all roles currently assigned to a user.
        /// </summary>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpGet("{id}/roles")]
        public async Task<ActionResult<IList<string>>> GetUserRoles(
            string id
        ) =>
            HandleResultResponse(await Mediator.Send(new UserGetRolesQuery(id)));

        /// <summary>
        /// Removes one role from a user.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <param name="role">The role name to remove.</param>
        [HasCurrentRole(SD.Role_Super_Admin)]
        [HttpDelete("{id}/roles/{role}")]
        public async Task<IActionResult> RemoveRole(
            string id,
            string role
        ) =>
            HandleResultResponse(await Mediator.Send(new UserRemoveRoleCommand(id, role)));
    }
}