using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Karaoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            var songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            var awards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var performance = Console.ReadLine();

                if (performance.Equals("dawn"))
                {
                    break;
                }
                else
                {
                    var tokens = performance.Split(',').Select(x => x.Trim()).ToList();
                    var name = tokens[0];
                    var song = tokens[1];
                    var award = tokens[2];

                    if (participants.Contains(name) && songs.Contains(song))
                    {
                        if (!awards.ContainsKey(name))
                        {
                            awards[name] = new HashSet<string>();
                        }

                        awards[name].Add(award);
                    }
                }
            }

            if (awards.Count > 0)
            {
                foreach (var kvp in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (var award in kvp.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
