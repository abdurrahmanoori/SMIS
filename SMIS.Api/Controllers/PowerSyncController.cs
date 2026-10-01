using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Errors;
using SMIS.Application.Common.Response;
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
        {
            var problem = ApiProblemDetailsFactory.Create(
                HttpContext,
                new[] { Error.Unauthorized("auth.unauthorized", "Authentication is required.") });
            return StatusCode(problem.Status!.Value, problem);
        }

        if (string.IsNullOrWhiteSpace(shopId))
        {
            var problem = ApiProblemDetailsFactory.Create(
                HttpContext,
                new[]
                {
                    Error.Forbidden(
                        "sync.shop_context_required",
                        "A shop context is required for offline synchronization.")
                });
            return StatusCode(problem.Status!.Value, problem);
        }

        return Ok(_tokenGenerator.Generate(userId, shopId, _currentUser.IsSuperAdmin()));
    }
}