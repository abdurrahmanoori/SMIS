using SMIS.Application.DTO.Auth;

namespace SMIS.Application.Identity.IServices;

public interface IPowerSyncTokenGenerator
{
    PowerSyncCredentialsDto Generate(
        string userId,
        string shopId,
        bool isSuperAdmin
    );
}