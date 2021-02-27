namespace WebApiFrankLiu.TokenAuthentication
{
    public interface ITokenManager
    {
        bool Authenticate(string user, string pwd);
        Token GenerateToken();
        bool Verify(string token);
    }
}