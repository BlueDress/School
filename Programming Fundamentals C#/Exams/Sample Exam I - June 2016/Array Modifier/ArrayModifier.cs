using System;
using System.Linq;

namespace Array_Modifier
{
    public class ArrayModifier
    {
        public static void Main()
        {
            var arrayWithIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                var inputCommands = Console.ReadLine().Split().ToArray();

                if (inputCommands[0].Equals("end"))
                {
                    break;
                }
                else
                {
                    if (inputCommands[0].Equals("swap"))
                    {
                        var firstElement = arrayWithIntegers[int.Parse(inputCommands[1])];
                        var secondElement = arrayWithIntegers[int.Parse(inputCommands[2])];

                        arrayWithIntegers[int.Parse(inputCommands[1])] = secondElement;
                        arrayWithIntegers[int.Parse(inputCommands[2])] = firstElement;
                    }
                    else if (inputCommands[0].Equals("multiply"))
                    {
                        var firstElement = arrayWithIntegers[int.Parse(inputCommands[1])];
                        var secondElement = arrayWithIntegers[int.Parse(inputCommands[2])];

                        arrayWithIntegers[int.Parse(inputCommands[1])] = firstElement * secondElement;
                    }
                    else if (inputCommands[0].Equals("decrease"))
                    {
                        for (int i = 0; i < arrayWithIntegers.Length; i++)
                        {
                            arrayWithIntegers[i] = arrayWithIntegers[i] - 1;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", arrayWithIntegers));
        }
    }
}
