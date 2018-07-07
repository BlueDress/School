using System;

namespace Ch06P09
{
    public class Startup
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

            double sum = 1;
            long factorial = 1;
            double power = secondNumber;

            for (int i = 1; i <= firstNumber; i++)
            {
                sum += (factorial / power);

                factorial *= (i + 1);
                power *= secondNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
