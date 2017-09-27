using System;

namespace Game_of_Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var numberFound = false;
            var lastCombination = string.Empty;
            var numberOfCombinations = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    if (i + j == magicNumber)
                    {
                        numberFound = true;
                        lastCombination = $"{i} + {j}";
                    }
                    numberOfCombinations++;
                }
            }

            if (numberFound)
            {
                Console.WriteLine($"Number found! {lastCombination} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{numberOfCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
