using System;
using System.Collections.Generic;

namespace Math_Potato
{
    public class MathPotato
    {
        public static void Main()
        {
            var inputNames = Console.ReadLine().Split();
            var tosses = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(inputNames);
            var cycle = 1;

            while (queue.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    var temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }

                if (PrimeCheck(cycle))
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                else
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                cycle++;
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }

        public static Boolean PrimeCheck(int number)
        {
            if (number == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
