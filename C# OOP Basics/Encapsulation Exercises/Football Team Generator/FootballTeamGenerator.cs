using System;
using System.Collections.Generic;

namespace Football_Team_Generator
{
    public class FootballTeamGenerator
    {
        public static void Main()
        {
            var teams = new List<Team>();
            var players = new List<Player>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split(';');
                    var teamName = tokens[1];
                    try
                    {
                        switch (tokens[0])
                        {
                            case "Team":
                                var team = new Team(teamName);
                                teams.Add(team);
                                break;
                            case "Add":
                                var playerName = tokens[2];
                                var endurance = double.Parse(tokens[3]);
                                var sprint = double.Parse(tokens[4]);
                                var dribble = double.Parse(tokens[5]);
                                var passing = double.Parse(tokens[6]);
                                var shooting = double.Parse(tokens[7]);
                                var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                                players.Add(player);
                                if (teams.Exists(t => t.Name.Equals(teamName)))
                                {
                                    teams.Find(t => t.Name.Equals(teamName)).AddPlayer(player);
                                }
                                else
                                {
                                    Console.WriteLine($"Team {teamName} does not exist.");
                                }
                                break;
                            case "Remove":
                                playerName = tokens[2];
                                if (players.Exists(pl => pl.Name.Equals(playerName)))
                                {
                                    var tempPlayer = players.Find(pl => pl.Name.Equals(playerName));
                                    teams.Find(t => t.Name.Equals(teamName)).RemovePlayer(tempPlayer);
                                }
                                else
                                {
                                    Console.WriteLine($"Player {playerName} is not in {teamName} team. ");
                                }
                                break;
                            case "Rating":
                                if (teams.Exists(t => t.Name.Equals(teamName)))
                                {
                                    Console.WriteLine($"{teamName} - {teams.Find(t => t.Name.Equals(teamName)).Rating()}");
                                }
                                else
                                {
                                    Console.WriteLine($"Team {teamName} does not exist.");
                                }
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }

                }
            }
        }
    }
}
