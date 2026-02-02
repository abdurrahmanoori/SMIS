using System.Net;
using Shouldly;
using SMIS.Application.DTO.Auth;
using SMIS.Application.DTO.Users;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class AccountAuthIntegrationTests : BaseIntegrationTest
{
    private readonly ApplicationUserTestDataHelper _dataHelper;

    public AccountAuthIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ApplicationUserTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task Post_Register_ValidUser_ReturnsOk()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/register", dto);
        await LogIfError(response, "Post_Register_ValidUser");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var created = await response.Content.ReadFromJsonAsync<UserDto>();
        created.ShouldNotBeNull();
        created!.Email.ShouldBe(dto.Email);
    }

    [Fact]
    public async Task Post_Login_ValidCredentials_ReturnsToken()
    {
        var registerDto = _dataHelper.CreateApplicationUserBuilder().Build();
        await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/register", registerDto);

        var loginDto = new LoginDto
        {
            Email = registerDto.Email,
            Password = registerDto.Password
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        await LogIfError(response, "Post_Login_ValidCredentials");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponseDto>();
        loginResponse.ShouldNotBeNull();
        loginResponse!.Token.ShouldNotBeNullOrEmpty();
        loginResponse.Email.ShouldBe(registerDto.Email);
    }

    [Fact]
    public async Task Post_Login_InvalidCredentials_ReturnsUnauthorized()
    {
        var loginDto = new LoginDto
        {
            Email = "nonexistent@test.com",
            Password = "wrongpassword"
        };

        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        await LogIfError(response, "Post_Login_InvalidCredentials");

        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Post_Register_DuplicateEmail_ReturnsConflict()
    {
        var dto = _dataHelper.CreateApplicationUserBuilder().Build();
        await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/register", dto);

        var duplicateDto = _dataHelper.CreateApplicationUserBuilder().WithEmail(dto.Email).Build();
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/register", duplicateDto);
        await LogIfError(response, "Post_Register_DuplicateEmail");

        (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Conflict).ShouldBeTrue();
    }
}