using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void Run()
        {
            HttpClient Client = new HttpClient();

            for (int i = 0; i < 5; i++)
            {
                var KanyeResponse = Client.GetStringAsync("https://api.kanye.rest/").Result;
                var KanyeQuote = JObject.Parse(KanyeResponse)["quote"];

                var RonResponse = Client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;
                var RonQuote = JArray.Parse(RonResponse)[0];

                Console.WriteLine($"Kanye: {KanyeQuote}");
                Console.WriteLine($"Ron: {RonQuote}");
            }
        }
    }
}
