using System;
using System.Collections.Generic;
using System.Linq;

namespace Map_Districts
{
    public class MapDistricts
    {
        public static void Main()
        {
            var cityDistrictPopulation = Console.ReadLine().Split();
            var minPopulation = int.Parse(Console.ReadLine());

            var cityPopulation = new Dictionary<string, List<int>>();

            for (int i = 0; i < cityDistrictPopulation.Length; i++)
            {
                var tokens = cityDistrictPopulation[i].Split(':');
                var city = tokens[0];
                var population = int.Parse(tokens[1]);

                if (!cityPopulation.ContainsKey(city))
                {
                    cityPopulation[city] = new List<int>();
                }

                cityPopulation[city].Add(population);
            }

            foreach (var city in cityPopulation.Where(x => x.Value.Sum() >= minPopulation).OrderByDescending(x => x.Value.Sum()))
            {
                Console.WriteLine($"{city.Key}: {string.Join(" ", city.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}
