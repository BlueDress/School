using System;
using System.Linq;

namespace Search_for_a_Number
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var args = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elementsToTake = args[0];
            var elementsToSkip = args[1];
            var elementToSearchFor = args[2];
            
            if (numbers.Take(elementsToTake).Skip(elementsToSkip).Any(n => n == elementToSearchFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
