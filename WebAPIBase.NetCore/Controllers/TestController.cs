using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPIBase.NetCore.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        [Authorize("Bearer")]
        [HttpGet]
        public IActionResult Get()
        {
            var dict = new Dictionary<string, string> { { "01", "Spider Man" }, { "02", "Fast and Furious" } };
            return Ok(dict);
        }
    }
}