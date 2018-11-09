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
                new FilmsControllerTest().FilmTest(film);

            }
        }
    }
}