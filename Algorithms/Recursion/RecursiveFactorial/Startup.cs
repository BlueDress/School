using System;

namespace RecursiveFactorial
{
    public class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var numberFactorial = GetFactorial(number);

            Console.WriteLine(numberFactorial);
        }

        private static long GetFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * GetFactorial(--number);
        }
    }
}
