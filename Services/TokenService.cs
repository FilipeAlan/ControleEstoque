using Entities;
using System;

namespace Services
{
    public class TokenService
    {
        private User User { get; set; }
        private string PrivateKey { get; set; }
        public TokenService(User user, string privateKey)
        {
            PrivateKey = privateKey;
            User = user;
        }
        public string GenerateToken()
        {
            string token = string.Empty;

            return token; 
        }
    }
}
