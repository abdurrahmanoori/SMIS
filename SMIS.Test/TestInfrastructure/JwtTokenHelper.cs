using System.Net;
using System.Net.Http.Json;
using SMIS.Application.DTO.Auth;
using SMIS.Test.Utilities;

namespace SMIS.Test.TestInfrastructure;

public class JwtTokenHelper
{
    private readonly HttpClient _client;

    public JwtTokenHelper(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetTokenAsync(string email = "wadmin@smis.com", string password = "Pass123!")
    {
        var loginDto = new LoginDto
        {
            Email = email,
            Password = password
        };

        var response = await _client.PostAsJsonAsync($"{ApiEndpoints.Account}/login", loginDto);
        
        if (response.StatusCode != HttpStatusCode.OK)
            throw new InvalidOperationException($"Failed to login: {response.StatusCode}");

        var loginResult = await response.Content.ReadFromJsonAsync<LoginResponseDto>();
        return loginResult?.Token ?? throw new InvalidOperationException("Token is null");
    }

    public async Task SetAuthorizationHeaderAsync(string email = "superadmin@smis.com", string password = "Pass123!")
    {
        var token = await GetTokenAsync(email, password);
        _client.DefaultRequestHeaders.Clear();
        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
    }
}