using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] inputCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int item = 0; item < inputNumbers.Count; item++)
            {
                if (inputCommands[0] == inputNumbers[item])
                {
                    if (inputCommands[1] <= item && inputCommands[1] <= inputNumbers.Count - 1 - item)
                    {
                        for (int i = item + inputCommands[1]; i >= item - inputCommands[1]; i--)
                        {
                            inputNumbers.RemoveAt(i);
                        }
                    }
                    else if (inputCommands[1] > item && inputCommands[1] <= inputNumbers.Count - 1 - item)
                    {
                        for (int i = item + inputCommands[1]; i >= 0; i--)
                        {
                            inputNumbers.RemoveAt(i);
                        }
                    }
                    else if (inputCommands[1] <= item && inputCommands[1] > inputNumbers.Count - 1 - item)
                    {
                        for (int i = inputNumbers.Count - 1; i >= item - inputCommands[1]; i--)
                        {
                            inputNumbers.RemoveAt(i);
                        }
                    }
                    else if (inputCommands[1] > item && inputCommands[1] > inputNumbers.Count - 1 - item)
                    {
                        for (int i = inputNumbers.Count - 1; i >= 0; i--)
                        {
                            inputNumbers.RemoveAt(i);
                        }
                    }

                    item = -1;
                }
            }

            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
