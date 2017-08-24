using System;

namespace Generic_Box_of_String
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var newString = Console.ReadLine();

                var stringBox = new Box<string>(newString);

                Console.WriteLine(stringBox.ToString());
            }
        }
    }
}
