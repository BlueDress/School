using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch16P10
{
    public class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = numbers[0];
            int finish = numbers[1];

            Stack<int> steps = new Stack<int>();
            steps.Push(finish);

            Console.WriteLine(FindShortestDistance(start, finish, steps));
        }

        private static string FindShortestDistance(int start, int finish, Stack<int> steps)
        {
            if (finish <= start)
            {
                return "No solution";
            }

            while (true)
            {
                if (steps.Peek() == start)
                {
                    break;
                }

                if (steps.Peek() / 2 >= start)
                {
                    if (steps.Peek() % 2 == 0)
                    {
                        steps.Push(steps.Peek() / 2);
                    }
                    else
                    {
                        steps.Push(steps.Peek() - 1);
                    }
                }
                else if (steps.Peek() - 2 >= start)
                {
                    steps.Push(steps.Peek() - 2);
                }
                else if (steps.Peek() - 1 >= start)
                {
                    steps.Push(steps.Peek() - 1);
                }
            }

            return string.Join(" -> ", steps);
        }
    }
}
