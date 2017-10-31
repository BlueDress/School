using System;
using System.Collections.Generic;
using System.Linq;

namespace CODE_Phoenix_Oscar_Romeo_November
{
    public class Startup
    {
        public static void Main()
        {
            var squads = new List<Creature>();
            var squadsPower = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Blaze it!"))
                {
                    break;
                }

                var args = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var creatureName = args[0];
                var squadMateName = args[1];

                if (!squads.Any(x => x.Name.Equals(creatureName)))
                {
                    var creature = new Creature(creatureName);
                    squads.Add(creature);
                    squadsPower[creature.Name] = 0;
                }

                var currentCreature = squads.First(x => x.Name.Equals(creatureName));

                if (!currentCreature.SquadMates.Any(x => x.Name.Equals(squadMateName)) && !currentCreature.Name.Equals(squadMateName))
                {
                    currentCreature.SquadMates.Add(new Creature(squadMateName));
                }
            }

            foreach (var squad in squads)
            {
                foreach (var creature in squad.SquadMates)
                {
                    if (!(squads.Any(x => x.Name.Equals(creature.Name)) && squads.First(x => x.Name.Equals(creature.Name)).SquadMates.Any(x => x.Name.Equals(squad.Name))))
                    {
                        squadsPower[squad.Name]++;
                    }
                }
            }

            foreach (var squad in squadsPower.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{squad.Key} : {squad.Value}");
            }
        }
    }
}
