using System;
using System.Collections.Generic;
using System.Linq;

namespace NSA
{
    public class NSA
    {
        public static void Main()
        {
            var countrySpiesDays = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var inputData = Console.ReadLine();

                if (inputData.Equals("quit"))
                {
                    break;
                }
                else
                {
                    var tokens = inputData.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                    var countryName = tokens[0].Trim();
                    var spyName = tokens[1].Trim();
                    var daysInService = int.Parse(tokens[2].Trim());

                    if (!countrySpiesDays.ContainsKey(countryName))
                    {
                        countrySpiesDays[countryName] = new Dictionary<string, long>();
                    }
                    if (!countrySpiesDays[countryName].ContainsKey(spyName))
                    {
                        countrySpiesDays[countryName][spyName] = 0;
                    }

                    countrySpiesDays[countryName][spyName] += daysInService;
                }
            }

            foreach (var country in countrySpiesDays.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
