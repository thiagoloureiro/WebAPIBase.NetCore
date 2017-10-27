using Microsoft.Extensions.Caching.Memory;
using System;
using System.Security.Cryptography;
using Utils.Token;

namespace Utils
{
    public static class JwtManager
    {
        public static JwtToken GenerateToken(string username)
        {
            var hmac = new HMACSHA256();
            var key = Convert.ToBase64String(hmac.Key);

            CacheSecret(username, key);

            var token = new JwtTokenBuilder()
                .AddSecurityKey(JwtSecurityKey.Create("@$TokenPassw0rd2017"))
                .AddSubject("Token Bearer")
                .AddIssuer("WebAPI.Bearer")
                .AddAudience("WebAPI.Bearer")
                .AddClaim("MembershipId", "111")
                .AddExpiry(30)
                .Build();
            return token;
        }

        private static void CacheSecret(string username, string secret)
        {
            var cache = new MemoryCache(new MemoryCacheOptions());
            cache.Set(username, secret);
        }
    }
}