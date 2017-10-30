using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    public class Startup
    {
        public static object Rgex { get; private set; }

        public static void Main()
        {
            var citiesWeatherForecast = new Dictionary<string, Dictionary<double, string>>();

            var pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([a-zA-Z]+)\|";

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    break;
                }

                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    var matchedArgs = match.Groups;
                    var cityName = matchedArgs[1].ToString();
                    var averageTemperature = double.Parse(matchedArgs[2].ToString());
                    var typeOfWeather = matchedArgs[3].ToString();

                    if (!citiesWeatherForecast.ContainsKey(cityName))
                    {
                        citiesWeatherForecast[cityName] = new Dictionary<double, string>();
                    }

                    citiesWeatherForecast[cityName].Clear();
                    citiesWeatherForecast[cityName].Add(averageTemperature, typeOfWeather);
                }
            }

            foreach (var city in citiesWeatherForecast.OrderBy(x => x.Value.First().Key))
            {
                Console.WriteLine($"{city.Key} => {city.Value.First().Key:f2} => {city.Value.First().Value}");
            }
        }
    }
}
