using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    public class Startup
    {
        public static void Main()
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var barrelSize = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var locksInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var intelligenceValue = int.Parse(Console.ReadLine());


            var bullets = new Stack<int>(bulletsInput);
            var locks = new Queue<int>(locksInput);

            for (int i = 0; i < bulletsInput.Count(); i++)
            {
                if (i % barrelSize == 0 && i != 0)
                {
                    Console.WriteLine("Reloading!");
                }

                if (locks.Count == 0)
                {
                    break;
                }

                if (bullets.Pop() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - ((bulletsInput.Count() - bullets.Count) * bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
