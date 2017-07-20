using System;
using System.Text.RegularExpressions;

namespace Extract_Integer_Numbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var pattern = @"\d+";
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
