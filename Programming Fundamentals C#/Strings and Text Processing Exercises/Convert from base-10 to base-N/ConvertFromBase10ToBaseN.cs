using System;
using System.Linq;

namespace Convert_from_base_10_to_base_N
{
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var baseToConvertIn = inputNumbers[0];
            var numberToConvert = inputNumbers[1];

            var result = string.Empty;
            var temp = numberToConvert;

            while (temp > 0)
            {
                var reminder = temp % baseToConvertIn;
                result = result.Insert(0, (reminder).ToString());

                temp = temp / baseToConvertIn;
            }

            Console.WriteLine(result);
        }
    }
}
