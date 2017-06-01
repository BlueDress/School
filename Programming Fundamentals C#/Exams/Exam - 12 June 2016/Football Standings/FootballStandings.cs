using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Standings
{
    public class FootballStandings
    {
        public static string ReverseString(string input)
        {
            var reversedInput = input.Reverse();

            var result = new StringBuilder();

            foreach (var item in reversedInput)
            {
                result = result.Append(item);
            }
            return result.ToString();
        }

        public static void Main()
        {
            var key = Console.ReadLine();

            var leagueStandings = new Dictionary<string, int>();
            var scoredGoals = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("final"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split(' ', ':').ToArray();

                    var firstTeamName = tokens[0];
                    var startIndex = firstTeamName.IndexOf(key);
                    var lastIndex = firstTeamName.LastIndexOf(key);
                    firstTeamName = firstTeamName.Substring(startIndex + key.Length, lastIndex - startIndex - key.Length);
                    firstTeamName = ReverseString(firstTeamName);

                    var seconTeamName = tokens[1];
                    startIndex = seconTeamName.IndexOf(key);
                    lastIndex = seconTeamName.LastIndexOf(key);
                    seconTeamName = seconTeamName.Substring(startIndex + key.Length, lastIndex - startIndex - key.Length);
                    seconTeamName = ReverseString(seconTeamName);

                    var firstTeamScore = int.Parse(tokens[2]);
                    var secondTeamScore = int.Parse(tokens[3]);

                    if (firstTeamScore > secondTeamScore)
                    {
                        if (!leagueStandings.ContainsKey(firstTeamName))
                        {
                            leagueStandings[firstTeamName] = 0;
                        }

                        leagueStandings[firstTeamName] += 3;

                        if (!leagueStandings.ContainsKey(seconTeamName))
                        {
                            leagueStandings[seconTeamName] = 0;
                        }
                    }
                    else if (firstTeamScore < secondTeamScore)
                    {
                        if (!leagueStandings.ContainsKey(seconTeamName))
                        {
                            leagueStandings[seconTeamName] = 0;
                        }

                        leagueStandings[seconTeamName] += 3;

                        if (!leagueStandings.ContainsKey(firstTeamName))
                        {
                            leagueStandings[firstTeamName] = 0;
                        }
                    }
                    else
                    {
                        if (!leagueStandings.ContainsKey(firstTeamName))
                        {
                            leagueStandings[firstTeamName] = 0;
                        }

                        leagueStandings[firstTeamName] += 1;

                        if (!leagueStandings.ContainsKey(seconTeamName))
                        {
                            leagueStandings[seconTeamName] = 0;
                        }

                        leagueStandings[seconTeamName] += 1;
                    }

                    if (!scoredGoals.ContainsKey(firstTeamName))
                    {
                        scoredGoals[firstTeamName] = 0;
                    }

                    scoredGoals[firstTeamName] += firstTeamScore;

                    if (!scoredGoals.ContainsKey(seconTeamName))
                    {
                        scoredGoals[seconTeamName] = 0;
                    }

                    scoredGoals[seconTeamName] += secondTeamScore;
                }
            }
            var place = 1;

            Console.WriteLine("League standings:");

            foreach (var team in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in scoredGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
