namespace SMIS.Application.DTO.Auth;

public sealed class RefreshTokenRequestDto
{
    public string RefreshToken { get; set; } = string.Empty;
    public string? ShopId { get; set; }
}