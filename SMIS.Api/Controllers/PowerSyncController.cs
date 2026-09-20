using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;

namespace SMIS.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public sealed class PowerSyncController : ControllerBase
{
    private readonly ICurrentUser _currentUser;
    private readonly IPowerSyncTokenGenerator _tokenGenerator;

    public PowerSyncController(
        ICurrentUser currentUser,
        IPowerSyncTokenGenerator tokenGenerator
    )
    {
        _currentUser = currentUser;
        _tokenGenerator = tokenGenerator;
    }

    /// <summary>
    /// Exchanges the normal authenticated SMIS session for a short-lived
    /// PowerSync credential. The client does not persist this token.
    /// </summary>
    [HttpGet("credentials")]
    public ActionResult<PowerSyncCredentialsDto> GetCredentials()
    {
        var userId = _currentUser.GetId();
        var shopId = _currentUser.GetShopId();

        if (string.IsNullOrWhiteSpace(userId))
            return Unauthorized();

        if (string.IsNullOrWhiteSpace(shopId))
        {
            return Problem(
                statusCode: StatusCodes.Status403Forbidden,
                title: "A shop context is required for offline synchronization.");
        }

        return Ok(_tokenGenerator.Generate(userId, shopId));
    }
}