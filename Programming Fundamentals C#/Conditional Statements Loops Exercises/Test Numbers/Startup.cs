using System;

namespace Test_Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var combinationsCount = 0;
            var combinationsSum = 0;

            while (true)
            {
                
                for (int i = firstNumber; i > 0; i--)
                {
                    for (int j = 1; j <= secondNumber; j++)
                    {
                        combinationsSum += i * j * 3;
                        combinationsCount++;

                        if (combinationsSum >= maxSum)
                        {
                            Console.WriteLine($"{combinationsCount} combinations");
                            Console.WriteLine($"Sum: {combinationsSum} >= {maxSum}");
                            return;
                        }
                    }
                }

                Console.WriteLine($"{combinationsCount} combinations");
                Console.WriteLine($"Sum: {combinationsSum}");
                break;
            }
        }
    }
}
