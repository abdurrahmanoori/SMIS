using System.Net;
using Shouldly;
using SMIS.Application.DTO.Users;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class AccountRoleIntegrationTests : BaseIntegrationTest
{
    private readonly ApplicationUserTestDataHelper _dataHelper;

    public AccountRoleIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _dataHelper = new ApplicationUserTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _dataHelper.GetOrCreateDependencies();
    }

    [Fact]
    public async Task Post_AssignRolesToUser_ReturnsOk()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var user = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Post_AssignRolesToUser_CreateUser");
        user.ShouldNotBeNull();

        var roles = new[] { "Admin", "Manager" };
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/{user!.Id}/roles", roles);
        await LogIfError(response, "Post_AssignRolesToUser");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_UserRoles_ReturnsRolesList()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var user = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Get_UserRoles_CreateUser");
        user.ShouldNotBeNull();

        var roles = new[] { "Admin", "User" };
        await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/{user!.Id}/roles", roles);

        var response = await Client.GetAsync($"{ApiEndpoints.Account}/{user.Id}/roles");
        await LogIfError(response, "Get_UserRoles");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var userRoles = await response.Content.ReadFromJsonAsync<IList<string>>();
        userRoles.ShouldNotBeNull();
        userRoles!.Count.ShouldBeGreaterThanOrEqualTo(0);
    }

    [Fact]
    public async Task Delete_RemoveRoleFromUser_ReturnsOk()
    {
        var createDto = _dataHelper.CreateApplicationUserBuilder().Build();
        var user = await PostAndGetAsync<UserDto>(ApiEndpoints.Account, createDto, "Delete_RemoveRoleFromUser_CreateUser");
        user.ShouldNotBeNull();

        var roles = new[] { "Admin", "Manager" };
        await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/{user!.Id}/roles", roles);

        var response = await Client.DeleteAsync($"{ApiEndpoints.Account}/{user.Id}/roles/Manager");
        await LogIfError(response, "Delete_RemoveRoleFromUser");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Post_AssignRolesToNonExistentUser_ReturnsNotFound()
    {
        var roles = new[] { "Admin" };
        var response = await Client.PostAsJsonAsync($"{ApiEndpoints.Account}/non-existent-id/roles", roles);
        await LogIfError(response, "Post_AssignRolesToNonExistentUser");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Get_RolesForNonExistentUser_ReturnsNotFound()
    {
        var response = await Client.GetAsync($"{ApiEndpoints.Account}/non-existent-id/roles");
        await LogIfError(response, "Get_RolesForNonExistentUser");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Delete_RemoveRoleFromNonExistentUser_ReturnsNotFound()
    {
        var response = await Client.DeleteAsync($"{ApiEndpoints.Account}/non-existent-id/roles/Admin");
        await LogIfError(response, "Delete_RemoveRoleFromNonExistentUser");

        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
    }
}