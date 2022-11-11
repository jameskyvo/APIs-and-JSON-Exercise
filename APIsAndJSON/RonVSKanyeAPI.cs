using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;
namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void PrintKanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = "Kanye West: " + JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine(kanyeQuote);
        }

        public static void PrintRonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = "Ron Swanson: " + JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine(ronQuote);
        }
        public static void SlowDialogue()
        {
            Random rnd = new Random();
            var lengthOfSilence = (rnd.Next(1, 5) * 1000);
            Console.WriteLine("...");
            Thread.Sleep(lengthOfSilence);
        }
    }
}
