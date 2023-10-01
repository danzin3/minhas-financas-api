using Microsoft.AspNetCore.Mvc;
using MinhasFinancasApi.Configs;

namespace MinhasFinancasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly EnvVariables _env;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, EnvVariables env)
        {
            _logger = logger;
            _env = env;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Value = _env.CorsOptions.Origins
            })
            .ToArray();
        }
    }
}