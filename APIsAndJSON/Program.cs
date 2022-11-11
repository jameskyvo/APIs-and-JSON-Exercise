using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int NUMBEROFTALKS = 5;
            for(int i = 0; i < NUMBEROFTALKS; i++)
            {
                RonVSKanyeAPI.PrintKanyeQuote();
                RonVSKanyeAPI.SlowDialogue();
                RonVSKanyeAPI.PrintRonQuote();
                RonVSKanyeAPI.SlowDialogue();
            }
            // end of kanye assignment

            var apiKey = OpenWeatherMapAPI.InitializeAPIKey();
            OpenWeatherMapAPI.DisplayWeatherDataFromCity(apiKey);
        }

        }
    }
