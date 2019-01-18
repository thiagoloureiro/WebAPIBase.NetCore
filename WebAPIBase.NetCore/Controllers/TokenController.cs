using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

// This is a Token Example controller to generate the token to your API
// To access use for ex Postman and call: http://localhost:{port}/api/token/auth

namespace WebApplication5.Controllers
{
    [Produces("application/json")]
    [Route("api/Token")]
    public class TokenController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("auth")]
        public object Post(
             [FromServices]SigningConfigurations signingConfigurations,
             [FromServices]TokenConfigurations tokenConfigurations)
        {
            string userId = "userId";

            ClaimsIdentity identity = new ClaimsIdentity(
                       new GenericIdentity(userId, "Login"),
                       new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, userId)
                       }
                   );

            DateTime dtCreation = DateTime.Now;
            DateTime dtExpiration = dtCreation +
                TimeSpan.FromSeconds(tokenConfigurations.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfigurations.Issuer,
                Audience = tokenConfigurations.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dtCreation,
                Expires = dtExpiration
            });
            var token = handler.WriteToken(securityToken);

            return new
            {
                authenticated = true,
                created = dtCreation.ToString("yyyy - MM - dd HH: mm:ss"),
                expiration = dtExpiration.ToString("yyyy - MM - dd HH: mm:ss"),
                accessToken = token,
                message = "OK"
            };

            // case of fail:
            //return new
            //{
            //    authenticated = false,
            //    message = "Fail to authenticate"
            //};
        }
    }
}