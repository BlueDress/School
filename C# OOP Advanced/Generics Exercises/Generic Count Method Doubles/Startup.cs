using System;

namespace Generic_Count_Method_Doubles
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfDoubles = double.Parse(Console.ReadLine());
            var intBox = new Box<double>();

            for (int i = 0; i < numberOfDoubles; i++)
            {
                var newDouble = double.Parse(Console.ReadLine());
                intBox.Add(newDouble);
            }

            var elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(intBox.CountOfElementsGreater(elementToCompare));
        }
    }
}
