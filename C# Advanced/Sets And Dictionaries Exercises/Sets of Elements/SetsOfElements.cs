using System;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split();
            var lenghtOfFirstSet = int.Parse(commands[0]);
            var lenghtOfSecondSet = int.Parse(commands[1]);

            var firstSet = new SortedSet<int>();
            var repeatedNumbers = new SortedSet<int>();

            for (int i = 0; i < lenghtOfFirstSet; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lenghtOfSecondSet; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (firstSet.Contains(number))
                {
                    repeatedNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", repeatedNumbers));
        }
    }
}
