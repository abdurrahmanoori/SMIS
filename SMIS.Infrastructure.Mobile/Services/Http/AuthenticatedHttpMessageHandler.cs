using SMIS.Infrastructure.Mobile.Services.Auth;

namespace SMIS.Infrastructure.Mobile.Services.Http;

public class AuthenticatedHttpMessageHandler : DelegatingHandler
{
    private readonly ITokenStorage _tokenStorage;

    public AuthenticatedHttpMessageHandler(ITokenStorage tokenStorage)
    {
        _tokenStorage = tokenStorage;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _tokenStorage.GetTokenAsync();
        
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
