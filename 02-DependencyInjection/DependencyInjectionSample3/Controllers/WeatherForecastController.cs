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
            
            //RequestScope?û�У�����ͨ������scope���ҿ���scope���������ڸ���������ʵ�����󼶱��������
            //����������IServiceProvider��scopeָ�ľ��Ǳ��������������socpe�ͷţ���scope�����Ķ���һ���ͷ�
            //HttpContext.RequestServices;
            //����httpContext��ͬʱ�ᴴ��һ��Scope���൱�ڴ�����һ������������scope���������ڵ���HttpContext

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