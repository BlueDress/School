using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Aggregation
{
    public class PopulationAggregation
    {
        public static void Main()
        {
            var prohibitedSymbols = new char[] { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var countryNumberOfCities = new SortedDictionary<string, int>();
            var cityPopulation = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0].Equals("stop"))
                {
                    break;
                }
                else
                {
                    input[0] = string.Join("", input[0].Split(prohibitedSymbols, StringSplitOptions.RemoveEmptyEntries));
                    input[1] = string.Join("", input[1].Split(prohibitedSymbols, StringSplitOptions.RemoveEmptyEntries));

                    if (input[0].Equals(input[0].ToLower()))
                    {
                        cityPopulation[input[0]] = int.Parse(input[2]);

                        if (!countryNumberOfCities.ContainsKey(input[1]))
                        {
                            countryNumberOfCities[input[1]] = 0;
                        }

                        countryNumberOfCities[input[1]]++;
                    }
                    else
                    {
                        cityPopulation[input[1]] = int.Parse(input[2]);

                        if (!countryNumberOfCities.ContainsKey(input[0]))
                        {
                            countryNumberOfCities[input[0]] = 0;
                        }
                        countryNumberOfCities[input[0]]++;
                    }
                }
            }

            foreach (var country in countryNumberOfCities)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }
            foreach (var city in cityPopulation.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
            }
        }
    }
}
