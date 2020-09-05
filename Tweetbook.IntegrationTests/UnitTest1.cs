using System;
using System.Net;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Tweetbook.IntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly HttpClient _client;
        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<>
        }

        [Fact]
        public void TestMethod1()
        {
        }
    }
}
