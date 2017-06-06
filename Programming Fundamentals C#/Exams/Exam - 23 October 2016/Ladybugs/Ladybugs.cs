using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] < fieldSize)
                {
                    field[initialIndexes[i]] = 1;
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split();

                if (commands[0].Equals("end"))
                {
                    break;
                }
                else
                {
                    var ladybugIndex = int.Parse(commands[0]);
                    var direction = commands[1];
                    var flyLength = int.Parse(commands[2]);

                    if ((ladybugIndex >= 0 && ladybugIndex < field.Length) && field[ladybugIndex] == 1)
                    {
                        field[ladybugIndex] = 0;

                        if (direction.Equals("right"))
                        {
                            for (long i = ladybugIndex + flyLength; i < field.Length; i += flyLength)
                            {
                                if (field[i] == 0)
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (long i = ladybugIndex - flyLength; i >= 0; i -= flyLength)
                            {
                                if (field[i] == 0)
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
