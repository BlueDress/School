using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Element
{
    public class MaximumElement
    {
        public static void Main()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            var numbers = new Stack<int>();
            var maxNumbers = new Stack<int>();

            var maxCheck = int.MinValue;

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var typeOfCommand = commands[0];

                switch (typeOfCommand)
                {
                    case "1":
                        numbers.Push(int.Parse(commands[1]));

                        if (maxCheck < int.Parse(commands[1]))
                        {
                            maxCheck = int.Parse(commands[1]);
                            maxNumbers.Push(maxCheck);
                        }
                        break;
                    case "2":
                        if (numbers.Pop() == maxCheck)
                        {
                            maxNumbers.Pop();

                            if (maxNumbers.Count != 0)
                            {
                                maxCheck = maxNumbers.Peek();
                            }
                            else
                            {
                                maxCheck = int.MinValue;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine(maxCheck);
                        break;
                }
            }
        }
    }
}
