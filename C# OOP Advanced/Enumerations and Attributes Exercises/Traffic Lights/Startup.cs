using System;
using System.Linq;

namespace Traffic_Lights
{
    public class Startup
    {
        public static void Main()
        {
            var initialStateOfLights = Console.ReadLine().Split().Select(x => new TrafficSignal(x)).ToList();
            var numberOfLightChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLightChanges; i++)
            {
                foreach (var light in initialStateOfLights)
                {
                    light.ChangeLight();
                }

                Console.WriteLine(string.Join(" ", initialStateOfLights));
            }
        }
    }
}
