using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Armada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var numberOfInputs = int.Parse(Console.ReadLine());

            var nameActivity = new Dictionary<string, int>();
            var nameTypeCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(tokens[0]);
                var legionName = tokens[1];
                var soldierType = tokens[2];
                var soldierCount = int.Parse(tokens[3]);

                if (!nameActivity.ContainsKey(legionName))
                {
                    nameActivity[legionName] = int.MinValue;
                }

                if (nameActivity[legionName] < lastActivity)
                {
                    nameActivity[legionName] = lastActivity;
                }

                if (!nameTypeCount.ContainsKey(legionName))
                {
                    nameTypeCount[legionName] = new Dictionary<string, int>();
                }

                if (!nameTypeCount[legionName].ContainsKey(soldierType))
                {
                    nameTypeCount[legionName][soldierType] = 0;
                }

                nameTypeCount[legionName][soldierType] += soldierCount;
            }

            var commands = Console.ReadLine().Split('\\');

            if (commands.Length == 1)
            {
                var soldierType = commands[0];

                foreach (var legion in nameActivity.OrderByDescending(x => x.Value))
                {
                    if (nameTypeCount[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                var lastActivity = int.Parse(commands[0]);
                var soldierType = commands[1];

                var toPrint = new Dictionary<string, int>();

                foreach (var legion in nameTypeCount)
                {
                    if (nameActivity[legion.Key] < lastActivity)
                    {
                        foreach (var soldier in legion.Value)
                        {
                            if (soldier.Key.Equals(soldierType))
                            {
                                toPrint[legion.Key] = soldier.Value;
                            }
                        }
                    }
                }

                foreach (var soldier in toPrint.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{soldier.Key} -> {soldier.Value}");
                }
            }
        }
    }
}
