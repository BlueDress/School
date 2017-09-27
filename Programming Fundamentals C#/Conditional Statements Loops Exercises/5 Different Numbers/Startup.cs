using System;

namespace _5_Different_Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if (Math.Abs(firstNumber - secondNumber) < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    for (int j = firstNumber; j <= secondNumber; j++)
                    {
                        for (int k = firstNumber; k <= secondNumber; k++)
                        {
                            for (int l = firstNumber; l <= secondNumber; l++)
                            {
                                for (int m = firstNumber; m <= secondNumber; m++)
                                {
                                    if (i < j && j < k && k < l && l < m)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
