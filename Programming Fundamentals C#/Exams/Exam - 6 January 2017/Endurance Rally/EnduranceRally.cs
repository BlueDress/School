using System;
using System.Linq;

namespace Endurance_Rally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split();
            var trackLayout = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                var fuel = (double)(driver[0]);

                for (int i = 0; i < trackLayout.Length; i++)
                {
                    var isCheckpoint = false;

                    for (int j = 0; j < checkpoints.Length; j++)
                    {
                        if (i == checkpoints[j])
                        {
                            fuel += trackLayout[i];
                            isCheckpoint = true;
                            break;
                        }
                    }

                    if (isCheckpoint == false)
                    {
                        fuel -= trackLayout[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
