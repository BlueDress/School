using System;
using System.Linq;

namespace Convert_from_base_N_to_base_10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split();

            var baseToConvertFrom = double.Parse(inputNumbers[0]);
            var numberToConvert = inputNumbers[1].Reverse().Select(x => (double)(x - '0')).ToArray();

            var result = 0d;

            for (int i = 0; i < numberToConvert.Length; i++)
            {
                result += numberToConvert[i] * Math.Pow(baseToConvertFrom, i);
            }

            Console.WriteLine(result);
        }
    }
}
