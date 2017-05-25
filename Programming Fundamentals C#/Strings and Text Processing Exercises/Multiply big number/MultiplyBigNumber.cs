using System;
using System.Text;

namespace Multiply_big_number
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var bigNumber = Console.ReadLine().TrimStart('0');
            var singleDigit = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            var toAdd = 0;

            for (int i = bigNumber.Length - 1; i > 0; i--)
            {
                if ((bigNumber[i] - '0') * singleDigit + toAdd < 10)
                {
                    sb = sb.Insert(0, (bigNumber[i] - '0') * singleDigit + toAdd);
                    toAdd = 0;
                }
                else
                {
                    sb = sb.Insert(0, ((bigNumber[i] - '0') * singleDigit + toAdd) % 10);
                    toAdd = ((bigNumber[i] - '0') * singleDigit + toAdd) / 10;
                }
            }

            sb = sb.Insert(0, (bigNumber[0] - '0') * singleDigit + toAdd);

            var result = sb.ToString();
            
            if (int.Parse(result) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
