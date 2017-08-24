using System;

namespace Threeuple
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split();
            var firstName = firstInput[0];
            var lastName = firstInput[1];
            var addres = firstInput[2];
            var town = firstInput[3];

            var firstThreeuple = new Threeuple<string, string, string>(firstName + " " + lastName, addres, town);

            var secondInput = Console.ReadLine().Split();
            var name = secondInput[0];
            var amountOfLitres = int.Parse(secondInput[1]);
            var drunkOrNot = false;

            if (secondInput[2].Equals("drunk"))
            {
                drunkOrNot = true;
            }

            var secondThreeuple = new Threeuple<string, int, bool>(name, amountOfLitres, drunkOrNot);

            var thirdInput = Console.ReadLine().Split();
            var nameOfBankAccountHolder = thirdInput[0];
            var doubleNumber = double.Parse(thirdInput[1]);
            var bankName = thirdInput[2];

            var thirdThreeuple = new Threeuple<string, double, string>(nameOfBankAccountHolder, doubleNumber, bankName);

            Console.WriteLine($"{firstThreeuple.ToString()}");
            Console.WriteLine($"{secondThreeuple.ToString()}");
            Console.WriteLine($"{thirdThreeuple.ToString()}");
        }
    }
}
