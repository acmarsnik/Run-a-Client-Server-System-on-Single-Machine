using System;
using Xunit;
using SakilaWebServer.Controllers;
using SakilaWebServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace SakilaWebServer.Test
{
    public class ActorsControllerFunctionTest
    {
        [Fact]
        public void GetActorByIdSmokeTest()
        {
            var controller = new ActorsController();
            var result = controller.Get(101) as OkObjectResult;
            var actor = result.Value as Actor;
            new ActorsControllerTest().ActorTest(actor);
        }
    }
}
