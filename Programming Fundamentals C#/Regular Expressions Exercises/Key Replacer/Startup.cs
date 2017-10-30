using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    public class Startup
    {
        public static void Main()
        {
            var keysStrings = Console.ReadLine().Split(new[] { '\\', '|', '<' }, StringSplitOptions.RemoveEmptyEntries);
            var startKey = keysStrings[0];
            var endKey = keysStrings[keysStrings.Length - 1];

            var textToSearch = Console.ReadLine();

            var sb = new StringBuilder();
            var pattern = $@"{startKey}(.*?){endKey}";

            var matches = Regex.Matches(textToSearch, pattern);

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1]);
            }

            if (sb.ToString().Equals(string.Empty))
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(sb);
            }
        }
    }
}
