using System;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    public class Startup
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());

            var numbers = new Queue<int>();
            numbers.Enqueue(firstNumber);

            var firstFiftyMembers = new List<int>();

            while (true)
            {
                if (firstFiftyMembers.Count == 50)
                {
                    break;
                }

                var nextNumber = numbers.Dequeue();

                numbers.Enqueue(nextNumber + 1);
                numbers.Enqueue(2 * nextNumber + 1);
                numbers.Enqueue(nextNumber + 2);

                firstFiftyMembers.Add(nextNumber);
            }

            Console.WriteLine(string.Join(", ", firstFiftyMembers));
        }
    }
}
