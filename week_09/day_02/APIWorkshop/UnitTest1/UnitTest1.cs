using APIWorkshop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest1
{
    public class UnitTest1
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusOnDoubling()
        {
            var response = await Client.GetAsync("/doubling");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusOnGreater()
        {
            var response = await Client.GetAsync("/greater");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusOnAppendA()
        {
            var response = await Client.GetAsync("/appenda");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
