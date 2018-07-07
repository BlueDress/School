using System;

namespace Ch03P10
{
    public class Startup
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            int sum = 0;
            string reversedNumber = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
                reversedNumber = number[i] + reversedNumber;
            }

            Console.WriteLine(sum);
            Console.WriteLine(reversedNumber);

            string lastDigitFirst = number[number.Length - 1] + number;
            lastDigitFirst = lastDigitFirst.Remove(lastDigitFirst.Length - 1);

            Console.WriteLine(lastDigitFirst);

            string secondAndThirdDigitReverse = number[0].ToString() + number[2] + number[1] + number[3];

            Console.WriteLine(secondAndThirdDigitReverse);
        }
    }
}
