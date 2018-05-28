using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTests.Sample.API.Controllers;
using MSTests.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Web.Http.Results;

namespace MSTests.Sample.API.Tests.Controllers
{
    [TestClass()]
    public class PlayersControllerTest
    {
        public readonly string RootUrl = "http://localhost:56790/api";

        [TestMethod]
        public void PlayersControllerGet()
        {
           var controller = new PlayersController();
            var config = new HttpConfiguration();

            controller.Request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{RootUrl}/Players/"),
                Properties = { { HttpPropertyKeys.HttpConfigurationKey, config } }
            };

            var result = controller.Get();
            Assert.IsNotNull(result);
            var content = ((OkNegotiatedContentResult<List<Player>>)result).Content;
            Assert.IsTrue(content.Count() == 3);
        }

        [TestMethod]
        public void PlayersControllerGetByName()
        {
            var controller = new PlayersController();
            var config = new HttpConfiguration();

            var param = "Jefte27";

            controller.Request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{RootUrl}/Players/"),
                Properties = { { HttpPropertyKeys.HttpConfigurationKey, config } }
            };

            var result = controller.GetByName(param) as OkNegotiatedContentResult<Player>;
            Assert.IsNotNull(result);
            Assert.AreEqual(param, result.Content.Name);
        }
    }
}
