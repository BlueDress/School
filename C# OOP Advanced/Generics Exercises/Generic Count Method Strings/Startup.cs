using System;

namespace Generic_Count_Method_Strings
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var stringBox = new Box<string>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                var newString = Console.ReadLine();
                stringBox.Add(newString);
            }

            var elementToCompare = Console.ReadLine();

            Console.WriteLine(stringBox.CountOfElementsGreater(elementToCompare));
        }
    }
}
