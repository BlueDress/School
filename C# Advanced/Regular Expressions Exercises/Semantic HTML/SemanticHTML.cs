using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Semantic_HTML
{
    public class SemanticHTML
    {
        public static void Main()
        {
            var openTagPattern = @"<div\s*(.*)\s*(id|class)\s*=\s*""([a-zA-Z]+)""\s*(.*)\s*>";
            var closeTagPattern = @"</div>\s*<!--\s*([a-zA-z]+)\s*-->";

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var regexOpenTag = new Regex(openTagPattern);
                    var regexCloseTag = new Regex(closeTagPattern);

                    var matchOpenTag = regexOpenTag.Match(input);
                    var matchCloseTag = regexCloseTag.Match(input);

                    var sb = new StringBuilder();

                    if (matchOpenTag.Success)
                    {
                        sb.Append($"<{matchOpenTag.Groups[3].Value}");

                        if (!matchOpenTag.Groups[1].Value.Equals(""))
                        {
                            sb.Append($" {matchOpenTag.Groups[1].Value.Trim()}");
                        }

                        if (!matchOpenTag.Groups[4].Value.Equals(""))
                        {
                            sb.Append($" {matchOpenTag.Groups[4].Value}");
                        }

                        sb.Append(">");
                        Console.WriteLine(sb.ToString());

                    }
                    else if (matchCloseTag.Success)
                    {
                        sb.Append($"</{matchCloseTag.Groups[1].Value}>");
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                }
            }
        }
    }
}
