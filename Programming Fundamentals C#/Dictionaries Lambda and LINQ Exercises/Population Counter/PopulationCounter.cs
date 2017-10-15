using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var countryPopulation = new Dictionary<string, long>();
            var countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var inputCommands = Console.ReadLine().Split('|').ToList();
                if (inputCommands[0].Equals("report"))
                {
                    break;
                }
                else
                {
                    var city = inputCommands[0];
                    var country = inputCommands[1];
                    var population = int.Parse(inputCommands[2]);

                    if (!countryPopulation.ContainsKey(country))
                    {
                        countryPopulation[country] = 0;
                    }
                    countryPopulation[country] += population;

                    if (!countryCityPopulation.ContainsKey(country))
                    {
                        countryCityPopulation[country] = new Dictionary<string, long>();
                    }
                    if (!countryCityPopulation[country].ContainsKey(city))
                    {
                        countryCityPopulation[country][city] = 0;
                    }
                    countryCityPopulation[country][city] += population;
                }
            }
            var sortedCountryPopulation = countryPopulation.OrderByDescending(x => x.Value);
            foreach (var country in sortedCountryPopulation)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                foreach (var city in countryCityPopulation[country.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
