using System.Security.Claims;

namespace WebApiFrankLiu.TokenAuthentication
{
    public interface ITokenManager
    {
        bool Authenticate(string user, string pwd);

        string GenerateToken();

        ClaimsPrincipal Verify(string token);
    }
}