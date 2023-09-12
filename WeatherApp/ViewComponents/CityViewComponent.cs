using WetherApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WetherApp.ViewComponents
{
    public class CityViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather city)
        {
            ViewBag.CityCssClass = getBlockColor(city.TemperatureFahrenheit);
            ViewBag.tempInDegC = degFToDegC(city.TemperatureFahrenheit);
            return View(city);
        }



        private string getBlockColor(int temp)
        {
            if (temp < 44) return "blue-back";
            else if (temp >= 44 && temp <= 75) return "green-back";
            return "orange-back";
        }

        private int degFToDegC(int temp)
        {
            return (temp - 32) * 5 / 9;
        }
    } 
}
