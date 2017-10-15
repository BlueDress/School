using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    public class DragonArmy
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());
            var typeDragonsStats = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                var inputCommands = Console.ReadLine().Split().ToList();

                var type = inputCommands[0];
                var name = inputCommands[1];
                var damage = 0;
                var health = 0;
                var armor = 0;

                if (inputCommands[2].Equals("null"))
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(inputCommands[2]);
                }
                if (inputCommands[3].Equals("null"))
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(inputCommands[3]);
                }
                if (inputCommands[4].Equals("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(inputCommands[4]);
                }

                if (!typeDragonsStats.ContainsKey(type))
                {
                    typeDragonsStats[type] = new SortedDictionary<string, List<int>>();
                }
                if (!typeDragonsStats[type].ContainsKey(name))
                {
                    typeDragonsStats[type][name] = new List<int>();
                }
                typeDragonsStats[type][name].Insert(0, damage);
                typeDragonsStats[type][name].Insert(1, health);
                typeDragonsStats[type][name].Insert(2, armor);
            }

            double damageAverage = 0;
            double healthAverage = 0;
            double armorAverage = 0;


            foreach (var type in typeDragonsStats)
            {
                double tempDamageAverage = 0;
                double tempHealthAverage = 0;
                double tempArmorAverage = 0;

                foreach (var dragon in type.Value)
                {
                    tempDamageAverage += dragon.Value[0];
                    tempHealthAverage += dragon.Value[1];
                    tempArmorAverage += dragon.Value[2];
                }

                damageAverage = tempDamageAverage / type.Value.Count;
                healthAverage = tempHealthAverage / type.Value.Count;
                armorAverage = tempArmorAverage / type.Value.Count;

                Console.WriteLine($"{type.Key}::({Math.Round(damageAverage, 2):f2}/{Math.Round(healthAverage, 2):f2}/{Math.Round(armorAverage, 2):f2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
