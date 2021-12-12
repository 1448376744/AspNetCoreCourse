using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionSample3.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            /****************************/
            
            //RequestScope?没有，他是通过创建scope并且控制scope的生命周期跟随请求，来实现请求级别的作用域？
            //子容器，该IServiceProvider的scope指的就是本次请求，请求结束socpe释放，由scope创建的对象一起被释放
            //HttpContext.RequestServices;
            //创建httpContext的同时会创建一个Scope，相当于创建了一个子容器，该scope的生命周期等于HttpContext

            /****************************/
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}