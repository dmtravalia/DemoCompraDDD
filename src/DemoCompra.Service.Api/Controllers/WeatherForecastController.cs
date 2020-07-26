using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCompra.Application.Interfaces;
using DemoCompra.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoCompra.Service.Api.Controllers
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
        private readonly ICompraAppService _compraAppService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ICompraAppService compraAppService)
        {
            _logger = logger;
            _compraAppService = compraAppService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            CompraViewModel c = new CompraViewModel();
            c.Id = Guid.NewGuid();
            c.Quantidade = 10;
            c.Descricao = "Castanha";

            _compraAppService.AdicionarCompra(c);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
