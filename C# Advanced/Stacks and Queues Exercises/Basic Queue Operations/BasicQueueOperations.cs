using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var elementsToPush = commands[0];
            var elementsToPop = commands[1];
            var elementToCheck = commands[2];

            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbers = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                numbers.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Dequeue();
                }
                else
                {
                    break; 
                }
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (numbers.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
