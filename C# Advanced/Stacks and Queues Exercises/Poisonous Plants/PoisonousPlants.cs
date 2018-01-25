using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var days = new int[plants.Length];
        var indexStack = new Stack<int>();
        indexStack.Push(0);

        for (int i = 1; i < plants.Length; i++)
        {
            var maxDays = 0;

            while (indexStack.Count > 0 && plants[indexStack.Peek()] >= plants[i])
            {
                maxDays = Math.Max(maxDays, days[indexStack.Pop()]);
            }

            if (indexStack.Count > 0)
            {
                days[i] = maxDays + 1;
            }
            indexStack.Push(i);
        }

        Console.WriteLine(days.Max());
    }
}