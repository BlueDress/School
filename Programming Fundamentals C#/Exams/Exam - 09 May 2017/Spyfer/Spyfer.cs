using System;
using System.Linq;

namespace Spyfer
{
    public class Spyfer
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i - 1] + sequence[i + 1])
                {
                    sequence.RemoveAt(i + 1);
                    sequence.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
