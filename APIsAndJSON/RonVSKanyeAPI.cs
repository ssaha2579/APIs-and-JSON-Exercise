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
        private static readonly HttpClient client = new HttpClient();
        public static void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                var KanyeResponse = client.GetStringAsync("https://api.kanye.rest/").Result;
                var KanyeQuote = JObject.Parse(KanyeResponse)["quote"];
                var RonResponse = client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;

                var RonQuote = JArray.Parse(RonResponse)[0];
                Console.WriteLine($"Kanye: {KanyeQuote}");
                Console.WriteLine($"Ron: {RonQuote}");
            }
        }
    }
}
