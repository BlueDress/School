using System;
using System.Linq;

namespace Icarus
{
    public class Startup
    {
        public static void Main()
        {
            var plane = Console.ReadLine().Split().Select(int.Parse).ToList();
            var position = int.Parse(Console.ReadLine());
            var damage = 1;

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Supernova"))
                {
                    break;
                }

                var args = input.Split();
                var direction = args[0];
                var steps = int.Parse(args[1]);

                if (direction.Equals("left"))
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (position == 0)
                        {
                            position = plane.Count;
                            damage++;
                        }

                        plane[position - 1] -= damage;
                        position = position - 1;
                    }
                }
                else
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (position == plane.Count - 1)
                        {
                            position = -1;
                            damage++;
                        }

                        plane[position + 1] -= damage;
                        position = position + 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
