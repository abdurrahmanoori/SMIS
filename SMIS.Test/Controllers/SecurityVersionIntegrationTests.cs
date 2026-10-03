using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Shouldly;
using SMIS.Application.DTO.Auth;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public sealed class SecurityVersionIntegrationTests : BaseIntegrationTest
{
    private const string SuperAdminEmail = "superadmin@mainstore.com";

    public SecurityVersionIntegrationTests(
        CustomWebApplicationFactory factory,
        ITestOutputHelper output
    ) : base(factory, output)
    {
    }

    [Fact]
    public async Task Login_TokenContainsSecurityVersion_AndCanAccessProtectedEndpoint()
    {
        var login = await LoginAsync("viewer@mainstore.com");

        ReadSecurityVersion(login.Token).ShouldBeGreaterThanOrEqualTo(0);

        using var response = await SendAuthorizedAsync(
            HttpMethod.Get,
            $"{ApiEndpoints.Account}/me",
            login.Token);

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task LockThenUnlock_InvalidatesOldToken_AndOldTokenDoesNotRevive()
    {
        const string targetEmail = "viewer@branchstore.com";
        var admin = await LoginAsync(SuperAdminEmail);
        var target = await LoginAsync(targetEmail);
        var oldVersion = ReadSecurityVersion(target.Token);

        try
        {
            using (var before = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                before.StatusCode.ShouldBe(HttpStatusCode.OK);
            }

            using (var lockResponse = await SendAuthorizedAsync(
                       HttpMethod.Post,
                       $"{ApiEndpoints.Account}/{target.UserId}/lock",
                       admin.Token))
            {
                lockResponse.IsSuccessStatusCode.ShouldBeTrue();
            }

            using (var oldTokenAfterLock = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                oldTokenAfterLock.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            }

            using (var unlockResponse = await SendAuthorizedAsync(
                       HttpMethod.Post,
                       $"{ApiEndpoints.Account}/{target.UserId}/unlock",
                       admin.Token))
            {
                unlockResponse.IsSuccessStatusCode.ShouldBeTrue();
            }

            using (var oldTokenAfterUnlock = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                oldTokenAfterUnlock.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            }

            var fresh = await LoginAsync(targetEmail);
            ReadSecurityVersion(fresh.Token).ShouldBeGreaterThan(oldVersion);

            using var freshResponse = await SendAuthorizedAsync(
                HttpMethod.Get,
                $"{ApiEndpoints.Account}/me",
                fresh.Token);
            freshResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
        finally
        {
            await EnsureUnlockedAsync(target.UserId, admin.Token);
        }
    }

    [Fact]
    public async Task DeactivateThenReactivate_InvalidatesOldToken_AndOldTokenDoesNotRevive()
    {
        const string targetEmail = "staff@branchstore.com";
        var admin = await LoginAsync(SuperAdminEmail);
        var target = await LoginAsync(targetEmail);
        var oldVersion = ReadSecurityVersion(target.Token);

        try
        {
            using (var deactivateResponse = await SendAuthorizedAsync(
                       HttpMethod.Post,
                       $"{ApiEndpoints.Account}/{target.UserId}/deactivate",
                       admin.Token))
            {
                deactivateResponse.IsSuccessStatusCode.ShouldBeTrue();
            }

            using (var oldTokenAfterDeactivate = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                oldTokenAfterDeactivate.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            }

            using (var reactivateResponse = await SendAuthorizedAsync(
                       HttpMethod.Post,
                       $"{ApiEndpoints.Account}/{target.UserId}/activate",
                       admin.Token))
            {
                reactivateResponse.IsSuccessStatusCode.ShouldBeTrue();
            }

            using (var oldTokenAfterReactivate = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                oldTokenAfterReactivate.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            }

            var fresh = await LoginAsync(targetEmail);
            ReadSecurityVersion(fresh.Token).ShouldBeGreaterThan(oldVersion);

            using var freshResponse = await SendAuthorizedAsync(
                HttpMethod.Get,
                $"{ApiEndpoints.Account}/me",
                fresh.Token);
            freshResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
        finally
        {
            await EnsureActiveAsync(target.UserId, admin.Token);
        }
    }

    [Fact]
    public async Task RoleChange_InvalidatesOldToken_AndFreshTokenUsesNewSecurityVersion()
    {
        const string targetEmail = "cashier@branchstore.com";
        var admin = await LoginAsync(SuperAdminEmail);
        var target = await LoginAsync(targetEmail);
        var oldVersion = ReadSecurityVersion(target.Token);

        try
        {
            using (var changeRoleResponse = await SendAuthorizedJsonAsync(
                       HttpMethod.Post,
                       $"{ApiEndpoints.Account}/{target.UserId}/roles",
                       admin.Token,
                       new[] { "Staff" }))
            {
                changeRoleResponse.IsSuccessStatusCode.ShouldBeTrue();
            }

            using (var oldTokenAfterRoleChange = await SendAuthorizedAsync(
                       HttpMethod.Get,
                       $"{ApiEndpoints.Account}/me",
                       target.Token))
            {
                oldTokenAfterRoleChange.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            }

            var fresh = await LoginAsync(targetEmail);
            ReadSecurityVersion(fresh.Token).ShouldBeGreaterThan(oldVersion);
            fresh.Roles.ShouldContain("Staff");
        }
        finally
        {
            using var restoreResponse = await SendAuthorizedJsonAsync(
                HttpMethod.Post,
                $"{ApiEndpoints.Account}/{target.UserId}/roles",
                admin.Token,
                new[] { "Cashier" });
            restoreResponse.IsSuccessStatusCode.ShouldBeTrue();
        }
    }

    private async Task<LoginResponseDto> LoginAsync(string email)
    {
        using var response = await Client.PostAsJsonAsync(
            $"{ApiEndpoints.Account}/login",
            new LoginDto
            {
                Email = email,
                Password = email
            });

        await LogIfError(response, $"Login {email}");
        response.StatusCode.ShouldBe(HttpStatusCode.OK);

        return await response.Content.ReadFromJsonAsync<LoginResponseDto>()
               ?? throw new InvalidOperationException("Login response was empty.");
    }

    private async Task<HttpResponseMessage> SendAuthorizedAsync(
        HttpMethod method,
        string endpoint,
        string token
    )
    {
        var request = new HttpRequestMessage(method, endpoint);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        return await Client.SendAsync(request);
    }

    private async Task<HttpResponseMessage> SendAuthorizedJsonAsync<T>(
        HttpMethod method,
        string endpoint,
        string token,
        T body
    )
    {
        var request = new HttpRequestMessage(method, endpoint)
        {
            Content = JsonContent.Create(body)
        };
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        return await Client.SendAsync(request);
    }

    private async Task EnsureUnlockedAsync(string userId, string adminToken)
    {
        using var response = await SendAuthorizedAsync(
            HttpMethod.Post,
            $"{ApiEndpoints.Account}/{userId}/unlock",
            adminToken);

        if (!response.IsSuccessStatusCode)
            await LogIfError(response, "Restore unlocked state");
    }

    private async Task EnsureActiveAsync(string userId, string adminToken)
    {
        using var response = await SendAuthorizedAsync(
            HttpMethod.Post,
            $"{ApiEndpoints.Account}/{userId}/activate",
            adminToken);

        if (!response.IsSuccessStatusCode)
            await LogIfError(response, "Restore active state");
    }

    private static int ReadSecurityVersion(string token)
    {
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);
        var value = jwt.Claims
            .Single(claim => claim.Type == "security_version")
            .Value;

        return int.Parse(value);
    }
}
