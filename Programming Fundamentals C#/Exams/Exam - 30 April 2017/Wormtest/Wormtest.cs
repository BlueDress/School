using System;

namespace Wormtest
{
    public class Wormtest
    {
        public static void Main()
        {
            var wormLength = int.Parse(Console.ReadLine());
            var wormWidth = double.Parse(Console.ReadLine());

            if (wormWidth == 0)
            {
                Console.WriteLine($"{wormLength * 100 * wormWidth:f2}");
            }
            else
            {
                var reminder = (wormLength * 100) % wormWidth;

                if (!(reminder == 0))
                {
                    Console.WriteLine($"{wormLength * 10000 / wormWidth:f2}%");
                }
                else
                {
                    Console.WriteLine($"{wormLength * 100 * wormWidth:f2}");
                }
            }
        }
    }
}
