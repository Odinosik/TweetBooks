using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Tweetbook.Contracts.V1;
using TweetBook;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        private readonly HttpClient _httpClient;
        public UnitTests()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _httpClient = appFactory.CreateClient();
            
        }

        [Fact]
        public async Task UnitTest1()
        {
            var response = await _httpClient.GetAsync(ApiRoutes.Posts.Get.Replace("{postId}", "1"));
        }
    }
}
