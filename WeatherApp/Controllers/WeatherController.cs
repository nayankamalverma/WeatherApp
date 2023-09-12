using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using Models;

namespace WetherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var cities = _weatherService.GetWeatherDetails();
            if(cities.Count == 0) return Content("No Weather Report avilable!!");
            return View(cities);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult Details(string? cityCode)
        {
            if (string.IsNullOrEmpty(cityCode)) return View();
            CityWeather? city = _weatherService.GetWeatherByCityId(cityCode);
            return View(city);
        }

    }
}
