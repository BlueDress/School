using System;
using System.Linq;

namespace Min_Even_Number
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Where(x => x % 2 == 0).Min():f2}"); 
            }
            catch (Exception)
            {
                Console.WriteLine("No Match");
            }
        }
    }
}
