using System;

namespace WebApiFrankLiu.TokenAuthentication
{
    public class Token
    {
        public string Value { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}