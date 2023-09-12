using Models;

namespace ServiceContract
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();

        CityWeather GetWeatherByCityId(String cityCode);
    }
}