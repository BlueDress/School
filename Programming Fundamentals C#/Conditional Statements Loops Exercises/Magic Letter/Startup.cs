using System;

namespace Magic_Letter
{
    public class Startup
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var letterToExclude = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (!i.Equals(letterToExclude) && !j.Equals(letterToExclude) && !k.Equals(letterToExclude))
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
