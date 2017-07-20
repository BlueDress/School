using System;
using System.Text.RegularExpressions;

namespace Extract_Tags
{
    public class ExtractTags
    {
        public static void Main()
        {
            var pattern = "<.+?>";
            var regex = new Regex(pattern);

            while (true)
            {
                var text = Console.ReadLine();

                if (text.Equals("END"))
                {
                    break;
                }
                else
                {
                    var matches = regex.Matches(text);

                    foreach (var match in matches)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}
