using APIWorkshop;
using APIWorkshop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
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

        [Fact]
        public async Task ReturnOkStatusOnDoUntil()
        {
            var response = await Client.GetAsync("/dountil");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusOnAppendAIsOK()
        {
            var response = await Client.GetAsync("/appenda/{appendable}");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusOnIsUntilIsOK()
        {
            var response = await Client.GetAsync("/dountil/{what}");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResult8WhenMultiply124()
        {
            var operation = new ComplexData
            {
                What = "multiply",
                Numbers = new int?[] { 1, 2, 4 }
            };

            var ops = JsonConvert.SerializeObject(operation);

            var stringContent = new StringContent(ops.ToString(), Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/arrays", stringContent);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":8}", responseJson);
        }
    }
}
