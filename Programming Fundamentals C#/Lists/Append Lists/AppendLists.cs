using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            var output = new List<int>();

            for (int item = 0; item < input.Count; item++)           
            {
                List<string> numbers = input[item].Split(' ').ToList();
                for (int element = 0; element < numbers.Count; element++)
                {
                    if (numbers[element] != string.Empty)
                    {
                        output.Add(int.Parse(numbers[element]));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
