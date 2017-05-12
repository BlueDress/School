using System;
using System.Collections.Generic;
using System.Linq;

namespace Srubsko_Unleashed
{
    public class SrubskoUnleashed
    {
        public static void Main()
        {
            var venueSingerMoney = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var inputCommands = Console.ReadLine().Split().ToList();

                if (inputCommands[0].Equals("End"))
                {
                    break;
                }

                var ticketCount = 0;
                var ticketPrice = 0;
                var venue = string.Empty;
                var singer = string.Empty;

                if (int.TryParse((inputCommands[inputCommands.Count - 1]), out ticketCount) && int.TryParse((inputCommands[inputCommands.Count - 2]), out ticketPrice) && inputCommands.FindIndex(x => x.StartsWith("@")) > 0)
                {
                    ticketCount = int.Parse(inputCommands[inputCommands.Count - 1]);
                    inputCommands.RemoveAt(inputCommands.Count - 1);

                    ticketPrice = int.Parse(inputCommands[inputCommands.Count - 1]);
                    inputCommands.RemoveAt(inputCommands.Count - 1);

                    var singerVenue = string.Join(" ", inputCommands).Split('@').ToList();

                    singer = singerVenue[0].Remove(singerVenue[0].Length - 1, 1);
                    venue = singerVenue[1];

                    if (!venueSingerMoney.ContainsKey(venue))
                    {
                        venueSingerMoney[venue] = new Dictionary<string, int>();
                    }
                    if (!venueSingerMoney[venue].ContainsKey(singer))
                    {
                        venueSingerMoney[venue][singer] = 0;
                    }
                    venueSingerMoney[venue][singer] += ticketCount * ticketPrice;
                }
            }

            foreach (var venue in venueSingerMoney)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
