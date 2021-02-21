using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GlobalHandleException.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            throw new BusinessException("Ops..., An error occurred processing the request");
        }
    }
}
