using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VecdController : ControllerBase
    {
        // GET
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracings", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<VecdController> _logger;

        public VecdController(ILogger<VecdController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            int i = 0;
            while (true)
            {
                if (i == 10)
                {
                    break;      // Non-Compliant
                }

                Console.WriteLine(i);
                i++;
            }
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = 20,
                    Summary = "test"
                })
                .ToArray();
        }
    }
}