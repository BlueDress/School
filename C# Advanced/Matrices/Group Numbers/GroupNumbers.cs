using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_Numbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var matrix = new int[3][];
            
            matrix[0] = input.Where(x => x % 3 == 0).ToArray();
            matrix[1] = input.Where(x => x % 3 == 1).ToArray();
            matrix[2] = input.Where(x => x % 3 == 2).ToArray();
            
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

            //-------------------------------------------------------------------------------------

            //var matrix = new int[3][];
            //
            //var reminderZero = new List<int>();
            //var reminderOne = new List<int>();
            //var reminderTwo = new List<int>();
            //
            //for (int i = 0; i < input.Length; i++)
            //{
            //    var reminder = input[i] % 3;
            //
            //    if (reminder == 0)
            //    {
            //        reminderZero.Add(input[i]);
            //    }
            //    else if(reminder == 1)
            //    {
            //        reminderOne.Add(input[i]);
            //    }
            //    else
            //    {
            //        reminderTwo.Add(input[i]);
            //    }
            //}
            //matrix[0] = reminderZero.ToArray();
            //matrix[1] = reminderOne.ToArray();
            //matrix[2] = reminderTwo.ToArray();
            //
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    Console.WriteLine(string.Join(" ", matrix[row]));
            //}

            //-------------------------------------------------------------------------------------

            //var matrix = new Dictionary<int, List<int>>();
            //
            //for (int i = 0; i < input.Length; i++)
            //{
            //    var reminder = input[i] % 3;
            //
            //    if (!matrix.ContainsKey(reminder))
            //    {
            //        matrix[reminder] = new List<int>();
            //    }
            //
            //    matrix[reminder].Add(input[i]);
            //}
            //
            //foreach (var row in matrix)
            //{
            //    Console.WriteLine(string.Join(" ", row.Value));
            //}

            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);
        }
    }
}
