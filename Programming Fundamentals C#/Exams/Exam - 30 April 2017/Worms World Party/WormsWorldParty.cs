using System;
using System.Collections.Generic;
using System.Linq;

namespace Worms_World_Party
{
    public class WormsWorldParty
    {
        public static void Main()
        {
            var teamScore = new Dictionary<string, List<int>>();
            var teamWormsScore = new Dictionary<string, Dictionary<string, int>>();
            var worms = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("quit"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                    var wormName = tokens[0].Trim();
                    var teamName = tokens[1].Trim();
                    var wormScore = int.Parse(tokens[2].Trim());

                    if (!worms.Contains(wormName))
                    {
                        worms.Add(wormName);

                        if (!teamScore.ContainsKey(teamName))
                        {
                            teamScore[teamName] = new List<int>();
                            teamWormsScore[teamName] = new Dictionary<string, int>();
                        }

                        teamScore[teamName].Add(wormScore);

                        teamWormsScore[teamName][wormName] = wormScore;
                    }
                }
            }

            var place = 1;

            foreach (var team in teamScore.OrderByDescending(x => x.Value.Sum()).ThenByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{place}. Team: {team.Key} - {team.Value.Sum()}");

                foreach (var worm in teamWormsScore[team.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }

                place++;
            }
        }
    }
}
