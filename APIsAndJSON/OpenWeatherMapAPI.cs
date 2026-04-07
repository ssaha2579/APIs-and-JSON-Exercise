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

        
        public static async Task Run()
        {
            string apiKey = "9dab9190a96395e0cb20e08e02c2754d";
            string city = "New York";

            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";

            var response = await client.GetStringAsync(url);


            var weatherData = JObject.Parse(response);
            var temp = weatherData["main"]?["temp"];
            var description = weatherData["weather"]?[0]?["description"];

            Console.WriteLine($"Temperature: {temp}");
            Console.WriteLine($"Condition: {description}");
        }
        
    }
}
