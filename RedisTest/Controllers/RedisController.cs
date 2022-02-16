using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Caching.Distributed;
using Nest;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

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
        public async Task<string> GetAsync()
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

            // Để nhờ code Elasticsearch Test
            result += "\nElasticsearch ";
            var connString = "http://localhost:9200";
            var settings = new ConnectionSettings(new Uri(connString))
                .DefaultMappingFor<SearchProductModel>(i => i.IndexName("product"))
                .PrettyJson();
            var client = new ElasticClient(settings);
            var products = new List<SearchProductModel>()
            {
                new SearchProductModel()
                {
                    Id = 1,
                    Name = "Product 1"
                },
                new SearchProductModel()
                {
                    Id = 2,
                    Name = "Product 2"
                },
                new SearchProductModel()
                {
                    Id = 0,
                    Name = "Product 0"
                },
            };
            for (var index = 0; index < products.Count; index++)
            {
                var response = await client.IndexDocumentAsync(products[index]);
                result += "\n" + response.IsValid;
            }
            var resultElasticsearch = await client.SearchAsync<SearchProductModel>(s => s.Query(q => q.MatchAll()));
            var request = new SearchRequest
            {
                From = 0,
                Size = 10,
                Query = new TermQuery { Field = "Id", Value = "1"} ||
                        new MatchQuery { Field = "Name", Query = "Product"}
            };
            result += "\n" + resultElasticsearch.Hits.Count;
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            result += "\n" + JsonSerializer.Serialize(resultElasticsearch, option);
            return result;
        }
    }

    internal class SearchProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
