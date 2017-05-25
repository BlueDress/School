using System;
using System.Text.RegularExpressions;

namespace Replace_a_tag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var patern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                    var replace = @"[URL href=$1]$2[/URL]";
                    var regex = new Regex(patern);
                    var result = regex.Replace(input, replace);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
