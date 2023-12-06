using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weatherapp.Models;
using Weatherapp.Services;

class Program
{
    static async Task Main(string[] args)
    {
        string istanbulApiUrl = "https://goweather.herokuapp.com/weather/istanbul";
        string izmirApiUrl = "https://goweather.herokuapp.com/weather/izmir";
        string ankaraApiUrl = "https://goweather.herokuapp.com/weather/ankara";

        
        var istanbulWeatherService = new WeatherService();
        var izmirWeatherService = new WeatherService();
        var ankaraWeatherService = new WeatherService();

       
        var istanbulWeather = await istanbulWeatherService.GetWeatherAsync(istanbulApiUrl);
        DisplayWeather("Istanbul", istanbulWeather);

       
        var izmirWeather = await izmirWeatherService.GetWeatherAsync(izmirApiUrl);
        DisplayWeather("Izmir", izmirWeather);

        
        var ankaraWeather = await ankaraWeatherService.GetWeatherAsync(ankaraApiUrl);
        DisplayWeather("Ankara", ankaraWeather);
    }

    static void DisplayWeather(string city, Weather weather)
    {
        if (weather != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{city} Weather:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Temperature: {weather.Temperature}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Wind: {weather.Wind}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Description: {weather.Description}");

            Console.WriteLine("Forecast:");
            foreach (var forecast in weather.Forecast)
            {
                Console.WriteLine($"Day {forecast.Day}: Temperature {forecast.Temperature}, Wind {forecast.Wind}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}