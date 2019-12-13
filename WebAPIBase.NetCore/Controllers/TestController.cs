using EasyMemoryCache;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPIBase.API.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        private readonly ICaching _caching;

        public MoviesController(ICaching caching)
        {
            _caching = caching;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public IActionResult Get()
        {
            var CacheKeyName = "dictionary";

            var dict = _caching.GetOrSetObjectFromCache(CacheKeyName, 20, GenerateDictionary);

            _caching.Invalidate(CacheKeyName);
            return Ok(dict);
        }

        private Dictionary<string, string> GenerateDictionary()
        {
            return new Dictionary<string, string> { { "01", "Spider Man" }, { "02", "Fast and Furious" } };
        }
    }
}