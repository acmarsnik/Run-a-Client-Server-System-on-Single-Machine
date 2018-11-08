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
            Assert.Equal(101, actor.Actor_ID);
            Assert.Equal("SUSAN", actor.First_Name);
            Assert.Equal("DAVIS", actor.Last_Name);
        }
    }
}
