using System;

namespace Knights_of_Honor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            Action<string> PrintString = x => Console.WriteLine("Sir " + x);

            var tokens = Console.ReadLine().Split();

            for (int i = 0; i < tokens.Length; i++)
            {
                PrintString(tokens[i]);
            }
        }
    }
}
