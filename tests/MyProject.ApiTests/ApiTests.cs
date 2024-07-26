using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyProject.ApiTests
{
    [TestFixture]
    [Category("API")]
    public class ApiTests
    {
        private readonly HttpClient _client = new HttpClient();

        [Test]
        public async Task GetWeatherForecast_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("http://rikiki.ddns.net:5000/weatherforecast");
            response.EnsureSuccessStatusCode();
            Assert.Pass();
        }
    }
}
