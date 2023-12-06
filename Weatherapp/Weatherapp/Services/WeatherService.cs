using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherapp.Models;

namespace Weatherapp.Services
{
    public class WeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService()
        {
            httpClient = new HttpClient();
        }

        public async Task<Weather> GetWeatherAsync(string apiUrl)
        {
            try
            {
                var response = await httpClient.GetStringAsync(apiUrl);
                var weather = JsonConvert.DeserializeObject<Weather>(response);
                return weather;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
                return null;
            }
        }
    }
}
