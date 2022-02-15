using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Caching.Distributed;

namespace RedisTest.Controllers
{
    [Route("api/[controller]")]
    public class RedisController : Controller
    {
        private readonly IDistributedCache _distributedCache;
        public RedisController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        [HttpGet]
        public string Get()
        {
            var cacheKey = "dotnet_core_test_redis";
            var currentTime = DateTime.Now.ToString();
            var cachedTime = _distributedCache.GetString(cacheKey);
            if (string.IsNullOrEmpty(cachedTime))
            {
                // Cache expire trong 5s
                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(60));
                // Nạp lại giá trị mới cho cache
                _distributedCache.SetString(cacheKey, currentTime, options);
                cachedTime = _distributedCache.GetString(cacheKey);
            }
            var result = $"Current Time: {currentTime} \nCached Time: {cachedTime}";
            return result;
        }
    }
}
