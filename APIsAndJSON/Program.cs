using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            RonVSKanyeAPI.Run();
            Console.WriteLine(); 
            await OpenWeatherMapAPI.Run();
        }
    }
}
