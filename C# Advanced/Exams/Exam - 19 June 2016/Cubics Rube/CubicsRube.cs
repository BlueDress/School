using System;
using System.Linq;

namespace Cubics_Rube
{
    public class CubicsRube
    {
        public static void Main()
        {
            var dimensions = int.Parse(Console.ReadLine());
            var rube = new int[dimensions][][];
            var sum = 0;
            var unchangedCells = dimensions * dimensions * dimensions;

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Analyze"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split().Select(int.Parse).ToArray();

                    if (0 <= tokens[0] && tokens[0] < dimensions && 0 <= tokens[1] && tokens[1] < dimensions && 0 <= tokens[2] && tokens[2] < dimensions)
                    {
                        sum += tokens[3];
                        unchangedCells--;
                    }
                }
            }
            Console.WriteLine($"{sum}\n{unchangedCells}");
        }
    }
}
