using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var junkLoot = new SortedDictionary<string, int>();
            var legendaryLoot = new SortedDictionary<string, int>();

            legendaryLoot["shards"] = 0;
            legendaryLoot["fragments"] = 0;
            legendaryLoot["motes"] = 0;

            while (legendaryLoot["shards"] < 250 && legendaryLoot["fragments"] < 250 && legendaryLoot["motes"] < 250)
            {
                var inputLoot = Console.ReadLine().ToLower().Split().ToList();

                for (int i = 0; i < inputLoot.Count - 1; i += 2)
                {
                    switch (inputLoot[i + 1])
                    {
                        case "shards":
                            legendaryLoot["shards"] += int.Parse(inputLoot[i]);
                            break;
                        case "fragments":
                            legendaryLoot["fragments"] += int.Parse(inputLoot[i]);
                            break;
                        case "motes":
                            legendaryLoot["motes"] += int.Parse(inputLoot[i]);
                            break;
                        default:
                            if (!junkLoot.ContainsKey(inputLoot[i + 1]))
                            {
                                junkLoot[inputLoot[i + 1]] = 0;
                            }
                            junkLoot[inputLoot[i + 1]] += int.Parse(inputLoot[i]);
                            break;
                    }
                    if (!(legendaryLoot["shards"] < 250 && legendaryLoot["fragments"] < 250 && legendaryLoot["motes"] < 250))
                    {
                        break;
                    }
                }
            }
            if (legendaryLoot["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryLoot["shards"] -= 250;
                foreach (var item in legendaryLoot.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (legendaryLoot["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryLoot["fragments"] -= 250;
                foreach (var item in legendaryLoot.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (legendaryLoot["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryLoot["motes"] -= 250;
                foreach (var item in legendaryLoot.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            foreach (var item in junkLoot)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
