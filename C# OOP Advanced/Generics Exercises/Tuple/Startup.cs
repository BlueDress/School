using System;

namespace Tuple
{
    public class Startup
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split();
            var firstName = firstInput[0];
            var lastName = firstInput[1];
            var addres = firstInput[2];

            var firstTuple = new Tuple<string, string>(firstName + " " + lastName, addres);

            var secondInput = Console.ReadLine().Split();
            var name = secondInput[0];
            var amountOfLitres = int.Parse(secondInput[1]);

            var secondTuple = new Tuple<string, int>(name, amountOfLitres);

            var thirdInput = Console.ReadLine().Split();
            var intNumber = int.Parse(thirdInput[0]);
            var doubleNumber = double.Parse(thirdInput[1]);

            var thirdTuple = new Tuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine($"{firstTuple.ToString()}");
            Console.WriteLine($"{secondTuple.ToString()}");
            Console.WriteLine($"{thirdTuple.ToString()}");
        }
    }
}
