using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPIBase.NetCore.Requests;

namespace WebAPIBase.NetCore.Controllers
{
    [Route("token")]
    [AllowAnonymous]
    public class TokenController : Controller
    {
        [HttpPost]
        public IActionResult Create()
        {
            var token = Utils.JwtManager.GenerateToken("thiago");
            return Ok(token.Value);
        }
    }
}