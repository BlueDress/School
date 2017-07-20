using System;
using System.Text.RegularExpressions;

namespace Non_Digit_Count
{
    public class NonDigitCount
    {
        public static void Main()
        {
            var pattern = @"\D";
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
