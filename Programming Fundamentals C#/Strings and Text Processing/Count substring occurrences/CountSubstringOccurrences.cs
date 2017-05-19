using System;

namespace Count_substring_occurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;

            while (true)
            {
                var found = input.IndexOf(pattern, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
