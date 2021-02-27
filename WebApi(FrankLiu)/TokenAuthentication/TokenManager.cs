using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiFrankLiu.TokenAuthentication
{
    public class TokenManager : ITokenManager
    {
        private List<Token> listToken;

        public TokenManager()
        {
            listToken = new List<Token>();
        }

        public bool Verify(string token)
        {
            if (listToken.Any(x => x.Value == token && x.ExpirationDate > System.DateTime.Now))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Authenticate(string user, string pwd)
        {
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pwd) && user.ToLower() == "admin" && pwd == "Password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Token GenerateToken()
        {
            var token = new Token
            {
                Value = Guid.NewGuid().ToString(),
                ExpirationDate = System.DateTime.Now.AddMinutes(1),
            };

            listToken.Add(token);
            return token;
        }
    }
}