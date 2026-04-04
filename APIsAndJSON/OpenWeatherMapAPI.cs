using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private static readonly HttpClient client = new HttpClient();
        public static void Run()
        {
            var response = client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?q=New%20York&appid=9dab9190a96395e0cb20e08e02c2754d&units=imperial").Result;
            var weatherData = JObject.Parse(response);
            var temp = weatherData["main"]["temp"];
            var description = weatherData["weather"][0]["description"];
            Console.WriteLine($"Temperature: {temp}");
            Console.WriteLine($"Condition: {description}");
        }
        
    }
}
