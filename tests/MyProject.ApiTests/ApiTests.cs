using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyProject.ApiTests
{
    public class ApiTests
    {
        private readonly HttpClient _client = new HttpClient();

        [Test]
        public async Task GetWeatherForecast_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("http://localhost:5000/weatherforecast");
            response.EnsureSuccessStatusCode();
            Assert.Pass();
        }
    }
}
