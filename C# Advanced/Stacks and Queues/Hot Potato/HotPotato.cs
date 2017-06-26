using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    public class HotPotato
    {
        public static void Main()
        {
            var inputNames = Console.ReadLine().Split();
            var tosses = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(inputNames);

            while (queue.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    var temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
