using System;
using System.Linq;

namespace Trifon_s_Quest
{
    public class TrifonsQuest
    {
        public static void Main()
        {
            var healthPoints = int.Parse(Console.ReadLine());
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var map = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    map[i, j] = input[j];
                }
            }

            var turns = 0;

            for (int i = 0; i < cols; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        switch (map[j,i])
                        {
                            case 'F':
                                healthPoints -= turns / 2;

                                if (healthPoints <= 0)
                                {
                                    Console.WriteLine($"Died at: [{j}, {i}]");
                                    return;
                                }

                                turns++;
                                break;

                            case 'H':
                                healthPoints += turns / 3;
                                turns++;
                                break;

                            case 'T':
                                turns += 3;
                                break;

                            case 'E':
                                turns++;
                                break;
                        }
                    }
                }
                else
                {
                    for (int j = rows - 1; j >= 0; j--)
                    {
                        switch (map[j, i])
                        {
                            case 'F':
                                healthPoints -= turns / 2;

                                if (healthPoints <= 0)
                                {
                                    Console.WriteLine($"Died at: [{j}, {i}]");
                                    return;
                                }

                                turns++;
                                break;

                            case 'H':
                                healthPoints += turns / 3;
                                turns++;
                                break;

                            case 'T':
                                turns += 3;
                                break;

                            case 'E':
                                turns++;
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {healthPoints}");
            Console.WriteLine($"Turns: {turns}");
        }
    }
}
