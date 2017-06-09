using System;
using System.Linq;

namespace Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            var wormholes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var steps = 0;

            for (int i = 0; i < wormholes.Length; i++)
            {
                if (wormholes[i] == 0)
                {
                    steps++;
                }
                else
                {
                    var newIndex = wormholes[i] - 1;
                    wormholes[i] = 0;
                    i = newIndex;
                }
            }

            Console.WriteLine(steps);
        }
    }
}
