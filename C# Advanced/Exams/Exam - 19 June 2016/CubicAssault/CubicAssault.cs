using System;
using System.Collections.Generic;
using System.Linq;

namespace CubicAssault
{
    public class CubicAssault
    {
        public static void Main()
        {
            var regionsInfo = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Count em all"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                    var region = tokens[0];
                    var meteorType = tokens[1];
                    var amount = int.Parse(tokens[2]);

                    if (!regionsInfo.ContainsKey(region))
                    {
                        regionsInfo[region] = new Dictionary<string, int>();
                        regionsInfo[region]["Black"] = 0;
                        regionsInfo[region]["Red"] = 0;
                        regionsInfo[region]["Green"] = 0;
                    }

                    regionsInfo[region][meteorType] += amount;

                    if (regionsInfo[region]["Green"] >= 1000000)
                    {
                        regionsInfo[region]["Red"] += regionsInfo[region]["Green"] / 1000000;
                        regionsInfo[region]["Green"] = regionsInfo[region]["Green"] % 1000000;
                    }

                    if (regionsInfo[region]["Red"] >= 1000000)
                    {
                        regionsInfo[region]["Black"] += regionsInfo[region]["Red"] / 1000000;
                        regionsInfo[region]["Red"] = regionsInfo[region]["Red"] % 1000000;
                    }
                }
            }

            foreach (var region in regionsInfo.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{region.Key}");

                foreach (var type in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {type.Key} : {type.Value}");
                }
            }
        }
    }
}
