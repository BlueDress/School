using System;

namespace Ch02P13
{
    public class Startup
    {
        public static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;

            int tempVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = tempVariable;

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
        }
    }
}
