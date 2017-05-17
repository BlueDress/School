using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_projects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            var teams = new List<Team>();
            var teamsToStay = new List<Team>();
            var teamsToDisband = new List<Team>();

            var numberOfTeams = int.Parse(Console.ReadLine());
            //var teamNumbersCheck = 0;

            //while (teamNumbersCheck < numberOfTeams)
            for (int i = 0; i < numberOfTeams; i++)
            {
                var inputCommands = Console.ReadLine().Split('-').ToList();
                var creator = inputCommands[0];
                var teamName = inputCommands[1];

                if (teams.Any(x => x.Creator == creator) && teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var newTeam = new Team();
                    newTeam.Creator = creator;
                    newTeam.Name = teamName;
                    newTeam.Members = new List<string>();

                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");

                    //teamNumbersCheck++;
                }
            }

            while (true)
            {
                var inputCommands = Console.ReadLine().Split(new char[] {'-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputCommands[0].Equals("end of assignment"))
                {
                    break;
                }
                else
                {
                    var user = inputCommands[0];
                    var teamName = inputCommands[1];

                    if (!teams.Any(x => x.Name == teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                    else if (teams.Any(x => x.Creator == user) || teams.Any(x => x.Members.Contains(user)))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                    else
                    {
                        var tempTeam = teams.First(x => x.Name == teamName);
                        tempTeam.Members.Add(user);
                        tempTeam.Members.Sort();
                    }
                }
            }

            foreach (var team in teams)
            {
                if (team.Members.Count == 0)
                {
                    teamsToDisband.Add(team);
                }
                else
                {
                    teamsToStay.Add(team);
                }
            }

            foreach (var team in teamsToStay.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
