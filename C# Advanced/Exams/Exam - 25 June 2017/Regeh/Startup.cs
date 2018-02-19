using System;
using System.Text.RegularExpressions;

namespace Regeh
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\[[^\s*^\[]+<([0-9]+)REGEH([0-9]+)>[^\s*^\]]+\]";

            var matches = Regex.Matches(input, pattern);
            var index = 0;
            var result = string.Empty;

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        index += int.Parse(match.Groups[i].ToString());

                        if (index < input.Length)
                        {
                            result += input[index];
                        }
                        else if (index > input.Length)
                        {
                            result += input[index % input.Length - 1];
                        }
                        else
                        {
                            result += input[0];
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
