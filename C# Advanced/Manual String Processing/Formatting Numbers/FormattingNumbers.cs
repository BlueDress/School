using System;

namespace Formatting_Numbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();

            var firstNumber = int.Parse(numbers[0]);
            var secondNumber = double.Parse(numbers[1]);
            var thirdNumber = double.Parse(numbers[2]);

            var firstNumberToHex = Convert.ToString(firstNumber, 16).ToUpper();
            var firstNumberToDBin = ConvertFromBase10ToBaseN(firstNumber, 2).PadLeft(10, '0');

            Console.WriteLine(string.Format("|{0, -10}|{1}|{2, 10:f2}|{3, -10:f3}|", firstNumberToHex, firstNumberToDBin, secondNumber, thirdNumber));
        }

        private static string ConvertFromBase10ToBaseN(int number, int baseToConvert)
        {
            var baseToConvertIn = baseToConvert;
            var numberToConvert = number;

            var result = string.Empty;

            while (numberToConvert > 0)
            {
                var reminder = numberToConvert % baseToConvertIn;
                result = result.Insert(0, (reminder).ToString());

                numberToConvert = numberToConvert / baseToConvertIn;
            }

            return result;
        }
    }
}
