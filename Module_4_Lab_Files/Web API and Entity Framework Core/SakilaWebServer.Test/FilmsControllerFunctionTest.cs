using System;
using SakilaWebServer.Controllers;
using SakilaWebServer.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace SakilaWebServer.Test
{
    public class FilmsControllerFunctionTest
    {
        [Fact]
        public void GetFilmByIdSmokeTest()
        {
            var controller = new FilmsController();
            var result = controller.Get(101) as OkObjectResult;
            var film = result.Value as Film;
            new FilmsControllerTest().FilmTest(film);
        }
    }
}
