using System;
using Xunit;
using SakilaWebServer.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SakilaWebServer.Test
{
    public class FilmsControllerEndToEndTest
    {
        [Fact]
        public async void GetFilmByIdSmokeTest()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5000/");
                var acceptType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(acceptType);
                var response = await httpClient.GetAsync("api/films/101");
                string jsonString = null;
                if (response.IsSuccessStatusCode)
                {
                    jsonString = await response.Content.ReadAsStringAsync();
                    Assert.NotNull(jsonString);
                }

                Film film = JsonConvert.DeserializeObject<Film>(jsonString);
                Assert.NotNull(film);
                Assert.Equal(101, film.Film_ID);
                Assert.Equal("BROTHERHOOD BLANKET", film.Title);
                Assert.Equal("A Fateful Character Study of a Butler And a Technical Writer who must Sink a Astronaut in Ancient Japan", film.Description);
                Assert.Equal("2006", film.Release_Year);
                Assert.Equal("1", film.Language_ID);
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
}