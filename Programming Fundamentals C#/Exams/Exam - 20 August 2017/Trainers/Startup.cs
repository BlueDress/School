using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainers
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfParticipants = int.Parse(Console.ReadLine());
            var teamMoney = new Dictionary<string, decimal>();
            teamMoney["Technical"] = 0;
            teamMoney["Theoretical"] = 0;
            teamMoney["Practical"] = 0;

            for (int i = 0; i < numberOfParticipants; i++)
            {
                long distance = int.Parse(Console.ReadLine()) * 1600;
                var cargo = decimal.Parse(Console.ReadLine()) * 1000;
                var moneyEarned = (cargo * 1.5m) - (0.7m * distance * 2.5m);

                var teamName = Console.ReadLine();

                teamMoney[teamName] += moneyEarned;
            }

            var winners = teamMoney.OrderByDescending(x => x.Value).First();

            Console.WriteLine($"The {winners.Key} Trainers win with ${winners.Value:f3}.");
        }
    }
}
