using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyTimes
{
    public class Startup
    {
        public static void Main()
        {
            var bagCapacity = long.Parse(Console.ReadLine());
            var treasures = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            var currentCapacity = 0L;

            for (int i = 0; i < treasures.Length - 1; i += 2)
            {
                var treasureType = treasures[i];
                var treasureValue = long.Parse(treasures[i + 1]);

                if (currentCapacity + treasureValue > bagCapacity)
                {
                    continue;
                }

                if (treasureType.ToLower().Equals("gold"))
                {
                    if (!bag.ContainsKey("Gold"))
                    {
                        bag["Gold"] = new Dictionary<string, long>
                        {
                            [treasureType] = 0
                        };
                    }

                    bag["Gold"][bag["Gold"].First(x => x.Key.ToLower().Equals(treasureType.ToLower())).Key] += treasureValue;
                    currentCapacity += treasureValue;
                }

                if ((treasureType.Length > 3 && treasureType.ToLower().EndsWith("gem")) && bag.ContainsKey("Gold"))
                {
                    if (!bag.ContainsKey("Gem"))
                    {
                        bag["Gem"] = new Dictionary<string, long>();
                    }

                    if (bag["Gem"].Sum(x => x.Value) + treasureValue <= bag["Gold"].Sum(x => x.Value))
                    {
                        if (!bag["Gem"].Any(x => x.Key.ToLower().Equals(treasureType.ToLower())))
                        {
                            bag["Gem"][treasureType] = 0;
                        }

                        bag["Gem"][bag["Gem"].First(x => x.Key.ToLower().Equals(treasureType.ToLower())).Key] += treasureValue;
                        currentCapacity += treasureValue;
                    }
                }

                if (treasureType.Length == 3 && Char.IsLetter(treasureType[0]) && Char.IsLetter(treasureType[1]) && Char.IsLetter(treasureType[2]) && bag.ContainsKey("Gem"))
                {
                    if (!bag.ContainsKey("Cash"))
                    {
                        bag["Cash"] = new Dictionary<string, long>();
                    }

                    if (bag["Cash"].Sum(x => x.Value) + treasureValue <= bag["Gem"].Sum(x => x.Value))
                    {
                        if (!bag["Cash"].Any(x => x.Key.ToLower().Equals(treasureType.ToLower())))
                        {
                            bag["Cash"][treasureType] = 0;
                        }

                        bag["Cash"][bag["Cash"].First(x => x.Key.ToLower().Equals(treasureType.ToLower())).Key] += treasureValue;
                        currentCapacity += treasureValue;
                    }
                }
            }

            foreach (var treasure in bag.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"<{treasure.Key}> ${treasure.Value.Sum(x => x.Value)}");

                foreach (var item in treasure.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}
