using System;
using System.Collections.Generic;
using System.Linq;

namespace HitList
{
    public class Startup
    {
        public static void Main()
        {
            var targetInfoIndex = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("end transmissions"))
                {
                    break;
                }

                var personInfo = input.Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var personName = personInfo[0];

                if (!people.ContainsKey(personName))
                {
                    people[personName] = new Dictionary<string, string>();
                }

                var personDetails = personInfo.Skip(1);

                foreach (var personDetail in personDetails)
                {
                    var details = personDetail.Split(':');

                    var info = details[0];
                    var value = details[1];

                    if (!people[personName].ContainsKey(info))
                    {
                        people[personName][info] = string.Empty;
                    }

                    people[personName][info] = value;
                }
            }

            var killCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var personToKill = killCommand[1];
            var infoIndex = 0;

            Console.WriteLine($"Info on {personToKill}:");

            foreach (var info in people[personToKill].OrderBy(x => x.Key))
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");
                infoIndex += info.Key.Length + info.Value.Length;
            }

            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetInfoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetInfoIndex - infoIndex} more info.");
            }
        }
    }
}
