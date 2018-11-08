using System;
using Xunit;
using SakilaWebServer.Controllers;
using SakilaWebServer.Models;
using Microsoft.AspNetCore.Mvc;

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
            Assert.NotNull(film);
            Assert.Equal(101, film.Film_ID);
            Assert.Equal("BROTHERHOOD BLANKET", film.Title);
            Assert.Equal("A Fateful Character Study of a Butler And a Technical Writer who must Sink a Astronaut in Ancient Japan", film.Description);
            Assert.Equal("2006", film.Release_Year);
            Assert.Equal("(null)", film.Language_ID);
            Assert.Equal("0", film.Original_Language_ID);
            Assert.Equal("3", film.Rental_Duration);
            Assert.Equal("0.99", film.Rental_Rate);
            Assert.Equal("73", film.Length);
            Assert.Equal("26.99", film.Replacement_Cost);
            Assert.Equal("R", film.Rating);
            Assert.Equal("Behind the Scenes", film.Special_Features);
            Assert.Equal("2006-02-15 05:03:42", film.Last_Update);
        }
    }
}
