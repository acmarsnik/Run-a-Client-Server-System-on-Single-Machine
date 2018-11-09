using System;
using Xunit;
using SakilaWebServer.Models;
using System.Text.RegularExpressions;

namespace SakilaWebServer.Test
{
    public class FilmsControllerTest
    {
        public void FilmTest(Film film)
        {
            Assert.NotNull(film);
            Assert.Equal(101, film.Film_ID);
            Assert.Equal("BROTHERHOOD BLANKET", film.Title);
            Assert.Equal("A Fateful Character Study of a Butler And a Technical Writer who must Sink a Astronaut in Ancient Japan", film.Description);
            Assert.Equal(2006, film.Release_Year);
            Assert.Equal(1, film.Language_ID);
            Assert.Null(film.Original_Language_ID);
            Assert.Equal(3, film.Rental_Duration);
            Assert.Equal(0.99, film.Rental_Rate);
            Assert.Equal(73, film.Length);
            Assert.Equal(26.99, film.Replacement_Cost);
            Assert.Equal("R", film.Rating);
            Assert.Equal("Behind the Scenes", film.Special_Features);
            var dbLastUpdate = new DateTime(2006, 2, 15, 5, 3, 42);
            var dtLastUpdateCompare = DateTime.Compare(dbLastUpdate, film.Last_Update);
            Assert.Equal(0, dtLastUpdateCompare);
        }
    }
}