using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {

        public static string InitializeAPIKey()
        {
            Console.WriteLine("We will now collect weather data. Please enter your API key.");
            return Console.ReadLine();
        }

        public static void DisplayWeatherDataFromCity(string apiKey)
        {
            var client = new HttpClient();
            while (true)
            {
                Console.WriteLine("Please enter the city name.");
                var cityName = Console.ReadLine();
                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine(formattedResponse);

                Console.WriteLine("Do you want to continue?");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "no")
                {
                    break;
                }
            }
        }
    }
}