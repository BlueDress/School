using System;
using System.Linq;
using System.Text;

namespace Reverse_string
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reversedInput = input.Reverse();

            var result = new StringBuilder();

            foreach (var item in reversedInput)
            {
                result = result.Append(item);
            }
            Console.WriteLine(result);
        }
    }
}
